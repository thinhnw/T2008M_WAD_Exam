using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(T2008M_WAD_Exam.Startup))]
namespace T2008M_WAD_Exam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
