using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParallelProgramming.WebA.Startup))]
namespace ParallelProgramming.WebA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
