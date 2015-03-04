using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Simds.Mvc.ViewModels
{
	public class PessoaViewModel
	{
		[Key]
		public int PessoaId { get; set; }
		[Required(ErrorMessage = "Preencha o campo Nome")]
		[MaxLength(75)]
		public string Nome { get; set; }
		[Display(Name = "Dt. Nascimento")]
		public DateTime DataNascimento { get; set; }
		public string Rg { get; set; }
		[Display(Name = "Orgão Emissor")]
		public string RgOrgaoEmissor { get; set; }
		[Display(Name = "Uf do Orgão Emissor")]
		public string RgOrgaoEmissorUf { get; set; }
		[Display(Name = "Dt. de Emissão do Rg")]
		public DateTime? RgOrgaoEmissorDtEmissao { get; set; }
		[MaxLength(11)]
		[MinLength(11)]
		public string Cpf { get; set; }
		[Display(Name = "Titulo de eleitor")]
		public string TituloEleitor { get; set; }
		[Display(Name = "Titulo - Zona")]
		public string TituloEleitorZona { get; set; }
		[Display(Name = "Titulo - Seção")]
		public string TituloEleitorSecao { get; set; }
		[Display(Name = "Titulo - Municipio/Cidade")]
		public string TituloEleitorMunicipio { get; set; }
		[Display(Name = "Titulo - Uf")]
		public string TituloEleitorUf { get; set; }
		public string Nis { get; set; }
		[Display(Name = "Cartão Cidadão")]
		public string CartaoCidadao { get; set; }
		[Display(Name = "Sexo")]
		public int SexoId { get; set; }
		[EmailAddress(ErrorMessage = "Preencha um e-mail válido")]
		[Display(Name = "E-mail")]
		public string Email { get; set; }
		public string Telefone { get; set; }
		public string Celular { get; set; }
		[MaxLength(8)]
		[MinLength(8)]
		public string Cep { get; set; }
		[Display(Name = "Rua/Av.")]
		public string Logradouro { get; set; }
		public string Numero { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }
		[ScaffoldColumn(false)]
		public DateTime DataCadastro { get; set; }
		public bool Ativo { get; set; }
		[Display(Name = "Portador de necessidades especiais?")]
		public bool PNE { get; set; }
		[Display(Name = "Escolaridade")]
		public int EscolaridadeId { get; set; }
		[Display(Name = "Trabalha atualmente?")]
		public bool Desempregado { get; set; }

		public string Profissao { get; set; }
		[Display(Name = "Vinculo")]
		public int EquipamentoPublicoId { get; set; }
		public virtual EquipamentoPublicoViewModel EquipamentoPublico { get; set; }
		public virtual IEnumerable<DependenteViewModel> Dependentes { get; set; }
		public virtual IEnumerable<EscolaridadeViewModel> Escolaridade { get; set; }
		public virtual IEnumerable<SexoViewModel> Sexo { get; set; }
	}
}