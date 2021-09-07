using Microsoft.EntityFrameworkCore;
using DeliverySystem.DAL.Models;

namespace DeliverySystem.DAL.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<DeliveryProduct> DeliveryProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=.; Integrated Security=True; Initial Catalog = DeliverySystem");
        }
    }
}
