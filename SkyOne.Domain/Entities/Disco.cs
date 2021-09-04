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

        public Disco(int tamanho,
            TipoDeDisco tipo,
            bool ativo)
        {
            if (tamanho < 1)
                throw new InvalidOperationException("O tamanho deve ser maior que 1");

            if (!Enum.IsDefined(typeof(TipoDeDisco), tipo))
                throw new InvalidOperationException("O Tipo do Disco deve ser definido");
         
            if (!Convert.ToBoolean(ativo))
                throw new InvalidOperationException("O valor de ativo dever ser 'true/false'");

            Id = Guid.NewGuid();
            Tamanho = tamanho;
            Tipo = tipo;
            Ativo = ativo;           
        }   
    }
}
