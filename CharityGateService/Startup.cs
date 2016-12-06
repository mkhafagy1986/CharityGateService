using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CharityGateService.Startup))]
namespace CharityGateService
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
