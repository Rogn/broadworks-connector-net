using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSimultaneousRingPersonalExtensions
    {

        /// <summary>
        /// Add a criteria to the user's simultaneous ring personal service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSimultaneousRingPersonalAddCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalAddCriteriaRequest(this OcipClientBase client, UserSimultaneousRingPersonalAddCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's simultaneous ring personal service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalAddCriteriaRequestAsync(this OcipClientBase client, UserSimultaneousRingPersonalAddCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a criteria from the user's simultaneous ring personal service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSimultaneousRingPersonalDeleteCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalDeleteCriteriaRequest(this OcipClientBase client, UserSimultaneousRingPersonalDeleteCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's simultaneous ring personal service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalDeleteCriteriaRequestAsync(this OcipClientBase client, UserSimultaneousRingPersonalDeleteCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a criteria for the user's simultaneous ring personal service.
        /// The response is either a UserSimultaneousRingPersonalGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSimultaneousRingPersonalGetCriteriaRequestAsync instead.")]
        public static async Task<UserSimultaneousRingPersonalGetCriteriaResponse> UserSimultaneousRingPersonalGetCriteriaRequest(this OcipClientBase client, UserSimultaneousRingPersonalGetCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSimultaneousRingPersonalGetCriteriaResponse;
        }

        /// <summary>
        /// Get a criteria for the user's simultaneous ring personal service.
        /// The response is either a UserSimultaneousRingPersonalGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSimultaneousRingPersonalGetCriteriaResponse> UserSimultaneousRingPersonalGetCriteriaRequestAsync(this OcipClientBase client, UserSimultaneousRingPersonalGetCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSimultaneousRingPersonalGetCriteriaResponse;
        }
        /// <summary>
        /// Get the user's simultaneous ring personal service setting.
        /// The response is either a UserSimultaneousRingPersonalGetResponse17 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSimultaneousRingPersonalGetRequest17Async instead.")]
        public static async Task<UserSimultaneousRingPersonalGetResponse17> UserSimultaneousRingPersonalGetRequest17(this OcipClientBase client, UserSimultaneousRingPersonalGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSimultaneousRingPersonalGetResponse17;
        }

        /// <summary>
        /// Get the user's simultaneous ring personal service setting.
        /// The response is either a UserSimultaneousRingPersonalGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<UserSimultaneousRingPersonalGetResponse17> UserSimultaneousRingPersonalGetRequest17Async(this OcipClientBase client, UserSimultaneousRingPersonalGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSimultaneousRingPersonalGetResponse17;
        }
        /// <summary>
        /// Modify a criteria for the user's simultaneous ring personal service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSimultaneousRingPersonalModifyCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalModifyCriteriaRequest(this OcipClientBase client, UserSimultaneousRingPersonalModifyCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's simultaneous ring personal service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalModifyCriteriaRequestAsync(this OcipClientBase client, UserSimultaneousRingPersonalModifyCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's simultaneous ring personal service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSimultaneousRingPersonalModifyRequest17Async instead.")]
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalModifyRequest17(this OcipClientBase client, UserSimultaneousRingPersonalModifyRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's simultaneous ring personal service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalModifyRequest17Async(this OcipClientBase client, UserSimultaneousRingPersonalModifyRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
