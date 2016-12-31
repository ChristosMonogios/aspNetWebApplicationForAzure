using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspNetWebApplicationForAzure.Startup))]
namespace aspNetWebApplicationForAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
