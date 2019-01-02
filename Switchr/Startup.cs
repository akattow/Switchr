using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Switchr.Startup))]
namespace Switchr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
