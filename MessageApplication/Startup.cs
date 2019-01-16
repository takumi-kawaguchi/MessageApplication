using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessageApplication.Startup))]
namespace MessageApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
