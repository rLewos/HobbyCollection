using Azure;
using Games.Model;
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
		public DbSet<Plataform> Plataforms { get; set; }

		public HobbyContext(DbContextOptions<HobbyContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			EntityTypeBuilder<Developer> etbDeveloper = modelBuilder.Entity<Developer>();
			etbDeveloper.ToTable("Tb_Developer");
			etbDeveloper.HasKey(e => e.Id).HasName("PK_Developer");
			etbDeveloper.Property(e => e.Id).HasColumnName("id_Developer").ValueGeneratedOnAdd();
			etbDeveloper.Property(e => e.IsActive).HasColumnName("is_Active").IsRequired();
			etbDeveloper.Property(e => e.CreatedDate).HasColumnName("dat_Created").IsRequired();
			etbDeveloper.Property(e => e.UpdatedDate).HasColumnName("dat_Updated").IsRequired();
			etbDeveloper.Property(e => e.Name).HasColumnName("nm_Developer").IsRequired();

			EntityTypeBuilder<Publisher> etbPublisher = modelBuilder.Entity<Publisher>();
			etbPublisher.ToTable("Tb_Publisher");
			etbPublisher.HasKey(e => e.Id).HasName("PK_Publisher");
			etbPublisher.Property(e => e.Id).HasColumnName("id_Publisher").ValueGeneratedOnAdd();
			etbPublisher.Property(e => e.IsActive).HasColumnName("is_Active").IsRequired();
			etbPublisher.Property(e => e.CreatedDate).HasColumnName("dat_Created").IsRequired();
			etbPublisher.Property(e => e.UpdatedDate).HasColumnName("dat_Updated").IsRequired();
			etbPublisher.Property(e => e.Name).HasColumnName("nm_Publisher").IsRequired();

			EntityTypeBuilder<Plataform> etbPlataform = modelBuilder.Entity<Plataform>();
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
			eGame.Property(e => e.CreatedDate).HasColumnName("dat_Created").IsRequired();
			eGame.Property(e => e.UpdatedDate).HasColumnName("dat_Updated").IsRequired();
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
			etbUser.Property(e => e.CreatedDate).HasColumnName("dat_Created").IsRequired();
			etbUser.Property(e => e.UpdatedDate).HasColumnName("dat_Updated").IsRequired();
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

			base.OnModelCreating(modelBuilder);
		}
	}
}
