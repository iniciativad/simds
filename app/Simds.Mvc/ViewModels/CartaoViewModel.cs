using System.ComponentModel.DataAnnotations;

namespace Simds.Mvc.ViewModels
{
	public class CartaoViewModel
	{
		[Key]
		public int CartaoId { get; set; }
		[Required]
		public int PessoaId { get; set; }
		[Required]
		public string Chip { get; set; }
		public virtual PessoaViewModel Pessoa { get; set; }
	}
}