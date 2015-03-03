using Simds.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Simds.Infra.Data.EntityConfig
{
	public class PrefeituraConfig : EntityTypeConfiguration<Prefeitura>
	{
		public PrefeituraConfig()
		{
			HasKey(p => p.PrefeituraId);

			Property(p => p.RazaoSocial).
			IsRequired();

			Property(p => p.NomeFantasia).
				IsRequired();

			Property(p => p.Email)
				.HasMaxLength(160);

			Property(p => p.Cnpj)
				.HasMaxLength(14)
				.IsRequired()
				.HasColumnType("Char");

			Property(p => p.Cep)
				.HasMaxLength(8)
				.HasColumnType("Char");

			Property(p => p.Numero)
				.HasMaxLength(4)
				.HasColumnType("Char");

			Property(p => p.Uf)
				.HasMaxLength(2)
				.HasColumnType("Char");
		}
	}
}
