using Simds.Domain.Entities;
using System.Collections.Generic;

namespace Simds.Domain.Interfaces.Services
{
	public interface IEquipamentoPublicoService : IServiceBase<EquipamentoPublico>
	{
		IEnumerable<EquipamentoPublico> BuscaPorNome(string nome);
		IEnumerable<EquipamentoPublico> BuscaPorPrefeitura(int prefeituraId);
	}
}
