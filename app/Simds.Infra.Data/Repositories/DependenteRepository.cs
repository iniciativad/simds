using Simds.Domain.Entities;
using Simds.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Simds.Infra.Data.Repositories
{
	public class DependenteRepository : RepositoryBase<Dependente>, IDependenteRepository
	{
		public IEnumerable<Dependente> BuscaPorCpf(string cpf)
		{
			return Db.Dependente.Where(d => d.Cpf == cpf);
		}

		public IEnumerable<Dependente> BuscaPorEquipamentoPublico(int equipamentoPublicoId)
		{
			return Db.Dependente.Where(d => d.EquipamentoPublicoId == equipamentoPublicoId);
		}

		public IEnumerable<Dependente> BuscaPorNome(string nome)
		{
			return Db.Dependente.Where(d => d.Nome == nome);
		}

		public IEnumerable<Dependente> BuscaPorResponsavel(int pessoaId)
		{
			return Db.Dependente.Where(d => d.PessoaId == pessoaId);
		}
	}
}
