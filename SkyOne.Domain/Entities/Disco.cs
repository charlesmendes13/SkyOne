using SkyOne.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyOne.Domain.Entities
{
    public class Disco
    {
        public Guid Id { get; set; }

        public int Tamanho { get; set; }

        public TipoDeDisco Tipo { get; set; }

        public bool Ativo { get; set; }
    }
}
