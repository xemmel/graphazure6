using bestilmere.common.azure;
using bestilmere.common.azure.Models.Resources;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;

namespace graphazure6
{
    [ExtendObjectType(name: "Query")]
    public class RoleDefinitionsQueryType
    {
       [UseFiltering]
        public Task<IEnumerable<RoleDefinitionModel>?> GetRoleDefitionsAsync(
                [Service] IRoleHandler roleHandler,
                CancellationToken cancellationToken)
                => roleHandler.GetRoleDefinitionsAsync(cancellationToken: cancellationToken); 

    }
}