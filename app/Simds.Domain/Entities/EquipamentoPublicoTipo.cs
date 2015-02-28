using System.Collections.Generic;

namespace Simds.Domain.Entities
{
	public class EquipamentoPublicoTipo
	{
		public int EquipamentoPublicoTipoId { get; set; }
		public string Nome { get; set; }

		public IEnumerable<EquipamentoPublicoTipo> GetAll()
		{
			return new List<EquipamentoPublicoTipo> {
				new EquipamentoPublicoTipo {EquipamentoPublicoTipoId = 1,Nome="ALBERGUE" },
				new EquipamentoPublicoTipo {EquipamentoPublicoTipoId = 2,Nome="CASA DE PASSAGEM" },
				new EquipamentoPublicoTipo {EquipamentoPublicoTipoId = 3,Nome="CRAS" },
				new EquipamentoPublicoTipo {EquipamentoPublicoTipoId = 4,Nome="CREAS" },
				new EquipamentoPublicoTipo {EquipamentoPublicoTipoId = 5,Nome="SECRETARIA DE PORMOÇÃO SOCIAL" }
			};
		}
	}
}
