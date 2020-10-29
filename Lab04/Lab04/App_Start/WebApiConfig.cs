﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Lab04
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{features_hash}",
                defaults: new { features_hash = RouteParameter.Optional }
            );
        }
    }
}
