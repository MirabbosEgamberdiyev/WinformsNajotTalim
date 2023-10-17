using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        using var dbContext = new AppDbContext();
        Random random = new();
        Test test = new()
        {
            Id = Guid.NewGuid(),
            Number = random.Next(1, 1000)
        };

        dbContext.Tests.Add(test);
        dbContext.SaveChanges();

        var tests = dbContext.Tests.ToList();
        foreach (var t in  tests)
        {
            Console.WriteLine("Id: " + t.Id);
            Console.WriteLine("Number: " + t.Number);
            Console.WriteLine();
        }
    }
}

class Test
{
    [Key]
    public Guid Id { get; set; }
    public int Number { get; set; }
}

class AppDbContext : DbContext
{
    public AppDbContext()
    {
        Database.EnsureCreated();
    }

    const string CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB; Database=TakrorlashDB2;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(CONNECTION_STRING);

    public DbSet<Test> Tests { get; set; }
}