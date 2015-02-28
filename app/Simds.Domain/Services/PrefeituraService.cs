using Simds.Domain.Entities;
using Simds.Domain.Interfaces;
using Simds.Domain.Interfaces.Services;

namespace Simds.Domain.Services
{
	public class PrefeituraService :ServiceBase<Prefeitura>,IPrefeituraService
	{
		private readonly IPrefeituraRepository _prefeituraRepository;
		public PrefeituraService(IPrefeituraRepository prefeituraRepository)
			:base(prefeituraRepository)
		{
			_prefeituraRepository = prefeituraRepository;
		}
	}
}
