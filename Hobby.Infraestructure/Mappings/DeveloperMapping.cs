using Games.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hobby.Infraestructure.Mappings;

public class DeveloperMapping : IEntityTypeConfiguration<Developer>
{
    public void Configure(EntityTypeBuilder<Developer> developerBuilder)
    {
        developerBuilder.ToTable("Tb_Developer");
        developerBuilder.HasKey(e => e.Id).HasName("PK_Developer");
        developerBuilder.Property(e => e.Id).HasColumnName("id_Developer").ValueGeneratedOnAdd();
        developerBuilder.Property(e => e.IsActive).HasColumnName("is_Active").IsRequired();
        developerBuilder.Property(e => e.CreatedDate).HasColumnName("dat_Created").IsRequired().HasConversion(
            v => v.ToUniversalTime(), // Convert to UTC when saving
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
        );
        developerBuilder.Property(e => e.UpdatedDate).HasColumnName("dat_Updated").IsRequired().HasConversion(
            v => v.ToUniversalTime(), // Convert to UTC when saving
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
        );
        developerBuilder.Property(e => e.Name).HasColumnName("nm_Developer").IsRequired();
    }
}