using Games.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hobby.Infraestructure.Mappings;

public class UserMapping : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder) 
    {
        builder.ToTable("Tb_User");
        builder.HasKey(e => e.Id).HasName("PK_User");
        builder.Property(e => e.Id).HasColumnName("id_User").ValueGeneratedOnAdd();
        builder.Property(e => e.IsActive).HasColumnName("is_Active").IsRequired();
        builder.Property(e => e.CreatedDate).HasColumnName("dat_Created").IsRequired().HasConversion(v => v.ToUniversalTime(), v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
        builder.Property(e => e.UpdatedDate).HasColumnName("dat_Updated").IsRequired().HasConversion(
            v => v.ToUniversalTime(), // Convert to UTC when saving
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
        );
        builder.Property(e => e.Name).HasColumnName("nm_User").IsRequired();
        builder.Property(e => e.Nickname).HasColumnName("nm_Nickname").IsRequired();
        builder.Property(e => e.Password).HasColumnName("ds_Password").IsRequired();
        
        builder.Property(x => x.RoleId).HasColumnName("id_roles").HasDefaultValue(null);
        builder.HasOne<Roles>(x => x.Role).WithMany().HasForeignKey(x => x.RoleId).HasPrincipalKey(x => x.Id).IsRequired(false);
    }
}