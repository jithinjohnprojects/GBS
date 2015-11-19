using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GBS.Startup))]
namespace GBS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
