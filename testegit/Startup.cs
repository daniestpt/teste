using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testegit.Startup))]
namespace testegit
{
    public partial class Startup
    {
        //sadsadsada  232323
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }   
}
