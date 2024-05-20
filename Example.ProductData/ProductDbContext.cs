using Example.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.ProductData
{
    public class ProductDbContext: DbContext 
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
                options.UseSqlite("DataSource=products.db;Cache=Shared");
    }
}
