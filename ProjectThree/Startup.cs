using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectThree.Startup))]
namespace ProjectThree
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
