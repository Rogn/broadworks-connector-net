using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceHotelingHostExtensions
    {

        /// <summary>
        /// Request the user level data associated with Hoteling Host.
        /// The response is either a UserHotelingHostGetResponse17 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserHotelingHostGetRequest17Async instead.")]
        public static async Task<UserHotelingHostGetResponse17> UserHotelingHostGetRequest17(this OcipClientBase client, UserHotelingHostGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserHotelingHostGetResponse17;
        }

        /// <summary>
        /// Request the user level data associated with Hoteling Host.
        /// The response is either a UserHotelingHostGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<UserHotelingHostGetResponse17> UserHotelingHostGetRequest17Async(this OcipClientBase client, UserHotelingHostGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserHotelingHostGetResponse17;
        }
        /// <summary>
        /// Modify the user level data associated with Hoteling Host.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserHotelingHostModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserHotelingHostModifyRequest(this OcipClientBase client, UserHotelingHostModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Hoteling Host.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserHotelingHostModifyRequestAsync(this OcipClientBase client, UserHotelingHostModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
