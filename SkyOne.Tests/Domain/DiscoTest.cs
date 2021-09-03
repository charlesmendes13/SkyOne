using FluentAssertions;
using SkyOne.Domain.Entities;
using SkyOne.Domain.Enums;
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
        public DiscoTest() { }

        [Fact]
        public void CriarDiscoTest()
        {
            var disco = Disco.Criar(tamanho: 2048, tipo: TipoDeDisco.Boot, ativo: true);

            disco.Should();
        }
    }
}
