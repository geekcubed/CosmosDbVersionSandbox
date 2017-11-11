using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CosmosDbVersionSandbox.Controllers
{
    public class HomeController : ApiController
    {
        /// <summary>
        /// Get a simple string to verify that the application is running
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public string GetStatus()
        {
            return "OKay";
        }

    }
}
