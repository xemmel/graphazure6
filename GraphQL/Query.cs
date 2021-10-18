using bestilmere.common.azure;
using bestilmere.common.azure.Models.Resources;
using HotChocolate;

namespace graphazure6
{
    public class Query
    {
        public string GetVersion() => "0.3.0";

        public Task<IEnumerable<ResourceGroupModel>?> GetResourceGroupsAsync(
                    [Service] IResourceGroupHandler resourceGroupHandler,
                    CancellationToken cancellationToken)
                    => resourceGroupHandler.GetResourceGroupsAsync(cancellationToken: cancellationToken);
    }
}