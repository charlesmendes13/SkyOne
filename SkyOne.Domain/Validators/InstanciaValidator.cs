using FluentValidation;
using SkyOne.Domain.Entities;
using SkyOne.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyOne.Domain.Validation
{
    public class InstanciaValidator : AbstractValidator<Instancia>
    {
        public InstanciaValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().NotNull()
                .WithMessage("O Id não pode ser nulo");

            RuleFor(x => x.Nome)
                .NotEmpty().NotNull()
                .WithMessage("O Nome não pode ser nulo");

            RuleFor(x => x.SistemaOperacional)
                .NotEmpty().NotNull()
                .WithMessage("O SistemaOperacional não pode ser nulo");

            RuleFor(x => x.QuantidadeMemoria > 0)
                .NotEmpty().NotNull()
                .WithMessage("A QuantidadeMemoria deve ser maior que 1 (um)");

            RuleFor(x => x.Discos.Any(x => x.Tipo == TipoDeDisco.Boot))
                .NotEmpty().NotNull()
                .WithMessage("Deve-se ter pelo menos 1 (um) disco de boot");

            RuleFor(x => x.Ativo == true)
               .NotEmpty().NotNull()
               .WithMessage("A Instancia deve ser ativa");
        }
    }
}
