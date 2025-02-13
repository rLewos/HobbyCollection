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

			EntityTypeBuilder<Platform> etbPlataform = modelBuilder.Entity<Platform>();
			etbPlataform.ToTable("Tb_Plataform");
			etbPlataform.HasKey(e => e.Id).HasName("PK_Plataform");
			etbPlataform.Property(e => e.Id).HasColumnName("id_Plataform").ValueGeneratedOnAdd();
			etbPlataform.Property(e => e.IsActive).HasColumnName("is_Active").IsRequired();
			etbPlataform.Property(e => e.CreatedDate).HasColumnName("dat_Created").IsRequired().HasConversion(
				v => v.ToUniversalTime(), // Convert to UTC when saving
				v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
			);
			etbPlataform.Property(e => e.UpdatedDate).HasColumnName("dat_Updated").IsRequired().HasConversion(
				v => v.ToUniversalTime(), // Convert to UTC when saving
				v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
			); ;
			etbPlataform.Property(e => e.Name).HasColumnName("nm_Plataform").IsRequired();

			EntityTypeBuilder<Game> eGame = modelBuilder.Entity<Game>();
			eGame.ToTable("Tb_Game");
			eGame.HasKey(e => e.Id).HasName("PK_Game");
			eGame.Property(e => e.Id).HasColumnName("id_Game").ValueGeneratedOnAdd();
			eGame.Property(e => e.CreatedDate).HasColumnName("dat_Created").IsRequired().HasConversion(v => v.ToUniversalTime(), v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
			eGame.Property(e => e.UpdatedDate).HasColumnName("dat_Updated").IsRequired().HasConversion(v => v.ToUniversalTime(), v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
			eGame.Property(e => e.IsActive).HasColumnName("is_Active").IsRequired();
			eGame.Property(e => e.Name).HasColumnName("nm_Game").IsRequired();
			eGame.Property(e => e.ReleaseDate).HasColumnName("dat_Release");

			eGame.HasMany(e => e.DeveloperList)
							.WithMany(t => t.GameList)
							.UsingEntity("Tb_GameDeveloper");

			eGame.HasMany(e => e.PublisherList)
				.WithMany(g => g.GameList)
				.UsingEntity("Tb_GamePublisher");

			eGame.HasMany(e => e.PlataformList)
				.WithMany(g => g.GameList)
				.UsingEntity("Tb_GamePlataform");


			EntityTypeBuilder<User> etbUser = modelBuilder.Entity<User>();
			etbUser.ToTable("Tb_User");
			etbUser.HasKey(e => e.Id).HasName("PK_User");
			etbUser.Property(e => e.Id).HasColumnName("id_User").ValueGeneratedOnAdd();
			etbUser.Property(e => e.IsActive).HasColumnName("is_Active").IsRequired();
			etbUser.Property(e => e.CreatedDate).HasColumnName("dat_Created").IsRequired().HasConversion(v => v.ToUniversalTime(), v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
			etbUser.Property(e => e.UpdatedDate).HasColumnName("dat_Updated").IsRequired().HasConversion(
				v => v.ToUniversalTime(), // Convert to UTC when saving
				v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
			);
			etbUser.Property(e => e.Name).HasColumnName("nm_User").IsRequired();
			etbUser.Property(e => e.Nickname).HasColumnName("nm_Nickname").IsRequired();
			etbUser.Property(e => e.Password).HasColumnName("ds_Password").IsRequired();
			
			etbUser.HasMany(e => e.GameList).WithMany(e => e.UserList)
				.UsingEntity<UserGame>(
					"Tb_UserGame",
					 x => x.HasOne(e => e.Game).WithMany(e => e.UserGameList),
					 x => x.HasOne(e => e.User).WithMany(e => e.UserGameList),

					 x => x.Property(e => e.HasBeaten).HasColumnName("has_Beaten")
				);
			
			
			

			EntityTypeBuilder<Roles> etbRole = modelBuilder.Entity<Roles>();
			etbRole.ToTable("Tb_Role");
			etbRole.HasKey(e => e.Id).HasName("PK_Roles");
			etbRole.Property(e => e.Id).HasColumnName("id_Roles").ValueGeneratedOnAdd();
			etbRole.Property(e => e.IsActive).HasColumnName("is_Active").IsRequired();
			etbRole.Property(e => e.CreatedDate).HasColumnName("dt_Created").IsRequired().HasConversion(
				v => v.ToUniversalTime(), 
				v => DateTime.SpecifyKind(v, DateTimeKind.Utc)
			);
			etbRole.Property(e => e.UpdatedDate).HasColumnName("dt_Updated").IsRequired().HasConversion(
				v => v.ToUniversalTime(), // Convert to UTC when saving
				v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
			);
			etbRole.Property(e => e.Name).HasColumnName("nm_User").IsRequired();

			base.OnModelCreating(modelBuilder);
		}

		private void SetMappings(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new DeveloperMapping());
			modelBuilder.ApplyConfiguration(new PublisherMapping());
		}
	}
}
