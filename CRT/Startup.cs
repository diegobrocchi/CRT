using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRT.Startup))]
namespace CRT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
