using Simds.Domain.Entities;
using Simds.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace Simds.Infra.Data.Repositories
{
	public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
	{
		public IEnumerable<Pessoa> BuscaPorCpf(string cpf)
		{
			return Db.Pessoa.Where(p => p.Cpf == cpf);
		}

		public IEnumerable<Pessoa> BuscaPorEquipamentoPublico(int equipamentoPublicoId)
		{
			return Db.Pessoa.Where(p => p.EquipamentoPublicoId == equipamentoPublicoId);
		}

		public IEnumerable<Pessoa> BuscaPorNome(string nome)
		{
			return Db.Pessoa.Where(p => p.Nome == nome);
		}
	}
}
