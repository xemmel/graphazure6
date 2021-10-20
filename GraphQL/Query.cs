using bestilmere.common.azure;
using bestilmere.common.azure.Models.Resources;
using HotChocolate;
using HotChocolate.Data;

namespace graphazure6
{
    public class Query
    {
        public string GetVersion() => "0.3.6";


        [UseFiltering]
        public Task<IEnumerable<RoleDefinitionModel>?> GetRoleDefitionsAsync(
                [Service] IRoleHandler roleHandler,
                CancellationToken cancellationToken)
                => roleHandler.GetRoleDefinitionsAsync(cancellationToken: cancellationToken);
    }
}