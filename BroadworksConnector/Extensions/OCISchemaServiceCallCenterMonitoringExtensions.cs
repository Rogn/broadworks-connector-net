using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallCenterMonitoringExtensions
    {

        /// <summary>
        /// Request the user's Call Center Monitoring settings.
        /// The response is either a UserCallCenterMonitoringGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterMonitoringGetRequestAsync instead.")]
        public static async Task<UserCallCenterMonitoringGetResponse> UserCallCenterMonitoringGetRequest(this OcipClientBase client, UserCallCenterMonitoringGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterMonitoringGetResponse;
        }

        /// <summary>
        /// Request the user's Call Center Monitoring settings.
        /// The response is either a UserCallCenterMonitoringGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterMonitoringGetResponse> UserCallCenterMonitoringGetRequestAsync(this OcipClientBase client, UserCallCenterMonitoringGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterMonitoringGetResponse;
        }
        /// <summary>
        /// Modify the user's Call Center Monitoring settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterMonitoringModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallCenterMonitoringModifyRequest(this OcipClientBase client, UserCallCenterMonitoringModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's Call Center Monitoring settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterMonitoringModifyRequestAsync(this OcipClientBase client, UserCallCenterMonitoringModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
