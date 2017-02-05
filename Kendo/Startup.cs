using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kendo.Startup))]
namespace Kendo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
