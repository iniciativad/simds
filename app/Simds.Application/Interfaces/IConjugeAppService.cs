using Simds.Domain.Entities;
using System.Collections.Generic;

namespace Simds.Application.Interfaces
{
	public interface IConjugeAppService : IAppServiceBase<Conjuge>
	{
		IEnumerable<Conjuge> BuscaPorNome(string nome);
		IEnumerable<Conjuge> BuscaPorCpf(string cpf);
		IEnumerable<Conjuge> BuscaPorEquipamentoPublico(int equipamentoPublicoId);
		IEnumerable<Conjuge> BuscaPorResponsavel(int pessoaId);
	}
}
