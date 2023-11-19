using FivemShit.API.DataTables;
using Microsoft.EntityFrameworkCore;

namespace FivemShit.API.TableDefiners
{
    public static class DBContextScripts
    {
        public static ModelBuilder AddScripts(ModelBuilder modelBuilder)
        {
            return modelBuilder.Entity<Script>(entity =>
            {
                entity.ToTable("Script");

                entity.HasKey(e => new { e.ScriptId });
                entity.Property(e => e.ScriptId).HasColumnName("ScriptId");
                entity.HasIndex(e => new { e.ScriptId, e.IsActive }).IsUnique();

                entity.Property(e => e.ScriptName).HasMaxLength(100).HasColumnName("ScriptName");
                entity.Property(e => e.ScriptDescription).HasColumnName("ScriptDescription");
                entity.Property(e => e.Remarks).HasColumnName("Remarks");

                entity.Property(e => e.ScriptPrice)
                   .HasColumnType("decimal(18, 2)")
                   .HasColumnName("ScriptPrice");

                entity.Property(e => e.IsActive).HasColumnName("IsActive");
                entity.Property(e => e.CreatedAt).HasColumnType("datetime").HasColumnName("CreatedAt");
                entity.Property(e => e.ExpiryDate).HasColumnType("datetime").HasColumnName("ExpiryDate");

            });
        }
    }
}
