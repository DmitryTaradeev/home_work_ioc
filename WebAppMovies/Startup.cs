using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppMovies.Startup))]
namespace WebAppMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
