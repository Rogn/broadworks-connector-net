using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceIncomingCallingPlanExtensions
    {

        /// <summary>
        /// Request the group's incoming calling plan settings.
        /// The response is either a GroupIncomingCallingPlanGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupIncomingCallingPlanGetListRequestAsync instead.")]
        public static async Task<GroupIncomingCallingPlanGetListResponse> GroupIncomingCallingPlanGetListRequest(this OcipClientBase client, GroupIncomingCallingPlanGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupIncomingCallingPlanGetListResponse;
        }

        /// <summary>
        /// Request the group's incoming calling plan settings.
        /// The response is either a GroupIncomingCallingPlanGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupIncomingCallingPlanGetListResponse> GroupIncomingCallingPlanGetListRequestAsync(this OcipClientBase client, GroupIncomingCallingPlanGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupIncomingCallingPlanGetListResponse;
        }
        /// <summary>
        /// Change the group's incoming calling plan settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupIncomingCallingPlanModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupIncomingCallingPlanModifyListRequest(this OcipClientBase client, GroupIncomingCallingPlanModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Change the group's incoming calling plan settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupIncomingCallingPlanModifyListRequestAsync(this OcipClientBase client, GroupIncomingCallingPlanModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user's incoming calling plan settings.
        /// The response is either a UserIncomingCallingPlanGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserIncomingCallingPlanGetRequestAsync instead.")]
        public static async Task<UserIncomingCallingPlanGetResponse> UserIncomingCallingPlanGetRequest(this OcipClientBase client, UserIncomingCallingPlanGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserIncomingCallingPlanGetResponse;
        }

        /// <summary>
        /// Request the user's incoming calling plan settings.
        /// The response is either a UserIncomingCallingPlanGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserIncomingCallingPlanGetResponse> UserIncomingCallingPlanGetRequestAsync(this OcipClientBase client, UserIncomingCallingPlanGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserIncomingCallingPlanGetResponse;
        }
        /// <summary>
        /// Change the user's incoming calling plan settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserIncomingCallingPlanModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserIncomingCallingPlanModifyRequest(this OcipClientBase client, UserIncomingCallingPlanModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Change the user's incoming calling plan settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserIncomingCallingPlanModifyRequestAsync(this OcipClientBase client, UserIncomingCallingPlanModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
