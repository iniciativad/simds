﻿using System;
using System.Collections.Generic;

namespace Simds.Domain.Entities
{
	public class Conjuge
	{
		public int ConjugeId { get; set; }
		public string Nome { get; set; }
		
		public DateTime DataNascimento { get; set; }
		public string Rg { get; set; }
		public string RgOrgaoEmissor { get; set; }
		public string RgOrgaoEmissorUf { get; set; }
		public DateTime? RgOrgaoEmissorDtEmissao { get; set; }
		public string Cpf { get; set; }
		public string TituloEleitor { get; set; }
		public string TituloEleitorZona { get; set; }
		public string TituloEleitorSecao { get; set; }
		public string TituloEleitorMunicipio { get; set; }
		public string TituloEleitorUf { get; set; }
		public string Nis { get; set; }
		public string CartaoCidadao { get; set; }
		public int SexoId { get; set; }
		public string Email { get; set; }
		public string Telefone { get; set; }
		public string Celular { get; set; }
		public string Cep { get; set; }
		public string Logradouro { get; set; }
		public string Numero { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public DateTime DataCadastro { get; set; }
		public bool Ativo { get; set; }
		public bool PNE { get; set; }
		public int EscolaridadeId { get; set; }
		public bool Desempregado { get; set; }		
		public string Profissao { get; set; }
		public int EquipamentoPublicoId { get; set; }
		public virtual EquipamentoPublico EquipamentoPublico { get; set; }
		public int PessoaId { get; set; }
		public virtual Pessoa Pessoa { get; set; }

		public virtual IEnumerable<Escolaridade> Escolaridade { get; set; }
		public virtual IEnumerable<Sexo> Sexo { get; set; }

		public bool ClienteEspecial(Pessoa pessoa)
		{
			return pessoa.Ativo && DateTime.Now.Year - pessoa.DataCadastro.Year >= 5;
		}

		public bool PortadoNecessicadeEspecial(Pessoa pessoa)
		{
			return pessoa.PNE = true;
		}

		public bool PessoaIdosa(Conjuge conjuge)
		{
			return DateTime.Now.Year - conjuge.DataNascimento.Year >= 60;
		}
	}
}
