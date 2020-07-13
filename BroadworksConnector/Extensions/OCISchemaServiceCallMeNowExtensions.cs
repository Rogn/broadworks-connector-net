using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallMeNowExtensions
    {

        /// <summary>
        /// Request the system level data associated with Call Me Now service.
        /// The response is either a SystemCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallMeNowGetRequestAsync instead.")]
        public static async Task<SystemCallMeNowGetResponse> SystemCallMeNowGetRequest(this OcipClientBase client, SystemCallMeNowGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallMeNowGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Call Me Now service.
        /// The response is either a SystemCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallMeNowGetResponse> SystemCallMeNowGetRequestAsync(this OcipClientBase client, SystemCallMeNowGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallMeNowGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Call me now service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallMeNowModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallMeNowModifyRequest(this OcipClientBase client, SystemCallMeNowModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Call me now service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallMeNowModifyRequestAsync(this OcipClientBase client, SystemCallMeNowModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a criterion to the user's call me now service.  The criterion added is automatically active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallMeNowAddCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallMeNowAddCriteriaRequest(this OcipClientBase client, UserCallMeNowAddCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a criterion to the user's call me now service.  The criterion added is automatically active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallMeNowAddCriteriaRequestAsync(this OcipClientBase client, UserCallMeNowAddCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a criteria from the user's call me now service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallMeNowDeleteCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallMeNowDeleteCriteriaRequest(this OcipClientBase client, UserCallMeNowDeleteCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's call me now service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallMeNowDeleteCriteriaRequestAsync(this OcipClientBase client, UserCallMeNowDeleteCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a criteria for the user's call me now service.
        /// The response is either a UserCallMeNowGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallMeNowGetCriteriaRequestAsync instead.")]
        public static async Task<UserCallMeNowGetCriteriaResponse> UserCallMeNowGetCriteriaRequest(this OcipClientBase client, UserCallMeNowGetCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallMeNowGetCriteriaResponse;
        }

        /// <summary>
        /// Get a criteria for the user's call me now service.
        /// The response is either a UserCallMeNowGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallMeNowGetCriteriaResponse> UserCallMeNowGetCriteriaRequestAsync(this OcipClientBase client, UserCallMeNowGetCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallMeNowGetCriteriaResponse;
        }
        /// <summary>
        /// Get the user's call me now service setting.
        /// The response is either a UserCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallMeNowGetRequestAsync instead.")]
        public static async Task<UserCallMeNowGetResponse> UserCallMeNowGetRequest(this OcipClientBase client, UserCallMeNowGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallMeNowGetResponse;
        }

        /// <summary>
        /// Get the user's call me now service setting.
        /// The response is either a UserCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallMeNowGetResponse> UserCallMeNowGetRequestAsync(this OcipClientBase client, UserCallMeNowGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallMeNowGetResponse;
        }
        /// <summary>
        /// Modify a criteria for the user's call me now service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallMeNowModifyCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallMeNowModifyCriteriaRequest(this OcipClientBase client, UserCallMeNowModifyCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's call me now service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallMeNowModifyCriteriaRequestAsync(this OcipClientBase client, UserCallMeNowModifyCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's call me now service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallMeNowModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallMeNowModifyRequest(this OcipClientBase client, UserCallMeNowModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's call me now service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallMeNowModifyRequestAsync(this OcipClientBase client, UserCallMeNowModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
