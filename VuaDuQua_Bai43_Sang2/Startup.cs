using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuaDuQua_Bai43_Sang2.Startup))]
namespace VuaDuQua_Bai43_Sang2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
