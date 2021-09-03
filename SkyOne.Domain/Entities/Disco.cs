using SkyOne.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyOne.Domain.Entities
{
    public class Disco
    {
        public Guid Id { get; private set; }
        public int Tamanho { get; private set; }
        public TipoDeDisco Tipo { get; private set; }
        public bool Ativo { get; private set; }

        public Disco() { }

        public static Disco Criar(int tamanho,
            TipoDeDisco tipo,
            bool ativo)
        {
            if (tamanho < 1)
                throw new InvalidOperationException();

            if (!Enum.IsDefined(typeof(TipoDeDisco), tipo))
                throw new InvalidOperationException();
         
            if (!Convert.ToBoolean(ativo))
                throw new InvalidOperationException();

            return new Disco
            {
                Id = Guid.NewGuid(),
                Tamanho = tamanho,
                Tipo = tipo,
                Ativo = ativo
            };
        }        
    }
}
