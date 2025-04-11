using Microsoft.EntityFrameworkCore;
using WebApi_Livros.Domain.Models;
namespace WebApi_Livros.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }  //DbSet<Category> is a collection of Category objects
        public DbSet<Product> Products { get; set; }  //DbSet<Product> is a collection of Product objects
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}// Fluent-Api, Models e mapeamentos, usando IsRequired e o método HasKey
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent-Api
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().ToTable("Categories"); // Map the Category entity to the Categories table
            modelBuilder.Entity<Category>().HasKey(c => c.Id); // Set the primary key for the Category entity
            modelBuilder.Entity<Category>().Property(c => c.Id).IsRequired().HasMaxLength(30); // Set the Name property as required
            modelBuilder.Entity<Category>().Property(c => c.Name).IsRequired().HasMaxLength(30); // Set the Name property as required
            modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId); // Set the relationship between Category and Product entities

            modelBuilder.Entity<Category>().HasData
                (
                new Category { Id = 1, Name = "Beverages" },
                new Category { Id = 2, Name = "Condiments" }
                );
            modelBuilder.Entity<Product>().ToTable("Products"); // Map the Product entity to the Products table 
            modelBuilder.Entity<Product>().HasKey(p => p.Id); // Set the primary key for the Product entity
            modelBuilder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd(); // Set the Name property as required
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50); // Set 
            modelBuilder.Entity<Product>().Property(p => p.QuantityPackage).IsRequired(); // Set the Description property as required
            modelBuilder.Entity<Product>().Property(p => p.UnitOfMeasurement).IsRequired(); // Set the Description property as required
        }

    }
}
