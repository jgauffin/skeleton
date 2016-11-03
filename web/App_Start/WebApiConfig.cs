﻿namespace Skeleton.Web {
    using System.Web.Http;
    using System.Web.Http.ExceptionHandling;
    using Telemetry;

    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            config.MapHttpAttributeRoutes();
            config.Services.Add(typeof(IExceptionLogger), new AiExceptionLogger());
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
