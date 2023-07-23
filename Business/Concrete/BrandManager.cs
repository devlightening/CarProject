using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        public Result Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public Result Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Brand> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Result Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
