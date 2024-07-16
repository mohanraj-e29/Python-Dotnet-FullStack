using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(validation.Startup))]
namespace validation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
