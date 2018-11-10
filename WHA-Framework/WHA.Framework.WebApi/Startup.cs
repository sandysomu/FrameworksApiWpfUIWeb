using Microsoft.Owin;
using Owin;
using WpfAPI;

[assembly: OwinStartup(typeof(Startup))]

namespace WpfAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
