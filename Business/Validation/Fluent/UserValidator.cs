using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.Fluent
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(2).MaximumLength(20).WithMessage("Kullanıcı adı 2 ile 20 karakter arasında olmalıdır.");
            //RuleFor(p => p.UserPassword).NotEmpty();
            //RuleFor(p => p.UserPassword).MinimumLength(5).MaximumLength(20).WithMessage("Parolanız adı 5 ile 20 karakter arasında olmalıdır.");
        }
    }
}
