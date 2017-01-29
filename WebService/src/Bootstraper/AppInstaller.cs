using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Platform;
using Platform.DatasAccess.Readers;
using Platform.QueryHandlers;
using PlatformApi.QueryHandlers;
using System.IO;

namespace Bootstraper
{
    public class AppInstaller : IInstaller
    {
        public static IConfigurationRoot Configuration { get; set; }

        public void Install(IServiceCollection services)
        {
            //string rootPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\..\"));
            string rootPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));

            var builder = new ConfigurationBuilder()
                            .SetBasePath(rootPath)
                            .AddJsonFile("global.json");

            Configuration = builder.Build();

            services.AddDbContext<PlatformContext>(options => options.UseSqlServer($"{Configuration["ConnectionStrings:DefaultConnection"]}"));

            services.AddTransient<IGetClientsQueryHandler, GetClientsQueryHandler>();
            services.AddTransient<IClientsReader, ClientsReader>();
        }
    }
}
