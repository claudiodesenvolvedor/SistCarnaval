using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRJ.SistemaCarnaval.UI.Cadastro.Startup))]
namespace PRJ.SistemaCarnaval.UI.Cadastro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
