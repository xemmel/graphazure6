using bestilmere.common.azure;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;

namespace graphazure6
{
    [ExtendObjectType(name: "Query")]
    public class ResourcesQueryType
    {
          [UseFiltering]
        public Task<IEnumerable<ResourceModel>?> GetResourcesAsync(
                    [Service] IResourceHandler resourceHandler,
                    CancellationToken cancellationToken)
                    => resourceHandler.GetResourcesAsync(cancellationToken: cancellationToken);
    }
}