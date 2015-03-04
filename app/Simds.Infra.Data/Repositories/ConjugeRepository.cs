using Simds.Domain.Entities;
using Simds.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Simds.Infra.Data.Repositories
{
	public class ConjugeRepository : RepositoryBase<Conjuge>, IConjugeRepository
	{
		public IEnumerable<Conjuge> BuscaPorCpf(string cpf)
		{
			return Db.Conjuge.Where(c => c.Cpf == cpf);
		}

		public IEnumerable<Conjuge> BuscaPorEquipamentoPublico(int equipamentoPublicoId)
		{
			return Db.Conjuge.Where(c => c.EquipamentoPublicoId == equipamentoPublicoId);
		}

		public IEnumerable<Conjuge> BuscaPorNome(string nome)
		{
			return Db.Conjuge.Where(c => c.Nome == nome);
		}

		public IEnumerable<Conjuge> BuscaPorResponsavel(int pessoaId)
		{
			return Db.Conjuge.Where(c => c.PessoaId == pessoaId);
		}
	}
}
