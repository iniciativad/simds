using Simds.Domain.Entities;
using System.Collections.Generic;

namespace Simds.Application.Interfaces
{
	public interface IDependenteAppService : IAppServiceBase<Dependente>
	{
		IEnumerable<Dependente> BuscaPorNome(string nome);
		IEnumerable<Dependente> BuscaPorCpf(string cpf);
		IEnumerable<Dependente> BuscaPorEquipamentoPublico(int equipamentoPublicoId);
		IEnumerable<Dependente> BuscaPorResponsavel(int pessoaId);
	}
}
