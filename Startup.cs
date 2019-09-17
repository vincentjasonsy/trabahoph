using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrabahoPH.Startup))]
namespace TrabahoPH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
