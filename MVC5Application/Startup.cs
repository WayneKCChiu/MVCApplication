using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Application.Startup))]
namespace MVC5Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
