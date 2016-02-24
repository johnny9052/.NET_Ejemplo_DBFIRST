using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataBaseFirst.Startup))]
namespace DataBaseFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
