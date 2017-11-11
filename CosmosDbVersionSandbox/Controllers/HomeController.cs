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
            //Just creat an object refrence so that [we] know the DocumentDB library is 
            //referenced by the solution code.
            var fo = new Microsoft.Azure.Documents.Client.FeedOptions();

            return "OKay";
        }

    }
}
