using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2_Chatter.Startup))]
namespace _2_Chatter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
