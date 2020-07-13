using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSelectiveCallRejectionExtensions
    {

        /// <summary>
        /// Add a criteria to the user's selective call rejection service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallRejectionAddCriteriaRequest16Async instead.")]
        public static async Task<SuccessResponse> UserSelectiveCallRejectionAddCriteriaRequest16(this OcipClientBase client, UserSelectiveCallRejectionAddCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's selective call rejection service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallRejectionAddCriteriaRequest16Async(this OcipClientBase client, UserSelectiveCallRejectionAddCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a criteria from the user's selective call rejection service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallRejectionDeleteCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSelectiveCallRejectionDeleteCriteriaRequest(this OcipClientBase client, UserSelectiveCallRejectionDeleteCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's selective call rejection service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallRejectionDeleteCriteriaRequestAsync(this OcipClientBase client, UserSelectiveCallRejectionDeleteCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user's selective call rejection criteria listing.
        /// The response is either a UserSelectiveCallRejectionGetCriteriaListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallRejectionGetCriteriaListRequestAsync instead.")]
        public static async Task<UserSelectiveCallRejectionGetCriteriaListResponse> UserSelectiveCallRejectionGetCriteriaListRequest(this OcipClientBase client, UserSelectiveCallRejectionGetCriteriaListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSelectiveCallRejectionGetCriteriaListResponse;
        }

        /// <summary>
        /// Get the user's selective call rejection criteria listing.
        /// The response is either a UserSelectiveCallRejectionGetCriteriaListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSelectiveCallRejectionGetCriteriaListResponse> UserSelectiveCallRejectionGetCriteriaListRequestAsync(this OcipClientBase client, UserSelectiveCallRejectionGetCriteriaListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSelectiveCallRejectionGetCriteriaListResponse;
        }
        /// <summary>
        /// Get a criteria for the user's selective call rejection service.
        /// The response is either a UserSelectiveCallRejectionGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallRejectionGetCriteriaRequest21Async instead.")]
        public static async Task<UserSelectiveCallRejectionGetCriteriaResponse21> UserSelectiveCallRejectionGetCriteriaRequest21(this OcipClientBase client, UserSelectiveCallRejectionGetCriteriaRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSelectiveCallRejectionGetCriteriaResponse21;
        }

        /// <summary>
        /// Get a criteria for the user's selective call rejection service.
        /// The response is either a UserSelectiveCallRejectionGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<UserSelectiveCallRejectionGetCriteriaResponse21> UserSelectiveCallRejectionGetCriteriaRequest21Async(this OcipClientBase client, UserSelectiveCallRejectionGetCriteriaRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSelectiveCallRejectionGetCriteriaResponse21;
        }
        /// <summary>
        /// Activate the user's selective call rejection criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallRejectionModifyActiveCriteriaListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSelectiveCallRejectionModifyActiveCriteriaListRequest(this OcipClientBase client, UserSelectiveCallRejectionModifyActiveCriteriaListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Activate the user's selective call rejection criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallRejectionModifyActiveCriteriaListRequestAsync(this OcipClientBase client, UserSelectiveCallRejectionModifyActiveCriteriaListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a criteria for the user's selective call rejection service.
        /// The following elements are only used in AS data mode:
        /// callToNumberList
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallRejectionModifyCriteriaRequest16Async instead.")]
        public static async Task<SuccessResponse> UserSelectiveCallRejectionModifyCriteriaRequest16(this OcipClientBase client, UserSelectiveCallRejectionModifyCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's selective call rejection service.
        /// The following elements are only used in AS data mode:
        /// callToNumberList
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallRejectionModifyCriteriaRequest16Async(this OcipClientBase client, UserSelectiveCallRejectionModifyCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
