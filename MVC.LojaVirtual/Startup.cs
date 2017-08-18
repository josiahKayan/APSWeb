using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.LojaVirtual.Startup))]
namespace MVC.LojaVirtual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
