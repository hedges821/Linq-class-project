using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(authenticationPractice.Startup))]
namespace authenticationPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
