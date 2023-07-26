using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IAuthService _authService;
        IUserService _userService;
        IToken

        public AuthManager(IAuthService authService)
        {
            _authService = authService;
        }

        public IDataResult<User> LogIn(UserForLogInDto userForLogInDto)
        {
            
           
        }

        public IDataResult<User> Register(UserForRegisterDto userRegisterDto, string passaword)
        {
            throw new NotImplementedException();
        }

        public IResult UserExist(string email)
        {
            throw new NotImplementedException();
        }
    }
}
