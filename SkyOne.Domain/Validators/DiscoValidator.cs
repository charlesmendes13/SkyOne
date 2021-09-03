using FluentValidation;
using SkyOne.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyOne.Domain.Validators
{
    public class DiscoValidator : AbstractValidator<Disco>
    {
        public DiscoValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().NotNull()
                .WithMessage("O Id não pode ser nulo");

            RuleFor(x => x.Tamanho > 0)
                .NotEmpty().NotNull()
                .WithMessage("O Tamanho deve ser maior que 1 (um)");

            RuleFor(x => x.Tipo)
                .NotEmpty().NotNull()
                .WithMessage("O Tipo não pode ser nulo");

            RuleFor(x => x.Ativo == true)
                .NotEmpty().NotNull()
                .WithMessage("O Disco deve ser ativo");
        }
    }
}
