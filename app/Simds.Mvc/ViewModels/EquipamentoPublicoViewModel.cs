
using System.ComponentModel.DataAnnotations;

namespace Simds.Mvc.ViewModels
{
	public class EquipamentoPublicoViewModel
	{
		[Key]
		public int EquipamentoPublicoId { get; set; }
		[Display(Name = "Razão Social")]
		public string RazaoSocial { get; set; }
		[Display(Name = "Nome Fantasia")]
		public string NomeFantasia { get; set; }

		public string Cnpj { get; set; }
		public string Cep { get; set; }
		[Display(Name = "Rua/Av.")]
		public string Logradouro { get; set; }
		public string Numero { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Uf { get; set; }


		public string Telefone { get; set; }
		public string Email { get; set; }

		public string Responsavel { get; set; }

		public string ResponsavelCpf { get; set; }

		public string ResponsavelCargo { get; set; }
		[Display(Name = "Vinculo")]
		public int EquipamentoPublicoTipoId { get; set; }
		
	}
}