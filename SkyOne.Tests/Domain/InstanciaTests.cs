using SkyOne.Domain.Entities;
using SkyOne.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace SkyOne.Tests.Domain
{
    public class InstanciaTests
    {
        public InstanciaTests() { }

        [Fact]
        public void CriarInstanciaTest()
        {
            var instancia = new Instancia(nome: "PC", 
                sistemaOperacional: "Linux", 
                quantidadeMemoria: 1024, 
                discos: new List<Disco>() 
                { 
                    new Disco(tamanho: 2048, tipo: TipoDeDisco.Boot, ativo: true),
                    new Disco(tamanho: 2048, tipo: TipoDeDisco.Armazenamento, ativo: true)
                }, 
                ativo: true);            

            instancia.Should();
        }       
    }
}
