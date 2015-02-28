using Simds.Domain.Entities;
using Simds.Domain.Interfaces;
using Simds.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Simds.Domain.Services
{
	public class ConjugeService : ServiceBase<Conjuge>, IConjugeService
	{
		private readonly IConjugeRepository _conjugeRepository;

		public ConjugeService(IConjugeRepository conjugeRepository)
			:base(conjugeRepository)
		{
			_conjugeRepository = conjugeRepository;
		}


		public IEnumerable<Conjuge> BuscaPorCpf(string cpf)
		{
			return _conjugeRepository.BuscaPorCpf(cpf);
		}

		public IEnumerable<Conjuge> BuscaPorEquipamentoPublico(int equipamentoPublicoId)
		{
			return _conjugeRepository.BuscaPorEquipamentoPublico(equipamentoPublicoId);
		}

		public IEnumerable<Conjuge> BuscaPorNome(string nome)
		{
			return _conjugeRepository.BuscaPorNome(nome);
		}

		public IEnumerable<Conjuge> BuscaPorResponsavel(int pessoaId)
		{
			return _conjugeRepository.BuscaPorResponsavel(pessoaId);
		}
	}
}
