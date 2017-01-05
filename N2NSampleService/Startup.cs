using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(N2NSample.Service.Startup))]

namespace N2NSample.Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}