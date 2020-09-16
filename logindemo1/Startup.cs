using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(logindemo1.Startup))]
namespace logindemo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
