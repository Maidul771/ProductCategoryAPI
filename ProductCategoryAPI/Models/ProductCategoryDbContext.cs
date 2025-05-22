namespace ProductCategoryAPI.Models
{
    using Microsoft.EntityFrameworkCore;
    using ProductCategoryAPI.Models;

    public class ProductCategoryDbContext : DbContext
    {
        public ProductCategoryDbContext(DbContextOptions<ProductCategoryDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}
