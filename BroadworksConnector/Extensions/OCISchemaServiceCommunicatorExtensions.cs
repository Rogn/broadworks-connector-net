using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCommunicatorExtensions
    {

        /// <summary>
        /// Request to get Configuration Server for a specified service
        /// provider. The response is either a ServiceProviderBroadWorksCommunicatorGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderBroadWorksCommunicatorGetRequestAsync instead.")]
        public static async Task<ServiceProviderBroadWorksCommunicatorGetResponse> ServiceProviderBroadWorksCommunicatorGetRequest(this OcipClientBase client, ServiceProviderBroadWorksCommunicatorGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderBroadWorksCommunicatorGetResponse;
        }

        /// <summary>
        /// Request to get Configuration Server for a specified service
        /// provider. The response is either a ServiceProviderBroadWorksCommunicatorGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderBroadWorksCommunicatorGetResponse> ServiceProviderBroadWorksCommunicatorGetRequestAsync(this OcipClientBase client, ServiceProviderBroadWorksCommunicatorGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderBroadWorksCommunicatorGetResponse;
        }
        /// <summary>
        /// Request to modify the Configuration URL. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderBroadWorksCommunicatorModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderBroadWorksCommunicatorModifyRequest(this OcipClientBase client, ServiceProviderBroadWorksCommunicatorModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the Configuration URL. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderBroadWorksCommunicatorModifyRequestAsync(this OcipClientBase client, ServiceProviderBroadWorksCommunicatorModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the Configuration Server for a specified user.
        /// The response is either a UserBroadWorksCommunicatorGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksCommunicatorGetRequestAsync instead.")]
        public static async Task<UserBroadWorksCommunicatorGetResponse> UserBroadWorksCommunicatorGetRequest(this OcipClientBase client, UserBroadWorksCommunicatorGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksCommunicatorGetResponse;
        }

        /// <summary>
        /// Request to get the Configuration Server for a specified user.
        /// The response is either a UserBroadWorksCommunicatorGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksCommunicatorGetResponse> UserBroadWorksCommunicatorGetRequestAsync(this OcipClientBase client, UserBroadWorksCommunicatorGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksCommunicatorGetResponse;
        }

    }
}
