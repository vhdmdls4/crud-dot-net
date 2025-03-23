using crud_dot_net.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace crud_dot_net.DatabaseContext;

public class AppDbContext : DbContext
{
    //store connection string
    private readonly DbSettings _settings;

    //inject dbsettings model through constructor
    public AppDbContext(IOptions<DbSettings> settings)
    {
        _settings = settings.Value;
    }
    
    //represents the dbset property
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Loan> Loans { get; set; }
    
    //config model book entity
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}