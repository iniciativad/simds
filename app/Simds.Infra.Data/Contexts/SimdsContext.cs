using Simds.Domain.Entities;
using Simds.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Simds.Infra.Data.Contexts
{
	public class SimdsContext : DbContext
	{
		public SimdsContext()
			:base("Simds")
		{

		}

		public DbSet<Cartao> Cartao { get; set; }
		public DbSet<Conjuge> Conjuge { get; set; }
		public DbSet<Dependente> Dependente { get; set; }
		public DbSet<EquipamentoPublico> EquipamentoPublico { get; set; }
		public DbSet<Pessoa> Pessoa { get; set; }
		public DbSet<Prefeitura> Prefeitura { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			modelBuilder.Properties()
				.Where(p => p.Name == p.ReflectedType.Name + "Id")
				.Configure(p => p.IsKey());

			modelBuilder.Properties<string>()
				.Configure(p => p.HasColumnType("varchar"));

			modelBuilder.Properties<string>()
				.Configure(p => p.HasMaxLength(75));

			modelBuilder.Configurations.Add(new CartaoConfig());
			modelBuilder.Configurations.Add(new ConjugeConfig());
			modelBuilder.Configurations.Add(new DependenteConfig());
			modelBuilder.Configurations.Add(new EquipamentoPublicoConfig());
			modelBuilder.Configurations.Add(new PessoaConfig());
			modelBuilder.Configurations.Add(new PrefeituraConfig());

		}

		public override int SaveChanges()
		{
			foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
			{
				if (entry.State == EntityState.Added)
				{
					entry.Property("DataCadastro").CurrentValue = DateTime.Now;
				}
				if (entry.State == EntityState.Modified)
				{
					entry.Property("DataCadastro").IsModified = false;
				}
			}
			return base.SaveChanges();
		}

	}
}
