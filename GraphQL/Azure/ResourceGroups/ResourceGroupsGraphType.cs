using bestilmere.common.azure.Models.Resources;
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
        }
    }
}