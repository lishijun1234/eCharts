using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCharts.Startup))]
namespace eCharts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
