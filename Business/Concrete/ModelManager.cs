using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        IModelDal _modelDal;

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public IResult Add(Model model)
        {
            _modelDal.Add(model);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Model model)
        {
            _modelDal.Delete(model);
            return new SuccessResult(Messages.Deleted);
        }
        public IResult Update(Model model)
        {
            _modelDal.Update(model);
            return new SuccessResult(Messages.Updated);
        }
        public IDataResult<List<Model>> GetAll()
        {
            return new SuccessDataResult<List<Model>>(_modelDal.GetAll(),Messages.Listed);
        }

        public IDataResult<Model> GetById(int modelId)
        {
            return new SuccessDataResult<Model>(_modelDal.Get(m=>m.Id==modelId), Messages.Listed);
        }

    }
}
