using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace clash_stats_api;

public class GetPlayerData
{
    private readonly ILogger<GetPlayerData> _logger;

    public GetPlayerData(ILogger<GetPlayerData> logger)
    {
        _logger = logger;
    }

    [Function("GetPlayerData")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}
