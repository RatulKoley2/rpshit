using FivemShit.API.DataTables;
using Microsoft.EntityFrameworkCore;

namespace FivemShit.API.TableDefiners
{
    public class DBContextOrders
    {
        public static ModelBuilder AddOrder(ModelBuilder modelBuilder)
        {
            return modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.HasKey(e => new { e.OrderId });
                entity.Property(e => e.OrderId).HasColumnName("OrderId");
                entity.Property(e => e.UserId).HasColumnName("UserId");

                entity.HasIndex(e => new { e.OrderId, e.IsActive }).IsUnique();
                entity.HasIndex(e => new { e.OrderId, e.UserId, e.IsActive }).IsUnique();

                entity.Property(e => e.OrderNo).HasMaxLength(50).HasColumnName("OrderNo");
                entity.Property(e => e.OrderStatus).HasMaxLength(50).HasColumnName("OrderStatus");

                entity.Property(e => e.OrderTotal)
                   .HasColumnType("decimal(18, 2)")
                   .HasColumnName("OrderTotal");

                entity.Property(e => e.IsActive).HasColumnName("IsActive");
                entity.Property(e => e.CreatedAt).HasColumnType("datetime").HasColumnName("CreatedAt");

                entity.HasOne(e => e.Users).WithMany(e => e.Orders)
                .HasForeignKey(e => new { e.UserId })
                .HasConstraintName("FK_Order_Users");
            });
        }
    }
}
