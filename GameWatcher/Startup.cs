using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameWatcher.Startup))]
namespace GameWatcher
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
