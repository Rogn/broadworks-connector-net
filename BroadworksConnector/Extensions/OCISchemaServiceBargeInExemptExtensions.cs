using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceBargeInExemptExtensions
    {

        /// <summary>
        /// Request the user level data associated with Barge In Exempt.
        /// The response is either a UserBargeInExemptGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBargeInExemptGetRequestAsync instead.")]
        public static async Task<UserBargeInExemptGetResponse> UserBargeInExemptGetRequest(this OcipClientBase client, UserBargeInExemptGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBargeInExemptGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Barge In Exempt.
        /// The response is either a UserBargeInExemptGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserBargeInExemptGetResponse> UserBargeInExemptGetRequestAsync(this OcipClientBase client, UserBargeInExemptGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBargeInExemptGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Barge In Exempt.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBargeInExemptModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBargeInExemptModifyRequest(this OcipClientBase client, UserBargeInExemptModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Barge In Exempt.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBargeInExemptModifyRequestAsync(this OcipClientBase client, UserBargeInExemptModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
