using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserVerifyService
    {
        IResult Delete(UserVerify userVerify);
        IResult Update(UserVerify userVerify);
        IResult Verify(string verifyToken);
        IDataResult<UserVerify> Add(string mail);
        IDataResult<List<UserVerify>> GetAll();
        IDataResult<UserVerify> GetById(int id);
        IDataResult<List<UserVerify>> GetByUserId(int userId);
        UserVerify GetByVerifyToken(string verifyToken);

    }
}
