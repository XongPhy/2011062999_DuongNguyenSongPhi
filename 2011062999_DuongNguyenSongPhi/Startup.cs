using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011062999_DuongNguyenSongPhi.Startup))]
namespace _2011062999_DuongNguyenSongPhi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
