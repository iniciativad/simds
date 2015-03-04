using Simds.Application.Interfaces;
using Simds.Domain.Entities;
using Simds.Domain.Interfaces.Services;


namespace Simds.Application
{
	public class CartaoAppService :AppServiceBase<Cartao>, ICartaoAppService
	{
		private readonly ICartaoService _cartaoService;
		public CartaoAppService(ICartaoService  cartaoService)
			:base(cartaoService)
		{
			_cartaoService = cartaoService;
		}

		
	}
}
