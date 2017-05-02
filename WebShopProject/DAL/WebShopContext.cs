using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebShopProject.Models;

namespace WebShopProject.DAL
{
    public class WebShopContext : DbContext
    {
        public WebShopContext() : base("WebShopProject")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CustomerLogInfo> CustomerLogInfos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}