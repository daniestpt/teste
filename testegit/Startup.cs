using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testegit.Startup))]
namespace testegit
{
    public partial class Startup
    {
        //sadsadsada sadasdasd
        public void Configuration(IAppBuilder app)
        {
            //sadasdasdasdasd
            ConfigureAuth(app);
        }
    }
}
