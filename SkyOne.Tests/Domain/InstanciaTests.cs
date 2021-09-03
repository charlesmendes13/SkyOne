using SkyOne.Domain.Entities;
using SkyOne.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using SkyOne.Domain.Validation;
using SkyOne.Domain.Validators;

namespace SkyOne.Tests.Domain
{
    public class InstanciaTests
    {
        private readonly InstanciaValidator _instanciaValidator;

        public InstanciaTests()
        {
            _instanciaValidator = new InstanciaValidator();
        }

        [Fact]
        public void CriarInstanciaTest()
        {         
            var instancia = new Instancia()
            {
                Id = Guid.Parse("02cf6e5d-cf69-4797-90aa-198b6bc83f00"),
                Nome = "Meu PC",
                SistemaOperacional = "Windows",
                QuantidadeMemoria = 1024,
                Discos = new List<Disco>()
                {
                    new Disco
                    {
                        Id = Guid.Parse("e5e60d5d-7466-42da-96e4-ee8670a582df"),
                        Tamanho = 1024,
                        Tipo = TipoDeDisco.Boot,
                        Ativo = true
                    },
                    new Disco
                    {
                        Id = Guid.Parse("7784a60c-f0cd-4416-8070-985b63ba6f8d"),
                        Tamanho = 1024,
                        Tipo = TipoDeDisco.Armazenamento,
                        Ativo = true
                    }
                },
                Ativo = true
            };

            _instanciaValidator.Validate(instancia).Errors.Should().BeNullOrEmpty();

            _instanciaValidator.Should();
        }       
    }
}
