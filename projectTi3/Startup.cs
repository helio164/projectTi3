using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projectTi3.Startup))]
namespace projectTi3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
