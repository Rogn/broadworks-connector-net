using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSelectiveCallAcceptanceExtensions
    {

        /// <summary>
        /// Add a criteria to the user's selective call acceptance service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallAcceptanceAddCriteriaRequest16Async instead.")]
        public static async Task<SuccessResponse> UserSelectiveCallAcceptanceAddCriteriaRequest16(this OcipClientBase client, UserSelectiveCallAcceptanceAddCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's selective call acceptance service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallAcceptanceAddCriteriaRequest16Async(this OcipClientBase client, UserSelectiveCallAcceptanceAddCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a criteria from the user's selective call acceptance service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallAcceptanceDeleteCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSelectiveCallAcceptanceDeleteCriteriaRequest(this OcipClientBase client, UserSelectiveCallAcceptanceDeleteCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's selective call acceptance service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallAcceptanceDeleteCriteriaRequestAsync(this OcipClientBase client, UserSelectiveCallAcceptanceDeleteCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user's selective call acceptance criteria listing.
        /// The response is either a UserSelectiveCallAcceptanceGetCriteriaListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallAcceptanceGetCriteriaListRequestAsync instead.")]
        public static async Task<UserSelectiveCallAcceptanceGetCriteriaListResponse> UserSelectiveCallAcceptanceGetCriteriaListRequest(this OcipClientBase client, UserSelectiveCallAcceptanceGetCriteriaListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSelectiveCallAcceptanceGetCriteriaListResponse;
        }

        /// <summary>
        /// Get the user's selective call acceptance criteria listing.
        /// The response is either a UserSelectiveCallAcceptanceGetCriteriaListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSelectiveCallAcceptanceGetCriteriaListResponse> UserSelectiveCallAcceptanceGetCriteriaListRequestAsync(this OcipClientBase client, UserSelectiveCallAcceptanceGetCriteriaListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSelectiveCallAcceptanceGetCriteriaListResponse;
        }
        /// <summary>
        /// Get a criteria for the user's selective call acceptance service.
        /// The response is either a UserSelectiveCallAcceptanceGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallAcceptanceGetCriteriaRequest21Async instead.")]
        public static async Task<UserSelectiveCallAcceptanceGetCriteriaResponse21> UserSelectiveCallAcceptanceGetCriteriaRequest21(this OcipClientBase client, UserSelectiveCallAcceptanceGetCriteriaRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSelectiveCallAcceptanceGetCriteriaResponse21;
        }

        /// <summary>
        /// Get a criteria for the user's selective call acceptance service.
        /// The response is either a UserSelectiveCallAcceptanceGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<UserSelectiveCallAcceptanceGetCriteriaResponse21> UserSelectiveCallAcceptanceGetCriteriaRequest21Async(this OcipClientBase client, UserSelectiveCallAcceptanceGetCriteriaRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSelectiveCallAcceptanceGetCriteriaResponse21;
        }
        /// <summary>
        /// Activate the user's selective call acceptance criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallAcceptanceModifyActiveCriteriaListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSelectiveCallAcceptanceModifyActiveCriteriaListRequest(this OcipClientBase client, UserSelectiveCallAcceptanceModifyActiveCriteriaListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Activate the user's selective call acceptance criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallAcceptanceModifyActiveCriteriaListRequestAsync(this OcipClientBase client, UserSelectiveCallAcceptanceModifyActiveCriteriaListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a criteria for the user's selective call acceptance service.
        /// The following elements are only used in AS data mode:
        /// callToNumberList
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallAcceptanceModifyCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSelectiveCallAcceptanceModifyCriteriaRequest(this OcipClientBase client, UserSelectiveCallAcceptanceModifyCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's selective call acceptance service.
        /// The following elements are only used in AS data mode:
        /// callToNumberList
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallAcceptanceModifyCriteriaRequestAsync(this OcipClientBase client, UserSelectiveCallAcceptanceModifyCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
