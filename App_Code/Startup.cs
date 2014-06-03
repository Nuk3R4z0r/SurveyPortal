using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SurveyPortal.Startup))]
namespace SurveyPortal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
