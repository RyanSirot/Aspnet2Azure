using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspnetLab4HtmlHelper.Startup))]
namespace AspnetLab4HtmlHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
