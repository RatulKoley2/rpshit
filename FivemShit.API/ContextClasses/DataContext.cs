using FivemShit.API.DataTables;
using FivemShit.API.TableDefiners;
using Microsoft.EntityFrameworkCore;

namespace FivemShit.API.ContextClasses
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Script> Scripts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            DBContextMemberships.AddMembership(modelbuilder);
            DBContextOrderDetails.AddOrderDetail(modelbuilder);
            DBContextOrders.AddOrder(modelbuilder);
            DBContextRoles.AddRole(modelbuilder);
            DBContextScripts.AddScripts(modelbuilder);
            DBContextUsers.AddUser(modelbuilder);
            DBContextCarts.AddCart(modelbuilder);
        }
    }
}
