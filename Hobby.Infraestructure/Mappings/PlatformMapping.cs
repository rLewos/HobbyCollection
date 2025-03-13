using Games.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hobby.Infraestructure.Mappings;

public class PlatformMapping : IEntityTypeConfiguration<Platform>
{
    public void Configure(EntityTypeBuilder<Platform> builder)
    {
        builder.ToTable("Tb_Plataform");
        builder.HasKey(e => e.Id).HasName("PK_Plataform");
        builder.Property(e => e.Id).HasColumnName("id_Plataform").ValueGeneratedOnAdd();
        builder.Property(e => e.IsActive).HasColumnName("is_Active").IsRequired();
        builder.Property(e => e.CreatedDate).HasColumnName("dat_Created").IsRequired().HasConversion(
            v => v.ToUniversalTime(), // Convert to UTC when saving
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
        );
        builder.Property(e => e.UpdatedDate).HasColumnName("dat_Updated").IsRequired().HasConversion(
            v => v.ToUniversalTime(), // Convert to UTC when saving
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
        ); ;
        builder.Property(e => e.Name).HasColumnName("nm_Plataform").IsRequired();
    }
}