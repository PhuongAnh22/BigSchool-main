using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigShool1.Startup))]
namespace BigShool1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
