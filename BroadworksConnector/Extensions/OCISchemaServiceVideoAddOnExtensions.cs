using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceVideoAddOnExtensions
    {

        /// <summary>
        /// Get the user's Video Add-On service setting.
        /// The response is either a UserVideoAddOnGetResponse19 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVideoAddOnGetRequest19Async instead.")]
        public static async Task<UserVideoAddOnGetResponse19> UserVideoAddOnGetRequest19(this OcipClientBase client, UserVideoAddOnGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserVideoAddOnGetResponse19;
        }

        /// <summary>
        /// Get the user's Video Add-On service setting.
        /// The response is either a UserVideoAddOnGetResponse19 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVideoAddOnGetResponse19> UserVideoAddOnGetRequest19Async(this OcipClientBase client, UserVideoAddOnGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserVideoAddOnGetResponse19;
        }
        /// <summary>
        /// Get the user's Video Add-On service setting.
        /// The response is either a UserVideoAddOnGetResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVideoAddOnGetRequest22Async instead.")]
        public static async Task<UserVideoAddOnGetResponse22> UserVideoAddOnGetRequest22(this OcipClientBase client, UserVideoAddOnGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserVideoAddOnGetResponse22;
        }

        /// <summary>
        /// Get the user's Video Add-On service setting.
        /// The response is either a UserVideoAddOnGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVideoAddOnGetResponse22> UserVideoAddOnGetRequest22Async(this OcipClientBase client, UserVideoAddOnGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserVideoAddOnGetResponse22;
        }
        /// <summary>
        /// Modify the user's Video Add-On service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVideoAddOnModifyRequest14Async instead.")]
        public static async Task<SuccessResponse> UserVideoAddOnModifyRequest14(this OcipClientBase client, UserVideoAddOnModifyRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's Video Add-On service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVideoAddOnModifyRequest14Async(this OcipClientBase client, UserVideoAddOnModifyRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
