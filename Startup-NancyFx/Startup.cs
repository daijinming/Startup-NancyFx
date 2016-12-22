using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Startup_NancyFx.Startup))]
namespace Startup_NancyFx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
            app.UseNancy();
        }

    }
}
