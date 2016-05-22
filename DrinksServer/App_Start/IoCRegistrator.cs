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
            container.RegisterType<IDrinksRepository, DrinksRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}