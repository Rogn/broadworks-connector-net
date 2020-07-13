using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceDirectedCallPickupWithBargeInExtensions
    {

        /// <summary>
        /// Request the user level data associated with Directed Call Pickup With Barge In.
        /// The response is either a UserDirectedCallPickupWithBargeInGetResponse14sp7 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserDirectedCallPickupWithBargeInGetRequest14sp7Async instead.")]
        public static async Task<UserDirectedCallPickupWithBargeInGetResponse14sp7> UserDirectedCallPickupWithBargeInGetRequest14sp7(this OcipClientBase client, UserDirectedCallPickupWithBargeInGetRequest14sp7 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserDirectedCallPickupWithBargeInGetResponse14sp7;
        }

        /// <summary>
        /// Request the user level data associated with Directed Call Pickup With Barge In.
        /// The response is either a UserDirectedCallPickupWithBargeInGetResponse14sp7 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserDirectedCallPickupWithBargeInGetResponse14sp7> UserDirectedCallPickupWithBargeInGetRequest14sp7Async(this OcipClientBase client, UserDirectedCallPickupWithBargeInGetRequest14sp7 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserDirectedCallPickupWithBargeInGetResponse14sp7;
        }
        /// <summary>
        /// Modify the user level data associated with Directed Call Pickup With Barge In.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserDirectedCallPickupWithBargeInModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserDirectedCallPickupWithBargeInModifyRequest(this OcipClientBase client, UserDirectedCallPickupWithBargeInModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Directed Call Pickup With Barge In.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserDirectedCallPickupWithBargeInModifyRequestAsync(this OcipClientBase client, UserDirectedCallPickupWithBargeInModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
