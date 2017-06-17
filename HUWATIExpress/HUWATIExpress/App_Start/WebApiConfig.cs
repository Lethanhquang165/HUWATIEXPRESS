using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace HUWATIExpress
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{startPoint}",
                defaults: new {startPoint = RouteParameter.Optional}
            );

            config.Routes.MapHttpRoute(
                name: "GetTripByPoints",
                routeTemplate: "api/{controller}/{action}/{startPoint}/{defPoint}/{startDate}",
                defaults: new { startPoint = RouteParameter.Optional, defPoint = RouteParameter.Optional, startDate = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "GetListOfTripHaveEmptySeatByStartDaY",
                routeTemplate: "api/{controller}/{action}/{startDay}",
                defaults: new { startDay = RouteParameter.Optional }
            );
        }
    }
}
