using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceGroupPagingExtensions
    {

        /// <summary>
        /// Add a Group Paging instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingAddInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupPagingAddInstanceRequest(this OcipClientBase client, GroupGroupPagingAddInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Group Paging instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingAddInstanceRequestAsync(this OcipClientBase client, GroupGroupPagingAddInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add originator(s) to a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingAddOriginatorListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupPagingAddOriginatorListRequest(this OcipClientBase client, GroupGroupPagingAddOriginatorListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add originator(s) to a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingAddOriginatorListRequestAsync(this OcipClientBase client, GroupGroupPagingAddOriginatorListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add target(s) to a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingAddTargetListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupPagingAddTargetListRequest(this OcipClientBase client, GroupGroupPagingAddTargetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add target(s) to a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingAddTargetListRequestAsync(this OcipClientBase client, GroupGroupPagingAddTargetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Group Paging instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupPagingDeleteInstanceRequest(this OcipClientBase client, GroupGroupPagingDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Group Paging instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingDeleteInstanceRequestAsync(this OcipClientBase client, GroupGroupPagingDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete originator(s) from a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingDeleteOriginatorListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupPagingDeleteOriginatorListRequest(this OcipClientBase client, GroupGroupPagingDeleteOriginatorListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete originator(s) from a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingDeleteOriginatorListRequestAsync(this OcipClientBase client, GroupGroupPagingDeleteOriginatorListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete target(s) from a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingDeleteTargetListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupPagingDeleteTargetListRequest(this OcipClientBase client, GroupGroupPagingDeleteTargetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete target(s) from a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingDeleteTargetListRequestAsync(this OcipClientBase client, GroupGroupPagingDeleteTargetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned as originators to a given paging group.
        /// Searching for users by group only makes sense when the paging group is part of an Enterprise.
        /// The response is either GroupGroupPagingGetAvailableOriginatorListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingGetAvailableOriginatorListRequestAsync instead.")]
        public static async Task<GroupGroupPagingGetAvailableOriginatorListResponse> GroupGroupPagingGetAvailableOriginatorListRequest(this OcipClientBase client, GroupGroupPagingGetAvailableOriginatorListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGroupPagingGetAvailableOriginatorListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned as originators to a given paging group.
        /// Searching for users by group only makes sense when the paging group is part of an Enterprise.
        /// The response is either GroupGroupPagingGetAvailableOriginatorListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingGetAvailableOriginatorListResponse> GroupGroupPagingGetAvailableOriginatorListRequestAsync(this OcipClientBase client, GroupGroupPagingGetAvailableOriginatorListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGroupPagingGetAvailableOriginatorListResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned as targets to a given paging group.
        /// Searching for users by group only makes sense when the paging group is part of an Enterprise.
        /// The response is either GroupGroupPagingGetAvailableTargetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingGetAvailableTargetListRequestAsync instead.")]
        public static async Task<GroupGroupPagingGetAvailableTargetListResponse> GroupGroupPagingGetAvailableTargetListRequest(this OcipClientBase client, GroupGroupPagingGetAvailableTargetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGroupPagingGetAvailableTargetListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned as targets to a given paging group.
        /// Searching for users by group only makes sense when the paging group is part of an Enterprise.
        /// The response is either GroupGroupPagingGetAvailableTargetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingGetAvailableTargetListResponse> GroupGroupPagingGetAvailableTargetListRequestAsync(this OcipClientBase client, GroupGroupPagingGetAvailableTargetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGroupPagingGetAvailableTargetListResponse;
        }
        /// <summary>
        /// Get a list of Paging Groups instances within a group.
        /// The response is either GroupGroupPagingGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingGetInstanceListRequestAsync instead.")]
        public static async Task<GroupGroupPagingGetInstanceListResponse> GroupGroupPagingGetInstanceListRequest(this OcipClientBase client, GroupGroupPagingGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGroupPagingGetInstanceListResponse;
        }

        /// <summary>
        /// Get a list of Paging Groups instances within a group.
        /// The response is either GroupGroupPagingGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupGroupPagingGetInstanceListResponse> GroupGroupPagingGetInstanceListRequestAsync(this OcipClientBase client, GroupGroupPagingGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGroupPagingGetInstanceListResponse;
        }
        /// <summary>
        /// Request to get all the information of a Group Paging instance.
        /// The response is either GroupGroupPagingGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingGetInstanceRequest19sp1Async instead.")]
        public static async Task<GroupGroupPagingGetInstanceResponse19sp1> GroupGroupPagingGetInstanceRequest19sp1(this OcipClientBase client, GroupGroupPagingGetInstanceRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGroupPagingGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a Group Paging instance.
        /// The response is either GroupGroupPagingGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingGetInstanceResponse19sp1> GroupGroupPagingGetInstanceRequest19sp1Async(this OcipClientBase client, GroupGroupPagingGetInstanceRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGroupPagingGetInstanceResponse19sp1;
        }
        /// <summary>
        /// Get a list of originators assigned to a paging group.
        /// The response is either a GroupGroupPagingGetOriginatorListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingGetOriginatorListRequestAsync instead.")]
        public static async Task<GroupGroupPagingGetOriginatorListResponse> GroupGroupPagingGetOriginatorListRequest(this OcipClientBase client, GroupGroupPagingGetOriginatorListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGroupPagingGetOriginatorListResponse;
        }

        /// <summary>
        /// Get a list of originators assigned to a paging group.
        /// The response is either a GroupGroupPagingGetOriginatorListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingGetOriginatorListResponse> GroupGroupPagingGetOriginatorListRequestAsync(this OcipClientBase client, GroupGroupPagingGetOriginatorListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGroupPagingGetOriginatorListResponse;
        }
        /// <summary>
        /// Get a list of targets assigned to a paging group.
        /// The response is either a GroupGroupPagingGetTargetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingGetTargetListRequestAsync instead.")]
        public static async Task<GroupGroupPagingGetTargetListResponse> GroupGroupPagingGetTargetListRequest(this OcipClientBase client, GroupGroupPagingGetTargetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGroupPagingGetTargetListResponse;
        }

        /// <summary>
        /// Get a list of targets assigned to a paging group.
        /// The response is either a GroupGroupPagingGetTargetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingGetTargetListResponse> GroupGroupPagingGetTargetListRequestAsync(this OcipClientBase client, GroupGroupPagingGetTargetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGroupPagingGetTargetListResponse;
        }
        /// <summary>
        /// Request to set the active status of Group Paging instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingModifyActiveInstanceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupPagingModifyActiveInstanceListRequest(this OcipClientBase client, GroupGroupPagingModifyActiveInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of Group Paging instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingModifyActiveInstanceListRequestAsync(this OcipClientBase client, GroupGroupPagingModifyActiveInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a Group Paging instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingModifyInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupPagingModifyInstanceRequest(this OcipClientBase client, GroupGroupPagingModifyInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Group Paging instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingModifyInstanceRequestAsync(this OcipClientBase client, GroupGroupPagingModifyInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify the originator list for a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingModifyOriginatorListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupPagingModifyOriginatorListRequest(this OcipClientBase client, GroupGroupPagingModifyOriginatorListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the originator list for a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingModifyOriginatorListRequestAsync(this OcipClientBase client, GroupGroupPagingModifyOriginatorListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify the target list for a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingModifyTargetListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupPagingModifyTargetListRequest(this OcipClientBase client, GroupGroupPagingModifyTargetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the target list for a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingModifyTargetListRequestAsync(this OcipClientBase client, GroupGroupPagingModifyTargetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the maximum number of target users per paging group configured for a group.
        /// The response is either a GroupGroupPagingTargetsCapacityGetResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingTargetsCapacityGetRequestAsync instead.")]
        public static async Task<GroupGroupPagingTargetsCapacityGetResponse> GroupGroupPagingTargetsCapacityGetRequest(this OcipClientBase client, GroupGroupPagingTargetsCapacityGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGroupPagingTargetsCapacityGetResponse;
        }

        /// <summary>
        /// Request the maximum number of target users per paging group configured for a group.
        /// The response is either a GroupGroupPagingTargetsCapacityGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingTargetsCapacityGetResponse> GroupGroupPagingTargetsCapacityGetRequestAsync(this OcipClientBase client, GroupGroupPagingTargetsCapacityGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGroupPagingTargetsCapacityGetResponse;
        }
        /// <summary>
        /// Modify the maximum number of target users per paging group configured for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingTargetsCapacityModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupPagingTargetsCapacityModifyRequest(this OcipClientBase client, GroupGroupPagingTargetsCapacityModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the maximum number of target users per paging group configured for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingTargetsCapacityModifyRequestAsync(this OcipClientBase client, GroupGroupPagingTargetsCapacityModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the maximum number of target users per paging group configured for a service provider.
        /// The response is either a ServiceProviderGroupPagingTargetsCapacityGetResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderGroupPagingTargetsCapacityGetRequestAsync instead.")]
        public static async Task<ServiceProviderGroupPagingTargetsCapacityGetResponse> ServiceProviderGroupPagingTargetsCapacityGetRequest(this OcipClientBase client, ServiceProviderGroupPagingTargetsCapacityGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderGroupPagingTargetsCapacityGetResponse;
        }

        /// <summary>
        /// Request the maximum number of target users per paging group configured for a service provider.
        /// The response is either a ServiceProviderGroupPagingTargetsCapacityGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderGroupPagingTargetsCapacityGetResponse> ServiceProviderGroupPagingTargetsCapacityGetRequestAsync(this OcipClientBase client, ServiceProviderGroupPagingTargetsCapacityGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderGroupPagingTargetsCapacityGetResponse;
        }
        /// <summary>
        /// Modify the maximum number of target users per paging group configured for a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderGroupPagingTargetsCapacityModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderGroupPagingTargetsCapacityModifyRequest(this OcipClientBase client, ServiceProviderGroupPagingTargetsCapacityModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the maximum number of target users per paging group configured for a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderGroupPagingTargetsCapacityModifyRequestAsync(this OcipClientBase client, ServiceProviderGroupPagingTargetsCapacityModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all the Paging Groups a user was assigned as an originator.
        /// The response is either a UserGroupPagingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGroupPagingGetListRequestAsync instead.")]
        public static async Task<UserGroupPagingGetListResponse> UserGroupPagingGetListRequest(this OcipClientBase client, UserGroupPagingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGroupPagingGetListResponse;
        }

        /// <summary>
        /// Get the list of all the Paging Groups a user was assigned as an originator.
        /// The response is either a UserGroupPagingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserGroupPagingGetListResponse> UserGroupPagingGetListRequestAsync(this OcipClientBase client, UserGroupPagingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGroupPagingGetListResponse;
        }

    }
}
