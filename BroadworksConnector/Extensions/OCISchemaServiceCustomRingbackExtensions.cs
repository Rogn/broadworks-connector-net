using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCustomRingbackExtensions
    {

        /// <summary>
        /// Get the group's custom ring back service settings.
        /// The response is either a GroupCustomRingbackGroupGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCustomRingbackGroupGetRequest20Async instead.")]
        public static async Task<GroupCustomRingbackGroupGetResponse20> GroupCustomRingbackGroupGetRequest20(this OcipClientBase client, GroupCustomRingbackGroupGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCustomRingbackGroupGetResponse20;
        }

        /// <summary>
        /// Get the group's custom ring back service settings.
        /// The response is either a GroupCustomRingbackGroupGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCustomRingbackGroupGetResponse20> GroupCustomRingbackGroupGetRequest20Async(this OcipClientBase client, GroupCustomRingbackGroupGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCustomRingbackGroupGetResponse20;
        }
        /// <summary>
        /// Modify the group's custom ring back service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCustomRingbackGroupModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupCustomRingbackGroupModifyRequest20(this OcipClientBase client, GroupCustomRingbackGroupModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's custom ring back service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCustomRingbackGroupModifyRequest20Async(this OcipClientBase client, GroupCustomRingbackGroupModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a criteria to the user's custom ringback service.
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCustomRingbackUserAddCriteriaRequest20Async instead.")]
        public static async Task<SuccessResponse> UserCustomRingbackUserAddCriteriaRequest20(this OcipClientBase client, UserCustomRingbackUserAddCriteriaRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's custom ringback service.
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCustomRingbackUserAddCriteriaRequest20Async(this OcipClientBase client, UserCustomRingbackUserAddCriteriaRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a criteria from the user's custom ringback service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCustomRingbackUserDeleteCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCustomRingbackUserDeleteCriteriaRequest(this OcipClientBase client, UserCustomRingbackUserDeleteCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's custom ringback service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCustomRingbackUserDeleteCriteriaRequestAsync(this OcipClientBase client, UserCustomRingbackUserDeleteCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user's custom ringback service criteria listing.
        /// The response is either a UserCustomRingbackUserGetCriteriaListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCustomRingbackUserGetCriteriaListRequestAsync instead.")]
        public static async Task<UserCustomRingbackUserGetCriteriaListResponse> UserCustomRingbackUserGetCriteriaListRequest(this OcipClientBase client, UserCustomRingbackUserGetCriteriaListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCustomRingbackUserGetCriteriaListResponse;
        }

        /// <summary>
        /// Get the user's custom ringback service criteria listing.
        /// The response is either a UserCustomRingbackUserGetCriteriaListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCustomRingbackUserGetCriteriaListResponse> UserCustomRingbackUserGetCriteriaListRequestAsync(this OcipClientBase client, UserCustomRingbackUserGetCriteriaListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCustomRingbackUserGetCriteriaListResponse;
        }
        /// <summary>
        /// Get a criteria for the user's custom ringback service.
        /// The response is either a UserCustomRingbackUserGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCustomRingbackUserGetCriteriaRequest21Async instead.")]
        public static async Task<UserCustomRingbackUserGetCriteriaResponse21> UserCustomRingbackUserGetCriteriaRequest21(this OcipClientBase client, UserCustomRingbackUserGetCriteriaRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCustomRingbackUserGetCriteriaResponse21;
        }

        /// <summary>
        /// Get a criteria for the user's custom ringback service.
        /// The response is either a UserCustomRingbackUserGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<UserCustomRingbackUserGetCriteriaResponse21> UserCustomRingbackUserGetCriteriaRequest21Async(this OcipClientBase client, UserCustomRingbackUserGetCriteriaRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCustomRingbackUserGetCriteriaResponse21;
        }
        /// <summary>
        /// Modify the user's custom ringback service criteria's active setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCustomRingbackUserModifyActiveCriteriaListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCustomRingbackUserModifyActiveCriteriaListRequest(this OcipClientBase client, UserCustomRingbackUserModifyActiveCriteriaListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's custom ringback service criteria's active setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCustomRingbackUserModifyActiveCriteriaListRequestAsync(this OcipClientBase client, UserCustomRingbackUserModifyActiveCriteriaListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a criteria for the user's custom ringback service.
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCustomRingbackUserModifyCriteriaRequest20Async instead.")]
        public static async Task<SuccessResponse> UserCustomRingbackUserModifyCriteriaRequest20(this OcipClientBase client, UserCustomRingbackUserModifyCriteriaRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's custom ringback service.
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCustomRingbackUserModifyCriteriaRequest20Async(this OcipClientBase client, UserCustomRingbackUserModifyCriteriaRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
