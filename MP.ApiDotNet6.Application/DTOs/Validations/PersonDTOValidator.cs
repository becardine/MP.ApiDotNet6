using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.DTOs.Validations
{
    public class PersonDTOValidator : AbstractValidator<PersonDTO>
    {
        public PersonDTOValidator()
        {
            RuleFor(p => p.Name).NotEmpty().NotNull().WithMessage("Nome deve ser informado!");
            RuleFor(p => p.Document).NotEmpty().NotNull().WithMessage("Documento deve ser informado!");
            RuleFor(p => p.Phone).NotEmpty().NotNull().WithMessage("Telefone deve ser informado!");
        }
    }
}
