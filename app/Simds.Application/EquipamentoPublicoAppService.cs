using Simds.Application.Interfaces;
using Simds.Domain.Entities;
using Simds.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Simds.Application
{
	public class EquipamentoPublicoAppService : AppServiceBase<EquipamentoPublico>, IEquipamentoPublicoAppService
	{
		private readonly IEquipamentoPublicoService _equipamentoPublicoService;
		public EquipamentoPublicoAppService(IEquipamentoPublicoService equipamentoPublicoService)
			:base(equipamentoPublicoService)
		{
			_equipamentoPublicoService = equipamentoPublicoService;
		}
		public IEnumerable<EquipamentoPublico> BuscaPorNome(string nome)
		{
			return _equipamentoPublicoService.BuscaPorNome(nome);
		}

		public IEnumerable<EquipamentoPublico> BuscaPorPrefeitura(int prefeituraId)
		{
			return _equipamentoPublicoService.BuscaPorPrefeitura(prefeituraId);
		}
	}
}
