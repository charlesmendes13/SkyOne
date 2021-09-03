using FluentAssertions;
using SkyOne.Domain.Entities;
using SkyOne.Domain.Enum;
using SkyOne.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SkyOne.Tests.Domain
{
    public class DiscoTest
    {
        private readonly DiscoValidator _discoValidator;

        public DiscoTest()
        {
            _discoValidator = new DiscoValidator();
        }

        [Fact]
        public void CriarDiscoTest()
        {
            var discos = new List<Disco>()
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
            };

            foreach (var disco in discos)
            {
                _discoValidator.Validate(disco).Errors.Should().BeNullOrEmpty();

                _discoValidator.Should();
            }
        }
    }
}
