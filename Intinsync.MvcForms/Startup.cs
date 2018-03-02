using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Intinsync.MvcForms.Startup))]
namespace Intinsync.MvcForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
