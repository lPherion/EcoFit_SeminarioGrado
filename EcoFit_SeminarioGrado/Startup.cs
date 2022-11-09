using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcoFit_SeminarioGrado.Startup))]
namespace EcoFit_SeminarioGrado
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
