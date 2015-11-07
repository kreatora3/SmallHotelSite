using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmallHotel.WebMVC.Startup))]
namespace SmallHotel.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
