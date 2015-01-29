using Lazy.Owin.WebApi2.Token.OAuth.Api.AppStartup;
using Lazy.Owin.WebApi2.Token.OAuth.OAuth2;
using Owin;

namespace Lazy.Owin.WebApi2.Token.OAuth.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            WebApiSetup webApiSetup = WebApiSetup.Initialize(appBuilder);
			OathAuthorizationSetup.Initialize(appBuilder);
            appBuilder.UseNancy();
            webApiSetup.Configuration.EnsureInitialized();
        }
    }
}