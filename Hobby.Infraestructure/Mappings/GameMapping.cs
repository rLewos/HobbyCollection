using Games.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hobby.Infraestructure.Mappings;

public class GameMapping : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.ToTable("Tb_Game");
        builder.HasKey(e => e.Id).HasName("PK_Game");
        builder.Property(e => e.Id).HasColumnName("id_Game").ValueGeneratedOnAdd();
        builder.Property(e => e.CreatedDate).HasColumnName("dat_Created").IsRequired().HasConversion(v => v.ToUniversalTime(), v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
        builder.Property(e => e.UpdatedDate).HasColumnName("dat_Updated").IsRequired().HasConversion(v => v.ToUniversalTime(), v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
        builder.Property(e => e.IsActive).HasColumnName("is_Active").IsRequired();
        builder.Property(e => e.Name).HasColumnName("nm_Game").IsRequired();
        builder.Property(e => e.ReleaseDate).HasColumnName("dat_Release");

        builder.HasMany(e => e.DeveloperList)
            .WithMany(t => t.GameList)
            .UsingEntity("Tb_GameDeveloper");

        builder.HasMany(e => e.PublisherList)
            .WithMany(g => g.GameList)
            .UsingEntity("Tb_GamePublisher");

        builder.HasMany(e => e.PlataformList)
            .WithMany(g => g.GameList)
            .UsingEntity("Tb_GamePlataform");
    }
}