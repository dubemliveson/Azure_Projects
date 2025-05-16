using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;


namespace func
{
 public class GetSettingInfo
{
    [Function("GetSettingInfo")]
    public HttpResponseData Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req,
        FunctionContext context,
        [BlobInput("content/local.settings.json", Connection = "AzureWebJobsStorage")] string blobContent)
    {
        var logger = context.GetLogger<GetSettingInfo>();
        logger.LogInformation("C# HTTP trigger function processed a request.");
        logger.LogDebug("Blob content: {blob}", blobContent);

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "application/json; charset=utf-8");
        response.WriteString(blobContent);
        return response;
    }
}
}