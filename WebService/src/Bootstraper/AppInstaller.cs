using Microsoft.Extensions.DependencyInjection;
using Platform.DatasAccess.Readers;
using Platform.QueryHandlers;
using PlatformApi.QueryHandlers;

namespace Bootstraper
{
    public class AppInstaller : IInstaller
    {
        public void Install(IServiceCollection services)
        {
            services.AddTransient<IGetClientsQueryHandler, GetClientsQueryHandler>();
            services.AddTransient<IClientsReader, ClientsReader>();
        }
    }
}
