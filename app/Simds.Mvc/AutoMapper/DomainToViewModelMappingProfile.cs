using AutoMapper;
using Simds.Domain.Entities;
using Simds.Mvc.ViewModels;

namespace Simds.Mvc.AutoMapper
{
	public class DomainToViewModelMappingProfile : Profile
	{
		public override string ProfileName
		{
			get { return "ViewModelToDomainMappingProfile"; }
		}

		protected override void Configure()
		{
			Mapper.CreateMap<CartaoViewModel, Cartao>();
			Mapper.CreateMap<ConjugeViewModel, Conjuge>();
			Mapper.CreateMap<DependenteViewModel, Dependente>();
			Mapper.CreateMap <EquipamentoPublicoViewModel, EquipamentoPublico>();
			Mapper.CreateMap<EquipamentoPublicoTipoViewModel, EquipamentoPublicoTipo>();
			Mapper.CreateMap <EscolaridadeViewModel, Escolaridade>();
			Mapper.CreateMap <PessoaViewModel, Pessoa>();
			Mapper.CreateMap <PrefeituraViewModel, Prefeitura> ();
			Mapper.CreateMap <SexoViewModel, Sexo>();
		}
	}
}