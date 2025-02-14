using Azure;
using Games.Model;
using Hobby.Infraestructure.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Games.Infraestructure
{
	public class HobbyContext : DbContext
	{
		public DbSet<Game> Games { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Developer> Developers { get; set; }
		public DbSet<Publisher> Publishers { get; set; }
		public DbSet<Platform> Plataforms { get; set; }
		public DbSet<Roles> Roles { get; set; }

		public HobbyContext(DbContextOptions<HobbyContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			this.SetMappings(modelBuilder);

			base.OnModelCreating(modelBuilder);
		}

		private void SetMappings(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new DeveloperMapping());
			modelBuilder.ApplyConfiguration(new PublisherMapping());
			modelBuilder.ApplyConfiguration(new PlatformMapping());
			modelBuilder.ApplyConfiguration(new PublisherMapping());
			modelBuilder.ApplyConfiguration(new UserMapping());
			modelBuilder.ApplyConfiguration(new RoleMappings());
		}
	}
}
