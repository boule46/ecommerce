using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EvaEcommerce.Startup))]
namespace EvaEcommerce
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
