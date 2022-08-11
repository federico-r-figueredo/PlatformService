
using PlatformService.Models;

namespace PlatformService.Data.Repositories;

public class PlatformRepository : Repository<Platform>, IPlatformRepository
{
    public PlatformRepository(PlatformDbContext context) : base(context)
    {
        
    }
}