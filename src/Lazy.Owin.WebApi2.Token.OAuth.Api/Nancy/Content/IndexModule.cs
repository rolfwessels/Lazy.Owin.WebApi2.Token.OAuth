using Nancy;

namespace Lazy.Owin.WebApi2.Token.OAuth.Api.Nancy.Content
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };
        }
    }
}