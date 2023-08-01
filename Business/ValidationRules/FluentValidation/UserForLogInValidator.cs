using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserForLogInValidator : AbstractValidator<UserForLogInDto>
    {
      public UserForLogInValidator()
        {
            RuleFor(u=>u.Email).EmailAddress();
            RuleFor(u=>u.Email).NotEmpty();
            RuleFor(u=>u.Password).NotEmpty();

        }
    }
}
