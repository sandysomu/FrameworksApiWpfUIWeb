using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WHA.Framework.WebApi.Startup))]

namespace WHA.Framework.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
