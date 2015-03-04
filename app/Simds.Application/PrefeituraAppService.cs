using Simds.Application.Interfaces;
using Simds.Domain.Entities;
using Simds.Domain.Interfaces.Services;

namespace Simds.Application
{
	public class PrefeituraAppService : AppServiceBase<Prefeitura>, IPrefeituraAppService
	{
		private readonly IPrefeituraService _prefeituraService;
		public PrefeituraAppService(IPrefeituraService prefeituraService)
			: base(prefeituraService)
		{
			_prefeituraService = prefeituraService;
		}
	}
}
