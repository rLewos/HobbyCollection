using Games.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hobby.Infraestructure.Mappings;

public class UserGameMapping : IEntityTypeConfiguration<UserGame>
{
    public void Configure(EntityTypeBuilder<UserGame> builder)
    {
        builder.ToTable("Tb_UserGame");
        builder.HasKey(ug => new { ug.UserId, ug.GameId });
        
        //Properties
        builder.Property(ug => ug.UserId).IsRequired().HasColumnName("cd_user_id");
        builder.Property(ug => ug.GameId).IsRequired().HasColumnName("cd_game_id");
        builder.Property(ug => ug.HasBeaten).IsRequired().HasDefaultValue(false).HasColumnName("has_beaten");
        builder.Property(e => e.IsActive).HasColumnName("is_active").IsRequired();
        builder.Property(e => e.CreatedDate).HasColumnName("dat_created").IsRequired().HasConversion(v => v.ToUniversalTime(), v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
        builder.Property(e => e.UpdatedDate).HasColumnName("dat_updated").IsRequired().HasConversion(
            v => v.ToUniversalTime(), // Convert to UTC when saving
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Specify as UTC when reading
        );
        
        
        // Relationships
        builder.HasOne(ug => ug.User)
            .WithMany(u => u.UserGameList)
            .HasForeignKey(ug => ug.UserId);

        builder.HasOne(ug => ug.Game)
            .WithMany(g => g.UserGameList)
            .HasForeignKey(ug => ug.GameId);
    }
}