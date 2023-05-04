using eshop.Entities;
using Microsoft.EntityFrameworkCore;

namespace eshop.Data.Data
{
    public class EshopDbContext : DbContext
    {
        public EshopDbContext(DbContextOptions<EshopDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=HalkBankGroup7;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired()
                                                                .HasMaxLength(200);


            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(p => p.CategoryId)
                                          .OnDelete(DeleteBehavior.ClientNoAction);



            modelBuilder.Entity<Category>().HasData(
                  new Category { Id = 1, Name = "Bilgisayar" },
                  new Category { Id = 2, Name = "Giyim" },
                  new Category { Id = 3, Name = "Mobilya" }
            );

            modelBuilder.Entity<Product>().HasData(

                new Product { Id = 1, CategoryId = 1, Description = "Lenovo Laptop", DiscountRate = 0.15, ImageUrl = "https://cdn.dsmcdn.com/ty515/product/media/images/20220820/15/163144774/548362614/1/1_org.jpg", Name = "Lenovo X65", Price = 150000 },
                 new Product { Id = 2, CategoryId = 2, Description = "Tek renk tişörtler", DiscountRate = 0.25, ImageUrl = "https://cdn.dsmcdn.com/ty515/product/media/images/20220820/15/163144774/548362614/1/1_org.jpg", Name = "Basic Tişört", Price = 250 },
                  new Product { Id = 3, CategoryId = 3, Description = "Orta Sehpa", DiscountRate = 0.10, ImageUrl = "https://cdn.dsmcdn.com/ty515/product/media/images/20220820/15/163144774/548362614/1/1_org.jpg", Name = "Vivense orta sehpa", Price = 300 });




        }


    }
}
