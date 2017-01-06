using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(N2NService.Startup))]

namespace N2NService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}