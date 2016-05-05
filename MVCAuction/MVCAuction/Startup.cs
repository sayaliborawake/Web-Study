using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAuction.Startup))]
namespace MVCAuction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
