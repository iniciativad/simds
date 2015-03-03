using Simds.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Simds.Infra.Datab.EntityConfig
{
	public class CartaoConfig : EntityTypeConfiguration<Cartao>
	{
		public CartaoConfig()
		{
			HasKey(p => p.CartaoId);

			Property(c => c.PessoaId)
				.IsRequired();
		}
	}
}
