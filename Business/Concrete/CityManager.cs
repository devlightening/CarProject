﻿using Business.Abstract;
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
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
             _cityDal.Add(city);
            return new SuccessResult();
        }

        public IResult Delete(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult();
        }
        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult();
        }
        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll());
        }
    }
}
