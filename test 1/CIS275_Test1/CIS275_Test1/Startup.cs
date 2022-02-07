using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIS275_Test1.Startup))]
namespace CIS275_Test1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
