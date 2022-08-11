
using Microsoft.EntityFrameworkCore;

namespace PlatformService;

public class PlatformDbContext : DbContext
{
    public PlatformDbContext(DbContextOptions<PlatformDbContext> dbContextOptions) : base(dbContextOptions)
    {
        
    }

    public DbSet<Platform> Platforms { get; set; }
}