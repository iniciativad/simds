using AutoMapper;


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
			Mapper.CreateMap<ClienteViewModel, Cliente>();
			Mapper.CreateMap<ProdutoViewModel, Produto>();
		}
	}
}