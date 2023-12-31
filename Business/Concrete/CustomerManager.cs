﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        [SecuredOperation("admin,moderator")]
        public IResult Add(Customer customer)
        {
            var result = BusinessRules.Run(CheckIfCustomerExist(customer.UserId));
            if (result != null)
            {
                return result;
            }
            _customerDal.Add(customer);
            return new SuccessResult(CustomerConstants.CustomerAdded);
        }

        [SecuredOperation("admin,moderator")]
        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(CustomerConstants.CustomerDeleted);
        }

        [ValidationAspect(typeof(CustomerValidator))]
        [SecuredOperation("admin,moderator")]
        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(CustomerConstants.CustomerUpdated);
        }
        //#region BusinessRules
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),CustomerConstants.AllCustomerGetted);
        }

        public IDataResult<Customer> GetById(int Id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.UserId == Id), CustomerConstants.CustomerGettedById);
        } 
        private IResult CheckIfCustomerExist(int userId)
        {
            var result=_customerDal.GetAll(c=>c.UserId==userId).Any();
            if (result)
            {
                return new ErrorResult(CustomerConstants.CustomerAlreadyExist);
            }
            return new SuccessResult();
        }
        //#endregion
    }
}

