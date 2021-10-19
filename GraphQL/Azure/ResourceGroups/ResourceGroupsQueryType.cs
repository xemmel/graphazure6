using bestilmere.common.azure;
using bestilmere.common.azure.Models.Resources;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;

namespace graphazure6
{
    [ExtendObjectType(name: "Query")]
    public class ResourceGroupsQueryType
    {
        
        [UseFiltering]
        public Task<IEnumerable<ResourceGroupModel>?> GetResourceGroupsAsync(
                    [Service] IResourceGroupHandler resourceGroupHandler,
                    CancellationToken cancellationToken)
                    => resourceGroupHandler.GetResourceGroupsAsync(cancellationToken: cancellationToken);
    }
}