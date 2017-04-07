using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TESTASPNET.Startup))]
namespace TESTASPNET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
