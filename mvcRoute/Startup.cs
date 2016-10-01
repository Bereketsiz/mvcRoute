using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcRoute.Startup))]
namespace mvcRoute
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
