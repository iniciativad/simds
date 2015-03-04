using AutoMapper;
using Simds.Domain.Entities;
using Simds.Mvc.ViewModels;



namespace Simds.Mvc.AutoMapper
{
	public class ViewModelToDomainMappingProfile :Profile
	{
		public override string ProfileName
		{
			get { return "DomainToViewModelMappingProfile"; }
		}

		protected override void Configure()
		{
			Mapper.CreateMap<Cartao, CartaoViewModel>();
			Mapper.CreateMap<Conjuge, ConjugeViewModel>();
			Mapper.CreateMap<Dependente, DependenteViewModel>();
			Mapper.CreateMap<EquipamentoPublico, EquipamentoPublicoViewModel>();
			Mapper.CreateMap<EquipamentoPublicoTipo, EquipamentoPublicoTipoViewModel>();
			Mapper.CreateMap<Escolaridade, Escolaridade>();
			Mapper.CreateMap<Pessoa, PessoaViewModel>();
			Mapper.CreateMap<Prefeitura, PrefeituraViewModel>();
			Mapper.CreateMap<Sexo, SexoViewModel>();
		}
	}
}