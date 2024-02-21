using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Integgrated_Authentication.Startup))]
namespace Integgrated_Authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
