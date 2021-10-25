using bestilmere.common.azure;
using bestilmere.common.azure.Models.Configuration;
using bestilmere.common.azure.Models.Resources;
using HotChocolate;
using HotChocolate.Data;
using Microsoft.Extensions.Options;

namespace graphazure6
{
    public class Query
    {
        public string GetVersion() => "0.3.8";

        public OAuthRequestConfigurationModel GetConfiguration([Service] IOptions<OAuthRequestConfigurationModel> config)
            => config.Value;
 
    }
}