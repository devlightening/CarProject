using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        //[ValidationAspect(typeof(CarValidator))]
        //[SecuredOperation("admin,moderator")]
        //[CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            var result = BusinessRules.Run(CheckIfCarCountOfBrandCorrect(car.BrandId), CheckIfCarNameExists(car.CarName));
            if (result!=null)
            {
                return result;
            }
            _carDal.Add(car);
            return new SuccessResult(CarConstants.CarAdded);
        }
         //[SecuredOperation("admin,moderator")]
         //[CacheRemoveAspect("ICarService.Get")]
         //[SecuredOperation("admin,moderator")]
         public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(CarConstants.CarDeleted);
        }

        //[SecuredOperation("admin,moderator")]
        //[CacheRemoveAspect("ICarService.Get")]
        //[SecuredOperation("admin,moderator")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(CarConstants.CarUpdated);
        }
        //[CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            _carDal.GetAll();
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), CarConstants.AllCarGetted);
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }
        //[CacheAspect]
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id), CarConstants.CarGettedById);
        }

        public IDataResult<CarDetailDto> GetCarDetailsById(int id)
        {
            return new SuccessDataResult<CarDetailDto>(_carDal.GetCarsDetails(c => c.CarId == id).FirstOrDefault());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetials()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetails());
        }

        private IResult CheckIfCarNameExists(string carName)
        {
            if (_carDal.GetAll(c => c.CarName == carName).Any())
            {
                return new ErrorResult(CarConstants.CarNameAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfCarCountOfBrandCorrect(int brandId)
        {
         var result =_carDal.GetAll(c => c.BrandId == brandId).Count;
            if (result >= 15) 
            {
                return new ErrorResult(CarConstants.CarCountOfBrandCorrect);
            }
            return new SuccessResult();
        }

    }
}