using System.Collections.Generic;

namespace Simds.Domain.Entities
{
	public class Escolaridade
	{
		public int EscolaridadeId { get; set; }
		public string Descricao { get; set; }

		public IEnumerable<Escolaridade> GetAll()
		{
			return new List<Escolaridade>
			{
				new Escolaridade{EscolaridadeId=0,Descricao = "Não Alfabetizado"},
				new Escolaridade{EscolaridadeId=1,Descricao = "Ensino Fundamental Incompleto"},
				new Escolaridade{EscolaridadeId=2,Descricao = "Ensino Fundamental Completo"},
				new Escolaridade{EscolaridadeId=3,Descricao = "Médio Incompleto"},
				new Escolaridade{EscolaridadeId=4,Descricao = "Médio Completo"},
				new Escolaridade{EscolaridadeId=5,Descricao = "Superior Incompleto"},
				new Escolaridade{EscolaridadeId=6,Descricao = "Superior Completo"},
				new Escolaridade{EscolaridadeId=7,Descricao = "Especialização"},
				new Escolaridade{EscolaridadeId=8,Descricao = "Mestrado"},
				new Escolaridade{EscolaridadeId=9,Descricao = "Doutorado"},
			};
		}
	}
}