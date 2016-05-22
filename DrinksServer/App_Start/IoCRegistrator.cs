using DrinksServer.DAL;
using DrinksServer.Models;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace DrinksServer.App_Start
{
    internal static class IoCRegistrator
    {
        // just a static method to register everything in the app.
        // TODO: do this more modularly (register dependencies per each module), or better - automatically :)
        public static void RegisterIoCContainer(HttpConfiguration config)
        {
            var container = new UnityContainer();
            // dependency is registered as 'container controlled' since it keeps state for the duration of the application.
            // TODO: change this to something more reasonable when using an actual data storage
            container.RegisterType<IDrinksRepository, DrinksRepository>(new ContainerControlledLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}