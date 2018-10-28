using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Floristeria.Backend.Startup))]
namespace Floristeria.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
