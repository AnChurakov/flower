using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Flower.Startup))]
namespace Flower
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
