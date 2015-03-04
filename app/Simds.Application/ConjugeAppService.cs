using Simds.Application.Interfaces;
using Simds.Domain.Entities;
using Simds.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace Simds.Application
{
	public class ConjugeAppService : AppServiceBase<Conjuge>, IConjugeAppService
	{
		private readonly IConjugeService _conjugeService;
		public ConjugeAppService(IConjugeService conjugeService)
			: base(conjugeService)
		{
			_conjugeService = conjugeService;
		}
		public IEnumerable<Conjuge> BuscaPorCpf(string cpf)
		{
			return _conjugeService.BuscaPorCpf(cpf);
		}

		public IEnumerable<Conjuge> BuscaPorEquipamentoPublico(int equipamentoPublicoId)
		{
			return _conjugeService.BuscaPorEquipamentoPublico(equipamentoPublicoId);
		}

		public IEnumerable<Conjuge> BuscaPorNome(string nome)
		{
			return _conjugeService.BuscaPorNome(nome);
		}

		public IEnumerable<Conjuge> BuscaPorResponsavel(int pessoaId)
		{
			return _conjugeService.BuscaPorResponsavel(pessoaId);
		}
	}
}
