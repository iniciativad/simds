using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simds.Domain.Entities
{
	public class Sexo
	{
		public int SexoId { get; set; }
		public string Descricao { get; set; }

		public IEnumerable<Sexo> GetAll()
		{
			return new List<Sexo>
			{
				new Sexo { SexoId = 1, Descricao="Feminino" },
				new Sexo { SexoId = 2, Descricao="Masculino" }
			};
		}

	}
}
