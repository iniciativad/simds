using Simds.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Simds.Infra.Data.EntityConfig
{
	public	class DependenteConfig :EntityTypeConfiguration<Dependente>
	{
		public DependenteConfig()
		{
			HasKey(p => p.DependenteId);

			Property(p => p.Nome).
				IsRequired();

			Property(p => p.Email)
				.HasMaxLength(160);

			Property(p => p.Cpf)
				.HasMaxLength(11)
				.IsRequired()
				.HasColumnType("Char");

			Property(p => p.Cep)
				.HasMaxLength(8)
				.HasColumnType("Char");

			Property(p => p.Numero)
				.HasMaxLength(4)
				.HasColumnType("Char");

			Property(p => p.Estado)
				.HasMaxLength(2)
				.HasColumnType("Char");
		}
	}
}
