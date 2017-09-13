using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentMV.Startup))]
namespace RentMV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
