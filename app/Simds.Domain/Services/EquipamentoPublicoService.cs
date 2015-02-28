using Simds.Domain.Entities;
using Simds.Domain.Interfaces;
using Simds.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Simds.Domain.Services
{
	public class EquipamentoPublicoService : ServiceBase<EquipamentoPublico>, IEquipamentoPublicoService
	{
		private readonly IEquipamentoPublicoRepository _equipamentoPublicoRepository;
		public EquipamentoPublicoService(IEquipamentoPublicoRepository equipamentoPublicoRepository)
			:base(equipamentoPublicoRepository)
		{
			_equipamentoPublicoRepository = equipamentoPublicoRepository;
		}
        public IEnumerable<EquipamentoPublico> BuscaPorNome(string nome)
		{
			return _equipamentoPublicoRepository.BuscaPorNome(nome);
		}

		public IEnumerable<EquipamentoPublico> BuscaPorPrefeitura(int prefeituraId)
		{
			return _equipamentoPublicoRepository.BuscaPorPrefeitura(prefeituraId);
		}
	}
}
