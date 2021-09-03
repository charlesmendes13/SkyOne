using SkyOne.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyOne.Domain.Entities
{
    public class Instancia
    {
		public Guid Id { get; private set; }
		public string Nome { get; private set; }
		public string SistemaOperacional { get; private set; }
		public int QuantidadeMemoria { get; private set; }
		public List<Disco> Discos { get; private set; }
		public bool Ativo { get; private set; }

		public Instancia() { }

		public static Instancia Criar(string nome,
			string sistemaOperacional,
			int quantidadeMemoria,
			List<Disco> discos,
			bool ativo)
        {
			
			if (string.IsNullOrEmpty(nome))
				throw new InvalidOperationException();

			if (string.IsNullOrEmpty(sistemaOperacional))
				throw new InvalidOperationException();

			if (quantidadeMemoria < 1)
				throw new InvalidOperationException();

			if (!discos.Any(x => x.Tipo == TipoDeDisco.Boot))
				throw new InvalidOperationException();

			if (!Convert.ToBoolean(ativo))
				throw new InvalidOperationException();

			return new Instancia
			{
				Id = Guid.NewGuid(),
				Nome = nome,
				SistemaOperacional = sistemaOperacional,
				QuantidadeMemoria = quantidadeMemoria,
				Discos = discos,
				Ativo = ativo
			};
		}		
	}
}
