using Simds.Domain.Entities;
using System.Collections.Generic;

namespace Simds.Domain.Interfaces.Services
{
	public interface IPessoaService :IServiceBase<Pessoa>
	{
		IEnumerable<Pessoa> BuscaPorNome(string nome);
		IEnumerable<Pessoa> BuscaPorCpf(string cpf);
		IEnumerable<Pessoa> BuscaPorEquipamentoPublico(int equipamentoPublicoId);
	}
}
