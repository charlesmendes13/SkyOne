using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyOne.Domain.Entities
{
    public class Instancia
    {
		public Guid Id { get; set; }

		public string Nome { get; set; }

		public string SistemaOperacional { get; set; }

		public int QuantidadeMemoria { get; set; }

		public List<Disco> Discos { get; set; }

		public bool Ativo { get; set; }
	}
}
