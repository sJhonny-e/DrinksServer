using DrinksServer.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DrinksServer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // IoC registration
            IoCRegistrator.RegisterIoCContainer(config);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{name}",
                defaults: new { name = RouteParameter.Optional }
            );
        }
    }
}
