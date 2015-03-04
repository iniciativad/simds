using Simds.Domain.Entities;
using Simds.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Simds.Infra.Data.Repositories
{
	public class EquipamentoPublicoRepository : RepositoryBase<EquipamentoPublico>, IEquipamentoPublicoRepository
	{
		public IEnumerable<EquipamentoPublico> BuscaPorNome(string nome)
		{
			return Db.EquipamentoPublico.Where(e => e.NomeFantasia == nome);
        }

		public IEnumerable<EquipamentoPublico> BuscaPorPrefeitura(int prefeituraId)
		{
			return Db.EquipamentoPublico.Where(e => e.PrefeituraId == prefeituraId);
		}
	}
}
