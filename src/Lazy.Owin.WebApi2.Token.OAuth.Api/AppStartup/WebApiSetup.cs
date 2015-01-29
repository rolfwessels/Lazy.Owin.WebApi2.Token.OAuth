using System.Web.Http;
using Microsoft.Owin.Cors;
using Owin;

namespace Lazy.Owin.WebApi2.Token.OAuth.Api.AppStartup
{
  public class WebApiSetup
  {
    private static bool _isInitialized;
    private static readonly object _locker = new object();
    private static WebApiSetup _instance;
    private readonly HttpConfiguration _configuration;

    protected WebApiSetup(IAppBuilder appBuilder)
    {
      var configuration = new HttpConfiguration();
      //routing done using attributes. see route helper form all routes
      configuration.MapHttpAttributeRoutes();
      appBuilder.UseCors(CorsOptions.AllowAll);
      appBuilder.UseWebApi(configuration);
      _configuration = configuration;
    }

    public HttpConfiguration Configuration
    {
      get { return _configuration; }
    }

   

    #region Initialize

    public static WebApiSetup Initialize(IAppBuilder appBuilder)
    {
      if (_isInitialized) return _instance;
      lock (_locker)
      {
        if (!_isInitialized)
        {
          _instance = new WebApiSetup(appBuilder);
          _isInitialized = true;
        }
      }
      return _instance;
    }

    #endregion
  }
}