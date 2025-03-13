using Games.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hobby.Infraestructure.Mappings;

public class PublisherMapping : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.ToTable("Tb_Publisher");
        builder.HasKey(e => e.Id).HasName("PK_Publisher");
        builder.Property(e => e.Id).HasColumnName("id_Publisher").ValueGeneratedOnAdd();
        builder.Property(e => e.IsActive).HasColumnName("is_Active").IsRequired();
        builder.Property(e => e.CreatedDate).HasColumnName("dat_Created").IsRequired().HasConversion(
            v => v.ToUniversalTime(), // Convert to UTC when saving
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
        );
        builder.Property(e => e.UpdatedDate).HasColumnName("dat_Updated").IsRequired().HasConversion(
            v => v.ToUniversalTime(), // Convert to UTC when saving
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
        );
        builder.Property(e => e.Name).HasColumnName("nm_Publisher").IsRequired();
    }
}