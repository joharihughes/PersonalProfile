using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalProfileWebsite.Startup))]
namespace PersonalProfileWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
