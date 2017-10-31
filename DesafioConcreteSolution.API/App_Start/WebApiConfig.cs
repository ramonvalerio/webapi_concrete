using DesafioConcreteSolution.Infrastructure.DI;
using Ninject;
using System.Web.Http;

namespace DesafioConcreteSolution.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            new DesafioConcreteSolutionsKernel(new StandardKernel(new DesafioConcreteSolutionsModule()));

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Error404",
                routeTemplate: "{*url}",
                defaults: new { controller = "Error", action = "Handle404" }
            );
        }
    }
}
