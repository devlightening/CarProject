using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        ICarService _carService;

        public BrandManager(IBrandDal brandDal,ICarService carService)
        {
            _brandDal = brandDal;
            _carService = carService;
        }
        [ValidationAspect(typeof(BrandValidator))]
        //[SecuredOperation("admin,moderator")]
        public IResult Add(Brand brand)
        {
            var result = BusinessRules.Run(ChecKBrandCountIfGreatherThen5(), ChecKBrandNameExists(brand.BrandName));
            if (result!=null)
            {
                return result;
            }
            _brandDal.Add(brand);
            return new SuccessResult(BrandConstants.BrandAdded); 
        }
        //[SecuredOperation("admin,moderator")]
        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(BrandConstants.BrandDeleted);
        }

        [ValidationAspect(typeof(BrandValidator))]
        //[SecuredOperation("admin,moderator")]
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(BrandConstants.BrandUpdated);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId));
        }


        //#region BusinessRules

        private IResult ChecKBrandNameExists(string brandName)
        {
            var result = _brandDal.GetAll(b => b.BrandName == brandName).Any();
            if (result)
            {
                return new ErrorResult(BrandConstants.BrandNameExists);

            }
            return new SuccessResult();
        }
        private IResult ChecKBrandIsHaveCar(int brandId)
        {
            var result = _carService.GetByBrandId(brandId).Any();
            if (result)
            {
                return new ErrorResult(BrandConstants.BrandIsHaveCarCantDeleted);
            }

            return new SuccessResult();
        }
        private IResult ChecKBrandCountIfGreatherThen5()
        {
            var result = _brandDal.GetAll().Count;
            if (result>5)
            {
                return new ErrorResult(BrandConstants.MaximumBrandLimitExceeded);

            }
            return new SuccessResult();
        }
    }
}
