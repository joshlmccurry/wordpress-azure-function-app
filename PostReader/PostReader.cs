using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace PostReader
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("WordPress Trigger Received!");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            WordPressPost data = JsonConvert.DeserializeObject<WordPressPost>(requestBody);
            data.JSON_String = requestBody;



            log.LogInformation(data.ToString());

            return new OkObjectResult("Trigger completed successfully!");
        }
    }
}
