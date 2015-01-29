using System.Reflection;
using System.Runtime.InteropServices;
using Lazy.Owin.WebApi2.Token.OAuth.Api;
using Microsoft.Owin;

[assembly: AssemblyTitle("Lazy.Owin.WebApi2.Token.OAuth.Web")]
[assembly: AssemblyDescription("Contains all Lazy.Owin.WebApi2.Token.OAuth unit tests")]
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
[assembly: OwinStartup(typeof(Startup))]

[assembly: ComVisible(false)]
[assembly: Guid("52c1725e-fcbc-46b7-8f0c-53d9ce5ea8d6")]

