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
    public class UserVerifyManager : IUserVerifyService
    {
        public IDataResult<UserVerify> Add(string mail)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(UserVerify userVerify)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserVerify>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserVerify> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserVerify>> GetByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public UserVerify GetByVerifyToken(string verifyToken)
        {
            throw new NotImplementedException();
        }

        public IResult Update(UserVerify userVerify)
        {
            throw new NotImplementedException();
        }

        public IResult Verify(string verifyToken)
        {
            throw new NotImplementedException();
        }
    }
}
