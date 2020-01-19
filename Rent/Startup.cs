using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rent.Startup))]
namespace Rent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
