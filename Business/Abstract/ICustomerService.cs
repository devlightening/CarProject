using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer costumer);
        IResult Update(Customer costumer);
        IResult Delete(Customer costumer);
        IDataResult<Customer> GetById(int Id);
        IDataResult<List<Customer>> GetAll();


    }
}
