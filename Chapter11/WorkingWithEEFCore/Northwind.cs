using Microsoft.EntityFrameworkCore;

namespace WorkingWithEEFCore
{
    // This class manages the connection to the database
    public class Northwind : DbContext
    {
        // This properties map to the tables in the database
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Northwind.db");
            optionsBuilder.UseSqlite($"Filename={path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Example of using Fluent Api instead of attributes
            // to limit the Length of a category name to 15.
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()  // Not Null
                .HasMaxLength(15);

            // Added to "fix" the lack of decimal support in SQLite.
            modelBuilder.Entity<Product>()
                .Property(product => product.Cost)
                .HasConversion<double>();  // conversion because EF3 deimal type mnot supported for sorting.
        }

    }
}