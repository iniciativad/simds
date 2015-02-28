using Simds.Domain.Entities;
using Simds.Domain.Interfaces;
using Simds.Domain.Interfaces.Services;

namespace Simds.Domain.Services
{
	public class CartaoService : ServiceBase<Cartao>, ICartaoService
	{
		private readonly ICartaoRepository _cartaoRepository;
		public CartaoService(ICartaoRepository cartaoRepository)
			:base(cartaoRepository)
		{
			_cartaoRepository = cartaoRepository;
		}
	}
}
