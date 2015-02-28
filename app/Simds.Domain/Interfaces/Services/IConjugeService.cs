using Simds.Domain.Entities;
using System.Collections.Generic;

namespace Simds.Domain.Interfaces.Services
{
	public interface IConjugeService :IServiceBase<Conjuge>
	{
		IEnumerable<Conjuge> BuscaPorNome(string nome);
		IEnumerable<Conjuge> BuscaPorCpf(string cpf);
		IEnumerable<Conjuge> BuscaPorEquipamentoPublico(int equipamentoPublicoId);
		IEnumerable<Conjuge> BuscaPorResponsavel(int pessoaId);
	}
}
