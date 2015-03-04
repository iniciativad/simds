using System.ComponentModel.DataAnnotations;

namespace Simds.Mvc.ViewModels
{
	public class EscolaridadeViewModel
	{
		[Key]
		public int EscolaridadeId { get; set; }
		public string Descricao { get; set; }
	}
}