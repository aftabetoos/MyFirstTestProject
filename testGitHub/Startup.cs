using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testGitHub.Startup))]
namespace testGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
