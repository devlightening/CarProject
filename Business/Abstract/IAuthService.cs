using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userRegisterDto, string passaword);
        IDataResult<User> LogIn(UserForLogInDto userForLogInDto);
        IResult UserExist(string email);
        //IDataResult<AccesToken>
    }
}
