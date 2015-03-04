using Simds.Application.Interfaces;
using Simds.Domain.Entities;
using Simds.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Simds.Application
{
	public class DependenteAppService : AppServiceBase<Dependente>, IDependenteAppService
	{
		private readonly IDependenteService _dependenteService;
		public DependenteAppService(IDependenteService dependenteService)
			:base(dependenteService)
		{
			_dependenteService = dependenteService;
		}
		public IEnumerable<Dependente> BuscaPorCpf(string cpf)
		{
			return _dependenteService.BuscaPorCpf(cpf);
		}

		public IEnumerable<Dependente> BuscaPorEquipamentoPublico(int equipamentoPublicoId)
		{
			return _dependenteService.BuscaPorEquipamentoPublico(equipamentoPublicoId);
		}

		public IEnumerable<Dependente> BuscaPorNome(string nome)
		{
			return _dependenteService.BuscaPorNome(nome);
		}

		public IEnumerable<Dependente> BuscaPorResponsavel(int pessoaId)
		{
			return _dependenteService.BuscaPorResponsavel(pessoaId);
		}
	}
}
