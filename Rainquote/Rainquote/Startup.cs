using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rainquote.Startup))]
namespace Rainquote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
