using CRUD_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_EF.DataContext;

public class StudentDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; Database=StudentDB;");


    public DbSet<Student> Students { get; set; }
}