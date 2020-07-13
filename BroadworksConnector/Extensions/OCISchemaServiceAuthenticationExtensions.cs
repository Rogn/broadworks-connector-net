using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceAuthenticationExtensions
    {

        /// <summary>
        /// Get the user's authentication service information.
        /// The response is either a UserAuthenticationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAuthenticationGetRequestAsync instead.")]
        public static async Task<UserAuthenticationGetResponse> UserAuthenticationGetRequest(this OcipClientBase client, UserAuthenticationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAuthenticationGetResponse;
        }

        /// <summary>
        /// Get the user's authentication service information.
        /// The response is either a UserAuthenticationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserAuthenticationGetResponse> UserAuthenticationGetRequestAsync(this OcipClientBase client, UserAuthenticationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAuthenticationGetResponse;
        }
        /// <summary>
        /// Modify the user's authentication service information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAuthenticationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAuthenticationModifyRequest(this OcipClientBase client, UserAuthenticationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's authentication service information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAuthenticationModifyRequestAsync(this OcipClientBase client, UserAuthenticationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
