using System;
using System.Collections.Generic;

namespace Simds.Domain.Entities
{
	public class EquipamentoPublico
	{
		
		public int EquipamentoPublicoId { get; set; }
		
		public string RazaoSocial { get; set; }
		
		public string NomeFantasia { get; set; }
		
		public string Cnpj { get; set; }
		public string Cep { get; set; }
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
		
		public int EquipamentoPublicoTipoId { get; set; }
		public virtual EquipamentoPublicoTipo EquipamentoPublicoTipo { get; set; }

		public DateTime DataFundacao { get; set; }
		public int PrefeituraId { get; set; }
		public virtual Prefeitura Prefeitura { get; set; }
		public virtual IEnumerable<Pessoa> Pessoas { get; set; }
		public virtual IEnumerable<Dependente> Dependetes { get; set; }
		public virtual IEnumerable<Conjuge> Conjuges { get; set; }
	}
}