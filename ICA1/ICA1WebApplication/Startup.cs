using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICA1WebApplication.Startup))]
namespace ICA1WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
