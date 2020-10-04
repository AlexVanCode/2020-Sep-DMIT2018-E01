using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_1_2020.Startup))]
namespace WebApp_1_2020
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
