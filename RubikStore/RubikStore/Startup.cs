using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RubikStore.Startup))]
namespace RubikStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
