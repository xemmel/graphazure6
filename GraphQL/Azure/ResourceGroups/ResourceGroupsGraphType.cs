using bestilmere.common.azure;
using bestilmere.common.azure.Models.Resources;
using HotChocolate;
using HotChocolate.Types;

namespace graphazure6
{
    public class ResourceGroupsGraphType : ObjectType<ResourceGroupModel>
    {
        protected override void Configure(IObjectTypeDescriptor<ResourceGroupModel> descriptor)
        {
            descriptor
                .Field(f => f.Id)
                .Description("The Id of the Resource Group");

            descriptor
                .Field("resources")
                .ResolveWith<Resolvers>(r => r.GetResourcesAsync(default!,default!,default!));
        }

        private class Resolvers
        {
            public Task<IEnumerable<ResourceModel>?> GetResourcesAsync(
                [Parent] ResourceGroupModel resourceGroupModel,
                [Service] IResourceHandler resourceHandler,
                CancellationToken cancellationToken
            ) => resourceHandler.GetResourcesByResourceGroupAsync(
                            resourceGroupName: resourceGroupModel.Name,
                            cancellationToken: cancellationToken);
        }
    }
}