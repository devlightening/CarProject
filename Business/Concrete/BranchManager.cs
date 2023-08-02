using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
namespace Business.Concrete
{
    public class BranchManager : IBranchService
    {
        IBranchDal _branchDal;

        public BranchManager(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        //[SecuredOperation("admin,moderator")]
        public IResult Add(Branch branch)
        {
            var result = BusinessRules.Run(ChecKIfBranchExceeded(), CheckIfBranchNameExist(branch.Title));
            if (result!=null)
            {
                return result;
            }
            _branchDal.Add(branch);
            return new SuccessResult(BranchConstants.BranchAdded);
        }
        [ValidationAspect(typeof(BrandValidator))]
        //[SecuredOperation("admin,moderator")]

        public IResult Delete(Branch branch)
        {
            _branchDal.Delete(branch);
            return new SuccessResult(BranchConstants.BranchDeleted);
        }

        [ValidationAspect(typeof(BrandValidator))]
        //[SecuredOperation("admin,moderator")]
        public IResult Update(Branch branch)
        {
            _branchDal.Update(branch);
            return new SuccessResult(BranchConstants.BranchUpdated);
        }

        public IDataResult<List<Branch>> GetAll()
        {
            return new SuccessDataResult<List<Branch>>(_branchDal.GetAll());
        }

        public IDataResult<List<Branch>> GetByCityId(int cityId)
        {
            return new SuccessDataResult<List<Branch>>(_branchDal.GetAll(c=>c.CityId==cityId));
        }
        //#region BusinessRules
        public IDataResult<Branch> GetById(int id)
        {
            return new SuccessDataResult<Branch>(_branchDal.Get(b => b.Id == id));
        }
        private IResult ChecKIfBranchExceeded()
        {
            var result = _branchDal.GetAll().Count;
            if (result>=5)
            {
                return new ErrorResult(BranchConstants.BranchLimitExceeded);

            }
            return new SuccessResult();
        }
        private IResult CheckIfBranchNameExist(string branchName)
        {
            var result = _branchDal.GetAll(b=>b.Title== branchName).Any();
            if (result)
            {
                return new ErrorResult(BranchConstants.BranchNameAlreadyExist);

            }
            return new SuccessResult();
        }
        //#endregion
    }
}
