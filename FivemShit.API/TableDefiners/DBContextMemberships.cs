using FivemShit.API.DataTables;
using Microsoft.EntityFrameworkCore;

namespace FivemShit.API.TableDefiners
{
    public class DBContextMemberships
    {
        public static ModelBuilder AddMembership(ModelBuilder modelBuilder)
        {
            return modelBuilder.Entity<Membership>(entity =>
            {
                entity.ToTable("Membership");

                entity.HasKey(e => new { e.MemberShipId });
                entity.Property(e => e.MemberShipId).HasColumnName("MemberShipId");

                entity.HasIndex(e => new { e.MemberShipId, e.IsActive }).IsUnique();

                entity.Property(e => e.MembershipName).HasMaxLength(100).HasColumnName("MembershipName");
                entity.Property(e => e.MembershipDescription).HasColumnName("MembershipDescription");
                entity.Property(e => e.Remarks).HasColumnName("Remarks");

                entity.Property(e => e.MemberShipPrice)
                   .HasColumnType("decimal(18, 2)")
                   .HasColumnName("MemberShipPrice");

                entity.Property(e => e.IsActive).HasColumnName("IsActive");
                entity.Property(e => e.CreatedAt).HasColumnType("datetime").HasColumnName("CreatedAt");
            });
        }
    }
}
