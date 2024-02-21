using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using System.Web.Services.Description;

[assembly: OwinStartup(typeof(Constructor_DI.Repository.Startup))]

namespace Constructor_DI.Repository
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Register the repository implementation with the interface
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddControllersWithViews();
        }

    }
}
