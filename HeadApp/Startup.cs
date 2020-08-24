using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeadApp.Startup))]
namespace HeadApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
