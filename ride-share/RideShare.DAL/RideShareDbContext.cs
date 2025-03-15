using Microsoft.EntityFrameworkCore;

namespace RideShare.DAL;

public class RideShareDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public RideShareDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}