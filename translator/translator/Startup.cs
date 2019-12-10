using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(translator.Startup))]
namespace translator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
