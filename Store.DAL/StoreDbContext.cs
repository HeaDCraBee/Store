using Microsoft.EntityFrameworkCore;
using Store.Domain;

namespace Store.DAL
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Suppliers> Suppliers { get; set; }

        public DbSet<ProductsToSuppliers> ProductsToSuppliers { get; set; }

        public DbSet<ServicesToSuppliers> ServicesToSuppliers { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Services> Services { get; set; }

        public DbSet<ProductTypes> ProductTypes { get; set; }

        public DbSet<ServiceTypes> ServiceTypes { get; set; }
       
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductTypes>().HasData(
                new ProductTypes[]
                {
                    new ProductTypes() { Id = 1, Name = "CPU"},
                    new ProductTypes() { Id = 2, Name = "GPU"},
                    new ProductTypes() { Id = 3, Name = "MotherBoard"}
                });

            modelBuilder.Entity<ServiceTypes>().HasData(
                new ServiceTypes[]
                {
                    new ServiceTypes() { Id = 1, Name = "Selection of components"},
                    new ServiceTypes() { Id = 2, Name = "Computer assembly"}
                });
        }
    }
}
