using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSch.Startup))]
namespace BigSch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
