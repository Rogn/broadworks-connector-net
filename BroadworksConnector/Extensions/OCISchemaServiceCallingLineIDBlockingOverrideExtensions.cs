using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallingLineIDBlockingOverrideExtensions
    {

        /// <summary>
        /// Request the user level data associated with Calling Line ID Blocking Override.
        /// The response is either a UserCallingLineIDBlockingOverrideGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallingLineIDBlockingOverrideGetRequestAsync instead.")]
        public static async Task<UserCallingLineIDBlockingOverrideGetResponse> UserCallingLineIDBlockingOverrideGetRequest(this OcipClientBase client, UserCallingLineIDBlockingOverrideGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallingLineIDBlockingOverrideGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Calling Line ID Blocking Override.
        /// The response is either a UserCallingLineIDBlockingOverrideGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallingLineIDBlockingOverrideGetResponse> UserCallingLineIDBlockingOverrideGetRequestAsync(this OcipClientBase client, UserCallingLineIDBlockingOverrideGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallingLineIDBlockingOverrideGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Calling Line ID Blocking Override.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallingLineIDBlockingOverrideModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallingLineIDBlockingOverrideModifyRequest(this OcipClientBase client, UserCallingLineIDBlockingOverrideModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Calling Line ID Blocking Override.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallingLineIDBlockingOverrideModifyRequestAsync(this OcipClientBase client, UserCallingLineIDBlockingOverrideModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
