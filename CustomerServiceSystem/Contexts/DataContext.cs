using CustomerServiceSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace CustomerServiceSystem.Contexts;

internal class DataContext : DbContext
{
    private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jimmie\Desktop\Webutveckling\Datalagring\Final-Exam\Final-Exam\CustomerServiceSystem\Data\local_db.mdf;Integrated Security=True;Connect Timeout=30";
    public DataContext()
    {

    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(_connectionString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<CaseEntity> Cases { get; set; } = null!;
    public DbSet<CustomerEntity> Customers { get; set; } = null!;



}
