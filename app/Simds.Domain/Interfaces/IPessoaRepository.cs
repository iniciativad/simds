using Simds.Domain.Entities;
using System.Collections.Generic;

namespace Simds.Domain.Interfaces
{
	public interface IPessoaRepository :IRepositoryBase<Pessoa>
	{
		//Metodos especializados aqui

		IEnumerable<Pessoa> BuscaPorNome(string nome);
		IEnumerable<Pessoa> BuscaPorCpf(string cpf);
		IEnumerable<Pessoa> BuscaPorEquipamentoPublico(int equipamentoPublicoId);
	}
}
