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

		public Instancia(string nome,
			string sistemaOperacional,
			int quantidadeMemoria,
			List<Disco> discos,
			bool ativo)
        {
			
			if (string.IsNullOrEmpty(nome))
				throw new InvalidOperationException("O nome não pode ser nulo");

			if (string.IsNullOrEmpty(sistemaOperacional))
				throw new InvalidOperationException("O Sistema Operacional não pode ser nulo");

			if (quantidadeMemoria < 1)
				throw new InvalidOperationException("O Tamanho da Memória não pode ser nulo");

			if (!discos.Any(x => x.Tipo == TipoDeDisco.Boot))
				throw new InvalidOperationException("A Instanciua deve conter um Disco de Boot");

			if (!Convert.ToBoolean(ativo))
				throw new InvalidOperationException("O valor de ativo dever ser 'true/false'");

			Id = Guid.NewGuid();
			Nome = nome;
			SistemaOperacional = sistemaOperacional;
			QuantidadeMemoria = quantidadeMemoria;
			Discos = discos;
			Ativo = ativo;			
		}		
	}
}
