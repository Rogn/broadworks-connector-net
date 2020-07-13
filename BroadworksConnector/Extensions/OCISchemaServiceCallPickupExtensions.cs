using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallPickupExtensions
    {

        /// <summary>
        /// Adds a Call Pickup group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallPickupAddInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallPickupAddInstanceRequest(this OcipClientBase client, GroupCallPickupAddInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds a Call Pickup group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallPickupAddInstanceRequestAsync(this OcipClientBase client, GroupCallPickupAddInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes a Call Pickup group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallPickupDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallPickupDeleteInstanceRequest(this OcipClientBase client, GroupCallPickupDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a Call Pickup group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallPickupDeleteInstanceRequestAsync(this OcipClientBase client, GroupCallPickupDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned to a Call Pickup group.
        /// The available user list for a new Call Pickup group can be obtained
        /// by not setting the name.
        /// The response is either GroupCallPickupGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallPickupGetAvailableUserListRequestAsync instead.")]
        public static async Task<GroupCallPickupGetAvailableUserListResponse> GroupCallPickupGetAvailableUserListRequest(this OcipClientBase client, GroupCallPickupGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallPickupGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned to a Call Pickup group.
        /// The available user list for a new Call Pickup group can be obtained
        /// by not setting the name.
        /// The response is either GroupCallPickupGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallPickupGetAvailableUserListResponse> GroupCallPickupGetAvailableUserListRequestAsync(this OcipClientBase client, GroupCallPickupGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallPickupGetAvailableUserListResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned to a Call Pickup group.
        /// The available user list for a new Call Pickup group can be obtained
        /// by not setting the name.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either GroupCallPickupGetAvailableUserPagedSortedListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallPickupGetAvailableUserPagedSortedListRequestAsync instead.")]
        public static async Task<GroupCallPickupGetAvailableUserPagedSortedListResponse> GroupCallPickupGetAvailableUserPagedSortedListRequest(this OcipClientBase client, GroupCallPickupGetAvailableUserPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallPickupGetAvailableUserPagedSortedListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned to a Call Pickup group.
        /// The available user list for a new Call Pickup group can be obtained
        /// by not setting the name.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either GroupCallPickupGetAvailableUserPagedSortedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallPickupGetAvailableUserPagedSortedListResponse> GroupCallPickupGetAvailableUserPagedSortedListRequestAsync(this OcipClientBase client, GroupCallPickupGetAvailableUserPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallPickupGetAvailableUserPagedSortedListResponse;
        }
        /// <summary>
        /// Request to get a list of Call Pickup instances within a group.
        /// The response is either GroupCallPickupGetInstanceListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallPickupGetInstanceListRequestAsync instead.")]
        public static async Task<GroupCallPickupGetInstanceListResponse> GroupCallPickupGetInstanceListRequest(this OcipClientBase client, GroupCallPickupGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallPickupGetInstanceListResponse;
        }

        /// <summary>
        /// Request to get a list of Call Pickup instances within a group.
        /// The response is either GroupCallPickupGetInstanceListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallPickupGetInstanceListResponse> GroupCallPickupGetInstanceListRequestAsync(this OcipClientBase client, GroupCallPickupGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallPickupGetInstanceListResponse;
        }
        /// <summary>
        /// Request to get a list of Call Pickup instances within a group.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either GroupCallPickupGetInstancePagedSortedListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallPickupGetInstancePagedSortedListRequestAsync instead.")]
        public static async Task<GroupCallPickupGetInstancePagedSortedListResponse> GroupCallPickupGetInstancePagedSortedListRequest(this OcipClientBase client, GroupCallPickupGetInstancePagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallPickupGetInstancePagedSortedListResponse;
        }

        /// <summary>
        /// Request to get a list of Call Pickup instances within a group.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either GroupCallPickupGetInstancePagedSortedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallPickupGetInstancePagedSortedListResponse> GroupCallPickupGetInstancePagedSortedListRequestAsync(this OcipClientBase client, GroupCallPickupGetInstancePagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallPickupGetInstancePagedSortedListResponse;
        }
        /// <summary>
        /// Gets a Call Pickup group.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// The response is either GroupCallPickupGetInstancePagedSortedResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallPickupGetInstancePagedSortedRequestAsync instead.")]
        public static async Task<GroupCallPickupGetInstancePagedSortedResponse> GroupCallPickupGetInstancePagedSortedRequest(this OcipClientBase client, GroupCallPickupGetInstancePagedSortedRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallPickupGetInstancePagedSortedResponse;
        }

        /// <summary>
        /// Gets a Call Pickup group.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// The response is either GroupCallPickupGetInstancePagedSortedResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallPickupGetInstancePagedSortedResponse> GroupCallPickupGetInstancePagedSortedRequestAsync(this OcipClientBase client, GroupCallPickupGetInstancePagedSortedRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallPickupGetInstancePagedSortedResponse;
        }
        /// <summary>
        /// Gets a Call Pickup group.
        /// The response is either GroupCallPickupGetInstanceResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallPickupGetInstanceRequestAsync instead.")]
        public static async Task<GroupCallPickupGetInstanceResponse> GroupCallPickupGetInstanceRequest(this OcipClientBase client, GroupCallPickupGetInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallPickupGetInstanceResponse;
        }

        /// <summary>
        /// Gets a Call Pickup group.
        /// The response is either GroupCallPickupGetInstanceResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallPickupGetInstanceResponse> GroupCallPickupGetInstanceRequestAsync(this OcipClientBase client, GroupCallPickupGetInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallPickupGetInstanceResponse;
        }
        /// <summary>
        /// Modifies a Call Pickup group. Replaces the entire list of users in the group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallPickupModifyInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallPickupModifyInstanceRequest(this OcipClientBase client, GroupCallPickupModifyInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies a Call Pickup group. Replaces the entire list of users in the group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallPickupModifyInstanceRequestAsync(this OcipClientBase client, GroupCallPickupModifyInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Gets the details of the Call Pickup group that a user belongs to (if any).
        /// Any user can only belong to one Call Pickup group.
        /// The response is either UserCallPickupGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallPickupGetRequestAsync instead.")]
        public static async Task<UserCallPickupGetResponse> UserCallPickupGetRequest(this OcipClientBase client, UserCallPickupGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallPickupGetResponse;
        }

        /// <summary>
        /// Gets the details of the Call Pickup group that a user belongs to (if any).
        /// Any user can only belong to one Call Pickup group.
        /// The response is either UserCallPickupGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserCallPickupGetResponse> UserCallPickupGetRequestAsync(this OcipClientBase client, UserCallPickupGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallPickupGetResponse;
        }

    }
}
