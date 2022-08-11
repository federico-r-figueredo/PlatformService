
using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data;

public class PlatformDbContext : DbContext
{
    public PlatformDbContext(DbContextOptions<PlatformDbContext> context) : base(context)
    {
        
    }

    public DbSet<Platform>? Platforms { get; set; }
}