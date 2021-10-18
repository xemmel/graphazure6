using bestilmere.common.azure;
using bestilmere.common.azure.Models.Resources;
using Microsoft.AspNetCore.Mvc;

namespace graphazure6.Controllers;

[ApiController]
[Route("[controller]")]
public class AzureController : ControllerBase
{
    private readonly ILogger<AzureController> _logger;
    private readonly IResourceGroupHandler _resourceGroupHandler;

    public AzureController(ILogger<AzureController> logger, IResourceGroupHandler resourceGroupHandler)
    {
        _logger = logger;
        _resourceGroupHandler = resourceGroupHandler;
    }

    [HttpGet(Name = "GetAzureResourceGroups")]
    public async Task<IEnumerable<ResourceGroupModel>?> GetAsync()
    {
       var resourcegroups = await _resourceGroupHandler
                                        .GetResourceGroupsAsync();
        return resourcegroups;
    }
}
