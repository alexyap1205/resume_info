using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(alexyap1205info.Startup))]

namespace alexyap1205info
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
