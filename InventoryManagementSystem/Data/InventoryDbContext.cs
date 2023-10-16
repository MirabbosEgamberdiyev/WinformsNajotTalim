using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InventoryManagementSystem.Data;

public class InventoryDbContext : DbContext
{
    public InventoryDbContext()
    {
        Database.EnsureCreated();
    }

    public DbSet<Admin> Admins { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<IncomeProduct> IncomeProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB; Database=InventoryDB;");

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //   => optionsBuilder.UseSqlite($"Data Source = {Path.Combine(Assembly.GetExecutingAssembly().Location, "InventoryDB.db")}");


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
                    .HasMany(c => c.Products)
                    .WithOne(p => p.Category)
                    .HasForeignKey(p => p.CategoryId);

        modelBuilder.Entity<Product>()
                    .HasMany(c => c.IncomeProducts)
                    .WithOne(p => p.Product)
                    .HasForeignKey(p => p.ProductId);

        Admin admin = new()
        {
            Id = 1,
            FullName = "Super Admin",
            PhoneNumber = "998996555744",
            Password = "Admin.123$"
        };

        modelBuilder.Entity<Admin>()
                    .HasData(admin);


        base.OnModelCreating(modelBuilder);
    }
}