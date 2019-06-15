using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiContrib.Formatting.Jsonp;

namespace Currency.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
			var jsonpFormatter = new JsonpMediaTypeFormatter(config.Formatters.JsonFormatter);
			config.Formatters.Add(jsonpFormatter);

			//var cors = new EnableCorsAttribute(WebConfigurationManager.AppSettings["corsUrl"], "*", "*");
			//var cors = new EnableCorsAttribute("*", "*", "*");
			config.EnableCors(new EnableCorsAttribute(WebConfigurationManager.AppSettings["corsUrl"], "", ""));

			// Маршруты веб-API
			config.MapHttpAttributeRoutes();
			config.Formatters.Add(new JsonMediaTypeFormatter());

			config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { controller = "Currency", action = "Get", id = RouteParameter.Optional }
            );
        }
    }
}
