using FivemShit.API.DataTables;
using Microsoft.EntityFrameworkCore;

namespace FivemShit.API.TableDefiners
{
    public static class DBContextRoles
    {
        public static ModelBuilder AddRole(ModelBuilder modelBuilder)
        {
            return modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.HasKey(e => new { e.RoleId });
                entity.Property(e => e.RoleId).HasColumnName("RoleId");
                entity.HasIndex(e => new { e.RoleId, e.IsActive }).IsUnique();

                entity.Property(e => e.RoleName).HasMaxLength(50).HasColumnName("RoleName");

                entity.Property(e => e.IsActive).HasColumnName("IsActive");
                entity.Property(e => e.CreatedAt).HasColumnType("datetime").HasColumnName("CreatedAt");

            });
        }
    }
}
