using Simds.Domain.Entities;
using System.Collections.Generic;

namespace Simds.Domain.Interfaces
{
	public interface IEquipamentoPublicoRepository : IRepositoryBase<EquipamentoPublico>
	{
		IEnumerable<EquipamentoPublico> BuscaPorNome(string nome);
		IEnumerable<EquipamentoPublico> BuscaPorPrefeitura(int prefeituraId);
	}
}
