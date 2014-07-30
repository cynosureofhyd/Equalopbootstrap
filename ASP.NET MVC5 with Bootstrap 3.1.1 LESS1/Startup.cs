using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Equalop.Startup))]
namespace Equalop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
