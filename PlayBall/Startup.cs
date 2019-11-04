using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlayBall.Startup))]
namespace PlayBall
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
