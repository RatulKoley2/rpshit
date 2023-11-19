using FivemShit.API.DataTables;
using Microsoft.EntityFrameworkCore;

namespace FivemShit.API.TableDefiners
{
    public static class DBContextCarts
    {
        public static ModelBuilder AddCart(ModelBuilder modelBuilder)
        {
            return modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");

                entity.HasKey(e => new { e.CartId });
                entity.Property(e => e.CartId).HasColumnName("CartId");
                entity.Property(e => e.UserId).HasColumnName("UserId");
                entity.Property(e => e.MemberShipId).HasColumnName("MemberShipId");
                entity.Property(e => e.ScriptId).HasColumnName("ScriptId");

                entity.HasIndex(e => new { e.CartId, e.IsActive }).IsUnique();
                entity.HasIndex(e => new { e.CartId, e.UserId, e.IsActive }).IsUnique();
                entity.HasIndex(e => new { e.CartId, e.MemberShipId, e.IsActive }).IsUnique();
                entity.HasIndex(e => new { e.CartId, e.ScriptId, e.IsActive }).IsUnique();

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

                entity.HasOne(e => e.Memberships).WithMany(e => e.Carts)
                .HasForeignKey(e => new { e.MemberShipId })
                .HasConstraintName("FK_Carts_Membership");

                entity.HasOne(e => e.Scripts).WithMany(e => e.Carts)
                .HasForeignKey(e => new { e.ScriptId })
                .HasConstraintName("FK_Carts_Scripts");

                entity.HasOne(e => e.Users).WithMany(e => e.Carts)
                .HasForeignKey(e => new { e.UserId })
                .HasConstraintName("FK_Carts_Users");
            });
        }
    }
}
