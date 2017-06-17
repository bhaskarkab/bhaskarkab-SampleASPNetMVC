using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleASPNetMVC.Startup))]
namespace SampleASPNetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
