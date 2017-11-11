﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace CosmosDbVersionSandbox
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //Remove XML Formatter
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
