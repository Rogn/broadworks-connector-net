using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServicePersonalAssistantExtensions
    {

        /// <summary>
        /// Get system Personal Assistant Parameters.
        /// The response is either SystemPersonalAssistantGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPersonalAssistantGetRequestAsync instead.")]
        public static async Task<SystemPersonalAssistantGetResponse> SystemPersonalAssistantGetRequest(this OcipClientBase client, SystemPersonalAssistantGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPersonalAssistantGetResponse;
        }

        /// <summary>
        /// Get system Personal Assistant Parameters.
        /// The response is either SystemPersonalAssistantGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemPersonalAssistantGetResponse> SystemPersonalAssistantGetRequestAsync(this OcipClientBase client, SystemPersonalAssistantGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPersonalAssistantGetResponse;
        }
        /// <summary>
        /// Modify system Personal Assistant Parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPersonalAssistantModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPersonalAssistantModifyRequest(this OcipClientBase client, SystemPersonalAssistantModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify system Personal Assistant Parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPersonalAssistantModifyRequestAsync(this OcipClientBase client, SystemPersonalAssistantModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the user available Call to Number List information. The response is either a UserCallToNumberGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallToNumberGetAvailableListRequestAsync instead.")]
        public static async Task<UserCallToNumberGetAvailableListResponse> UserCallToNumberGetAvailableListRequest(this OcipClientBase client, UserCallToNumberGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallToNumberGetAvailableListResponse;
        }

        /// <summary>
        /// Request to get the user available Call to Number List information. The response is either a UserCallToNumberGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallToNumberGetAvailableListResponse> UserCallToNumberGetAvailableListRequestAsync(this OcipClientBase client, UserCallToNumberGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallToNumberGetAvailableListResponse;
        }
        /// <summary>
        /// Request to get the user assigned Call to Number List information. The response is either a UserPersonalAssistantCallToNumberGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalAssistantCallToNumberGetListRequestAsync instead.")]
        public static async Task<UserPersonalAssistantCallToNumberGetListResponse> UserPersonalAssistantCallToNumberGetListRequest(this OcipClientBase client, UserPersonalAssistantCallToNumberGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPersonalAssistantCallToNumberGetListResponse;
        }

        /// <summary>
        /// Request to get the user assigned Call to Number List information. The response is either a UserPersonalAssistantCallToNumberGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPersonalAssistantCallToNumberGetListResponse> UserPersonalAssistantCallToNumberGetListRequestAsync(this OcipClientBase client, UserPersonalAssistantCallToNumberGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPersonalAssistantCallToNumberGetListResponse;
        }
        /// <summary>
        /// Request to modify the user assigned Call to Number List information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// For the callToNumbers in the callToNumberList, the extension element
        /// is not used and the number element is only used when the type is BroadWorks Mobility.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalAssistantCallToNumberModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPersonalAssistantCallToNumberModifyListRequest(this OcipClientBase client, UserPersonalAssistantCallToNumberModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the user assigned Call to Number List information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// For the callToNumbers in the callToNumberList, the extension element
        /// is not used and the number element is only used when the type is BroadWorks Mobility.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalAssistantCallToNumberModifyListRequestAsync(this OcipClientBase client, UserPersonalAssistantCallToNumberModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a User Personal Assistant Exclusion Number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalAssistantExclusionNumberAddRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPersonalAssistantExclusionNumberAddRequest(this OcipClientBase client, UserPersonalAssistantExclusionNumberAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a User Personal Assistant Exclusion Number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalAssistantExclusionNumberAddRequestAsync(this OcipClientBase client, UserPersonalAssistantExclusionNumberAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of User Personal Assistant Exclusion Number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalAssistantExclusionNumberDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPersonalAssistantExclusionNumberDeleteListRequest(this OcipClientBase client, UserPersonalAssistantExclusionNumberDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of User Personal Assistant Exclusion Number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalAssistantExclusionNumberDeleteListRequestAsync(this OcipClientBase client, UserPersonalAssistantExclusionNumberDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the User Personal Assistant Exclusion Number List information.
        /// The response is either a UserPersonalAssistantExclusionNumberGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalAssistantExclusionNumberGetListRequestAsync instead.")]
        public static async Task<UserPersonalAssistantExclusionNumberGetListResponse> UserPersonalAssistantExclusionNumberGetListRequest(this OcipClientBase client, UserPersonalAssistantExclusionNumberGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPersonalAssistantExclusionNumberGetListResponse;
        }

        /// <summary>
        /// Request to get the User Personal Assistant Exclusion Number List information.
        /// The response is either a UserPersonalAssistantExclusionNumberGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPersonalAssistantExclusionNumberGetListResponse> UserPersonalAssistantExclusionNumberGetListRequestAsync(this OcipClientBase client, UserPersonalAssistantExclusionNumberGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPersonalAssistantExclusionNumberGetListResponse;
        }
        /// <summary>
        /// Get a Personal Assistant Exclusion Number.
        /// The response is either UserPersonalAssistantExclusionNumberGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalAssistantExclusionNumberGetRequestAsync instead.")]
        public static async Task<UserPersonalAssistantExclusionNumberGetResponse> UserPersonalAssistantExclusionNumberGetRequest(this OcipClientBase client, UserPersonalAssistantExclusionNumberGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPersonalAssistantExclusionNumberGetResponse;
        }

        /// <summary>
        /// Get a Personal Assistant Exclusion Number.
        /// The response is either UserPersonalAssistantExclusionNumberGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserPersonalAssistantExclusionNumberGetResponse> UserPersonalAssistantExclusionNumberGetRequestAsync(this OcipClientBase client, UserPersonalAssistantExclusionNumberGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPersonalAssistantExclusionNumberGetResponse;
        }
        /// <summary>
        /// Modify an existing User Personal Assistant Exclusion Number description.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalAssistantExclusionNumberModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPersonalAssistantExclusionNumberModifyRequest(this OcipClientBase client, UserPersonalAssistantExclusionNumberModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing User Personal Assistant Exclusion Number description.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalAssistantExclusionNumberModifyRequestAsync(this OcipClientBase client, UserPersonalAssistantExclusionNumberModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the User Personal Assistant information.
        /// The response is either a UserPersonalAssistantGetResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalAssistantGetRequest22Async instead.")]
        public static async Task<UserPersonalAssistantGetResponse22> UserPersonalAssistantGetRequest22(this OcipClientBase client, UserPersonalAssistantGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPersonalAssistantGetResponse22;
        }

        /// <summary>
        /// Request to get the User Personal Assistant information.
        /// The response is either a UserPersonalAssistantGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<UserPersonalAssistantGetResponse22> UserPersonalAssistantGetRequest22Async(this OcipClientBase client, UserPersonalAssistantGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPersonalAssistantGetResponse22;
        }
        /// <summary>
        /// Modify the User Personal Assistant information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPersonalAssistantModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPersonalAssistantModifyRequest(this OcipClientBase client, UserPersonalAssistantModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the User Personal Assistant information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPersonalAssistantModifyRequestAsync(this OcipClientBase client, UserPersonalAssistantModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
