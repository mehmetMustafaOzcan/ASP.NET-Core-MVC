using Microsoft.EntityFrameworkCore;

namespace MVCCategory_Product_exercise.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext()
        {

        }
        public CompanyContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddDummyData(modelBuilder);
        }
        private void AddDummyData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category() { CategoryId = 1, Name = "Phone", Description = "New tech phones" },
            new Category() { CategoryId = 2, Name = "Computer", Description = "Wonderful computers" },
            new Category() { CategoryId = 3, Name = "Television", Description = "TV's" }
            );

            modelBuilder.Entity<Product>().HasData(
          new Product { ProductId = 1, Name = "iPhone 13", Price = 9999, Instock = true, CategoryId = 1 },
    new Product { ProductId = 2, Name = "Samsung Galaxy S21", Price = 7999, Instock = true, CategoryId = 1 },
    new Product { ProductId = 3, Name = "Xiaomi Mi 11 Lite", Price = 3499, Instock = true, CategoryId = 1 },
    new Product { ProductId = 4, Name = "Macbook Pro", Price = 16999, Instock = true, CategoryId = 2 },
    new Product { ProductId = 5, Name = "HP Pavilion", Price = 7499, Instock = true, CategoryId = 2 },
    new Product { ProductId = 6, Name = "Asus ROG", Price = 13999, Instock = true, CategoryId = 2 },
    new Product { ProductId = 7, Name = "Samsung 55'' 4K Smart TV", Price = 6999, Instock = true, CategoryId = 3 },
    new Product { ProductId = 8, Name = "LG 65'' OLED TV", Price = 13999, Instock = true, CategoryId = 3 },
    new Product { ProductId = 9, Name = "Sony 75'' 4K HDR TV", Price = 21999, Instock = true, CategoryId = 3 }
            );
        }

    }
}
