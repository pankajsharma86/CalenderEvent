using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventCalender.Startup))]
namespace EventCalender
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
