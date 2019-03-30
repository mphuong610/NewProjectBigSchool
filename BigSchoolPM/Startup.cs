using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchoolPM.Startup))]
namespace BigSchoolPM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
