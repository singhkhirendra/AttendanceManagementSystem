using Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators
{
    public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
    {
        public UserCreateDtoValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MaximumLength(200);
            RuleFor(x => x.LastName).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Password).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Gender).NotEmpty().Must(g => g == 'M' || g == 'F');
            RuleFor(x => x.RoleId).GreaterThan(0);
            RuleFor(x => x.OrganizationId).GreaterThan(0);
        }
    }
}
