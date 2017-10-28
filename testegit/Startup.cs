using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testegit.Startup))]
namespace testegit
{
    public partial class Startup
    {
        //sadsadsada sadasdasd 32423432423423423
        public void Configuration(IAppBuilder app)
        {
            //sadasdasdasdasd master 2222
            ConfigureAuth(app);
        }
    }   
}
