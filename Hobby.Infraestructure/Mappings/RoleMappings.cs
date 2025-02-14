using Games.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hobby.Infraestructure.Mappings;

public class RoleMappings : IEntityTypeConfiguration<Roles>
{
    public void Configure(EntityTypeBuilder<Roles> builder)
    {
        builder.ToTable("Tb_Role");
        builder.HasKey(e => e.Id).HasName("PK_Roles");
        builder.Property(e => e.Id).HasColumnName("id_Roles").ValueGeneratedOnAdd();
        builder.Property(e => e.IsActive).HasColumnName("is_Active").IsRequired();
        builder.Property(e => e.CreatedDate).HasColumnName("dt_Created").IsRequired().HasConversion(
            v => v.ToUniversalTime(), 
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc)
        );
        builder.Property(e => e.UpdatedDate).HasColumnName("dt_Updated").IsRequired().HasConversion(
            v => v.ToUniversalTime(), // Convert to UTC when saving
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
        );
        builder.Property(e => e.Name).HasColumnName("nm_User").IsRequired();
    }
}