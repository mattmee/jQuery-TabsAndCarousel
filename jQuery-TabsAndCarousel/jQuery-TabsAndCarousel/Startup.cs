using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jQuery_TabsAndCarousel.Startup))]
namespace jQuery_TabsAndCarousel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
