using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Murray.Tradeinterchange_Demo.App.Startup))]
namespace Murray.Tradeinterchange_Demo.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
