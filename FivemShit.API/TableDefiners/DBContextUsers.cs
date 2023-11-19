using FivemShit.API.DataTables;
using Microsoft.EntityFrameworkCore;

namespace FivemShit.API.TableDefiners
{
    public static class DBContextUsers
    {
        public static ModelBuilder AddUser(ModelBuilder modelBuilder)
        {
            return modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasKey(e => new { e.UserId });
                entity.Property(e => e.UserId).HasColumnName("UserId");
                entity.Property(e => e.RoleId).HasColumnName("RoleId");
                entity.Property(e => e.MemberId).HasColumnName("MemberId");

                entity.HasIndex(e => new { e.UserId, e.IsActive }).IsUnique();
                entity.HasIndex(e => new { e.UserId, e.RoleId, e.IsActive }).IsUnique();
                entity.HasIndex(e => new { e.UserId, e.MemberId, e.IsActive }).IsUnique();

                entity.Property(e => e.FirstName).HasMaxLength(100).HasColumnName("FirstName");
                entity.Property(e => e.LastName).HasMaxLength(100).HasColumnName("LastName");
                entity.Property(e => e.Email).HasMaxLength(100).HasColumnName("Email");
                entity.Property(e => e.Password).HasColumnName("Password");
                entity.Property(e => e.DiscordUserName).HasMaxLength(100).HasColumnName("DiscordUserName");
                entity.Property(e => e.FivemUserName).HasMaxLength(100).HasColumnName("FivemUserName");
                entity.Property(e => e.ScriptsPurchased).HasColumnName("ScriptsPurchased");

                entity.Property(e => e.IsActive).HasColumnName("IsActive");
                entity.Property(e => e.IsBanned).HasColumnName("IsBanned");
                entity.Property(e => e.IsWhiteListed).HasColumnName("IsWhiteListed");
                entity.Property(e => e.IsMember).HasColumnName("IsMember");
                entity.Property(e => e.CreatedAt).HasColumnType("datetime").HasColumnName("CreatedAt");

                entity.HasOne(e => e.Roles).WithMany(e => e.Users)
                .HasForeignKey(e => new { e.RoleId })
                .HasConstraintName("FK_Users_Roles");

                entity.HasOne(e => e.MemberShips).WithMany(e => e.Users)
               .HasForeignKey(e => new { e.MemberId })
               .HasConstraintName("FK_Users_Memberships");
            });
        }
    }
}
