using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcContosoUniversity.Startup))]
namespace mvcContosoUniversity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
