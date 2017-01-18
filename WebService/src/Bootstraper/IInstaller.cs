using Microsoft.Extensions.DependencyInjection;

namespace Bootstraper
{
    public interface IInstaller
    {
        void Install(IServiceCollection services);
    }
}