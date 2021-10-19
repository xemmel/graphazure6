using bestilmere.common.azure;
using bestilmere.common.azure.Models.Resources;
using HotChocolate;
using HotChocolate.Data;

namespace graphazure6
{
    public class Query
    {
        public string GetVersion() => "0.3.1";

        [UseFiltering]
        public Task<IEnumerable<ResourceGroupModel>?> GetResourceGroupsAsync(
                    [Service] IResourceGroupHandler resourceGroupHandler,
                    CancellationToken cancellationToken)
                    => resourceGroupHandler.GetResourceGroupsAsync(cancellationToken: cancellationToken);
    }
}