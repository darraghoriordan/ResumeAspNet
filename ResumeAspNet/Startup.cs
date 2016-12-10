using System;
using Fuzzyminds.ResumeAspNet;
using Microsoft.Owin;
using Owin;
using System.IO;
using System.Linq;
using Fuzzyminds.ResumeAspNet.Models;

[assembly: OwinStartup(typeof(Startup))]
namespace Fuzzyminds.ResumeAspNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
