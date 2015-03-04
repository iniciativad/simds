using Simds.Domain.Entities;
using System.Collections.Generic;

namespace Simds.Application.Interfaces
{
	public interface IEquipamentoPublicoAppService : IAppServiceBase<EquipamentoPublico>
	{
		IEnumerable<EquipamentoPublico> BuscaPorNome(string nome);
		IEnumerable<EquipamentoPublico> BuscaPorPrefeitura(int prefeituraId);
	}
}
