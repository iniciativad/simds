namespace Simds.Domain.Entities
{
	public class Cartao
	{
		public int CartaoId { get; set; }
		public int PessoaId { get; set; }
		public string Chip { get; set; }
		public virtual Pessoa Pessoa { get; set; }
	}
}
