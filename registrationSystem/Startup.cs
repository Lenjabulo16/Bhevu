using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(registrationSystem.Startup))]
namespace registrationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
