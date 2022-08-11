
namespace PlatformService.Data.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly PlatformDbContext _context;

    public IPlatformRepository Platforms { get; private set; }

    public UnitOfWork(PlatformDbContext context, IPlatformRepository platformRepository)
    {
        _context = context;
        Platforms = platformRepository;
    }

    public bool Complete()
    {
        return (_context.SaveChanges() >= 0);
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}