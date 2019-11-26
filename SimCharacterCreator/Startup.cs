using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimCharacterCreator.Startup))]
namespace SimCharacterCreator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
