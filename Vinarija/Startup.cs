using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vinarija.Startup))]
namespace Vinarija
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
