using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResumeAspNet.Startup))]
namespace ResumeAspNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
