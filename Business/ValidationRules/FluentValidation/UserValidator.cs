using Business.Constants;
using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u=>u.Email).NotEmpty();
            RuleFor(u=>u.FirstName).MinimumLength(2).WithMessage(Messages.InvalidName);
            RuleFor(u=>u.LastName).MinimumLength(2).WithMessage(Messages.InvalidName);
        }
    }
}
