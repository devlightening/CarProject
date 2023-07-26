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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer costumer)
        {
            _customerDal.Add(costumer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Customer costumer)
        {
            _customerDal.Delete(costumer);
            return new SuccessResult(Messages.Deleted);
        }
        public IResult Update(Customer costumer)
        {
            _customerDal.Update(costumer);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.Listed);
        }

        public IDataResult<Customer> GetById(int Id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.UserId == Id), Messages.Listed);
        }    
    }
}

