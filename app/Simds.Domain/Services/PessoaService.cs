using Simds.Domain.Entities;
using Simds.Domain.Interfaces;
using Simds.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Simds.Domain.Services
{
	public class PessoaService : ServiceBase<Pessoa>, IPessoaService
	{
		private readonly IPessoaRepository _pessoaRepository;
		public PessoaService(IPessoaRepository pessoaRepository)
			:base(pessoaRepository)
		{
			_pessoaRepository = pessoaRepository;
		}
		public IEnumerable<Pessoa> BuscaPorCpf(string cpf)
		{
			return _pessoaRepository.BuscaPorCpf(cpf);
		}

		public IEnumerable<Pessoa> BuscaPorEquipamentoPublico(int equipamentoPublicoId)
		{
			return _pessoaRepository.BuscaPorEquipamentoPublico(equipamentoPublicoId);
		}

		public IEnumerable<Pessoa> BuscaPorNome(string nome)
		{
			return _pessoaRepository.BuscaPorNome(nome);
		}
	}
}
