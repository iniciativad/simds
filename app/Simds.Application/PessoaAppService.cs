using Simds.Application.Interfaces;
using Simds.Domain.Entities;
using Simds.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Simds.Application
{
	public class PessoaAppService : AppServiceBase<Pessoa>, IPessoaAppService
	{
		public readonly IPessoaService _pessoaService;
		public PessoaAppService(IPessoaService pessoaService)
			:base(pessoaService)
		{
			_pessoaService = pessoaService;
		}
		public IEnumerable<Pessoa> BuscaPorCpf(string cpf)
		{
			return _pessoaService.BuscaPorCpf(cpf);
		}

		public IEnumerable<Pessoa> BuscaPorEquipamentoPublico(int equipamentoPublicoId)
		{
			return _pessoaService.BuscaPorEquipamentoPublico(equipamentoPublicoId);
		}

		public IEnumerable<Pessoa> BuscaPorNome(string nome)
		{
			return _pessoaService.BuscaPorNome(nome);
		}
	}
}
