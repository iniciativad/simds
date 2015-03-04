using AutoMapper;


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
			Mapper.CreateMap<Cliente, ClienteViewModel>();
			Mapper.CreateMap<Produto, ProdutoViewModel>();
		}
	}
}