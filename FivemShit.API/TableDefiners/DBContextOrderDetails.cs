using FivemShit.API.DataTables;
using Microsoft.EntityFrameworkCore;

namespace FivemShit.API.TableDefiners
{
    public class DBContextOrderDetails
    {
        public static ModelBuilder AddOrderDetail(ModelBuilder modelBuilder)
        {
            return modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.HasKey(e => new { e.OrderDetailsId });
                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsId");
                entity.Property(e => e.OrderId).HasColumnName("OrderId");
                entity.Property(e => e.MemberShipId).HasColumnName("MemberShipId");
                entity.Property(e => e.ScriptId).HasColumnName("ScriptId");

                entity.HasIndex(e => new { e.OrderDetailsId, e.IsActive }).IsUnique();
                entity.HasIndex(e => new { e.OrderDetailsId, e.OrderId, e.IsActive }).IsUnique();
                entity.HasIndex(e => new { e.OrderDetailsId, e.MemberShipId, e.IsActive }).IsUnique();
                entity.HasIndex(e => new { e.OrderDetailsId, e.ScriptId, e.IsActive }).IsUnique();

                entity.Property(e => e.ScriptQuantity).HasColumnName("ScriptQuantity");

                entity.Property(e => e.ScriptsTotalPrice)
                   .HasColumnType("decimal(18, 2)")
                   .HasColumnName("ScriptsTotalPrice");
                entity.Property(e => e.MemberShipPrice)
                   .HasColumnType("decimal(18, 2)")
                   .HasColumnName("MemberShipPrice");
                entity.Property(e => e.TotalPrice)
                   .HasColumnType("decimal(18, 2)")
                   .HasColumnName("TotalPrice");
                entity.Property(e => e.DiscountPrice)
                   .HasColumnType("decimal(18, 2)")
                   .HasColumnName("DiscountPrice");

                entity.Property(e => e.IsActive).HasColumnName("IsActive");
                entity.Property(e => e.CreatedAt).HasColumnType("datetime").HasColumnName("CreatedAt");

                entity.HasOne(e => e.Memberships).WithMany(e => e.OrderDetails)
                .HasForeignKey(e => new { e.MemberShipId })
                .HasConstraintName("FK_OrderDetail_Membership");

                entity.HasOne(e => e.Scripts).WithMany(e => e.OrderDetails)
                .HasForeignKey(e => new { e.ScriptId })
                .HasConstraintName("FK_OrderDetail_Scripts");

                entity.HasOne(e => e.Orders).WithMany(e => e.OrderDetails)
                .HasForeignKey(e => new { e.OrderId })
                .HasConstraintName("FK_OrderDetail_Order");
            });
        }
    }
}
