using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RideShare.DAL;

public class RideShareDbContextFactory : IDesignTimeDbContextFactory<RideShareDbContext>, IDbContextFactory<RideShareDbContext>
{
    public RideShareDbContext CreateDbContext()
    {
        return CreateDbContext([]);
    }

    public RideShareDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddUserSecrets<RideShareDbContextFactory>()
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<RideShareDbContext>();

        optionsBuilder.UseSqlServer(configuration.GetConnectionString("RideShareConnection"));

        return new RideShareDbContext(optionsBuilder.Options);
    }
}
