using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConcertHub.Startup))]
namespace ConcertHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
