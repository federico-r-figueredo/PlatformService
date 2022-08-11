
namespace PlatformService.Data.Repositories;

public interface IUnitOfWork : IDisposable
{
    public IPlatformRepository Platforms { get; }
    bool Complete();
}