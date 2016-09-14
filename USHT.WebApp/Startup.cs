using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(USHT.WebApp.Startup))]
namespace USHT.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
