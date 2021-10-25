using bestilmere.common.azure;
using bestilmere.common.azure.Models.Monitor;
using HotChocolate;
using HotChocolate.Types;

namespace graphazure6
{
    [ExtendObjectType(name: "Query")]
    public class ActivityLogQueryType
    {
        public Task<IEnumerable<ActivityLogModel>?> GetActivityLogsAsync(
                    string resourceId,
                    [Service] IActivityLogHandler activityLogHandler,
                    CancellationToken cancellationToken,
                    int? hoursBack = null)
                    => activityLogHandler.GetActivityLogsAsync(
                                resourceId: resourceId,
                                hoursBack: hoursBack,
                                cancellationToken: cancellationToken);
    }
}
