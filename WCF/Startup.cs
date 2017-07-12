using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WCF.Startup))]
namespace WCF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
