using Simds.Domain.Entities;
using Simds.Domain.Interfaces;
using Simds.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Simds.Domain.Services
{
	public class DependenteService : ServiceBase<Dependente>, IDependenteService
	{
		private readonly IDependenteRepository _dependenteRepository;
		public DependenteService(IDependenteRepository dependenteRepository)
			:base(dependenteRepository)
        {
			_dependenteRepository = dependenteRepository;
        }
		public IEnumerable<Dependente> BuscaPorCpf(string cpf)
		{
			return _dependenteRepository.BuscaPorCpf(cpf);
		}

		public IEnumerable<Dependente> BuscaPorEquipamentoPublico(int equipamentoPublicoId)
		{
			return _dependenteRepository.BuscaPorEquipamentoPublico(equipamentoPublicoId);
		}

		public IEnumerable<Dependente> BuscaPorNome(string nome)
		{
			return _dependenteRepository.BuscaPorNome(nome);
		}

		public IEnumerable<Dependente> BuscaPorResponsavel(int pessoaId)
		{
			return _dependenteRepository.BuscaPorResponsavel(pessoaId);
		}
	}
}
