using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceTrunkGroupExtensions
    {

        /// <summary>
        /// Request to add an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkAddRequest21Async instead.")]
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkAddRequest21(this OcipClientBase client, EnterpriseEnterpriseTrunkAddRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkAddRequest21Async(this OcipClientBase client, EnterpriseEnterpriseTrunkAddRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add users to an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkAddUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkAddUserListRequest(this OcipClientBase client, EnterpriseEnterpriseTrunkAddUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add users to an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkAddUserListRequestAsync(this OcipClientBase client, EnterpriseEnterpriseTrunkAddUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkDeleteRequest(this OcipClientBase client, EnterpriseEnterpriseTrunkDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkDeleteRequestAsync(this OcipClientBase client, EnterpriseEnterpriseTrunkDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete users from an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkDeleteUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkDeleteUserListRequest(this OcipClientBase client, EnterpriseEnterpriseTrunkDeleteUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete users from an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkDeleteUserListRequestAsync(this OcipClientBase client, EnterpriseEnterpriseTrunkDeleteUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add users to an enterprise trunk in an enterprise. If the user is already assigned to another enterprise trunk,
        /// it will be unassigned from the old enterprise trunk and assigned to the new enterprise trunk specified in this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkForceAssignUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkForceAssignUserListRequest(this OcipClientBase client, EnterpriseEnterpriseTrunkForceAssignUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add users to an enterprise trunk in an enterprise. If the user is already assigned to another enterprise trunk,
        /// it will be unassigned from the old enterprise trunk and assigned to the new enterprise trunk specified in this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkForceAssignUserListRequestAsync(this OcipClientBase client, EnterpriseEnterpriseTrunkForceAssignUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of all available trunk groups defined in an enterprise.  It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListRequestAsync instead.")]
        public static async Task<EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse> EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListRequest(this OcipClientBase client, EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse;
        }

        /// <summary>
        /// Request to get the list of all available trunk groups defined in an enterprise.  It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse> EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListRequestAsync(this OcipClientBase client, EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse;
        }
        /// <summary>
        /// Request the list of users that are available to be added to an enterprise trunk.  This list contains users in the enterprise that are trunk users and not already assigned to an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either an EnterpriseEnterpriseTrunkGetAvailableUserListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkGetAvailableUserListRequestAsync instead.")]
        public static async Task<EnterpriseEnterpriseTrunkGetAvailableUserListResponse> EnterpriseEnterpriseTrunkGetAvailableUserListRequest(this OcipClientBase client, EnterpriseEnterpriseTrunkGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request the list of users that are available to be added to an enterprise trunk.  This list contains users in the enterprise that are trunk users and not already assigned to an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either an EnterpriseEnterpriseTrunkGetAvailableUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetAvailableUserListResponse> EnterpriseEnterpriseTrunkGetAvailableUserListRequestAsync(this OcipClientBase client, EnterpriseEnterpriseTrunkGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request to get the list of all enterprise trunks defined in an enterprise.
        /// The response is either a EnterpriseEnterpriseTrunkGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkGetListRequestAsync instead.")]
        public static async Task<EnterpriseEnterpriseTrunkGetListResponse> EnterpriseEnterpriseTrunkGetListRequest(this OcipClientBase client, EnterpriseEnterpriseTrunkGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetListResponse;
        }

        /// <summary>
        /// Request to get the list of all enterprise trunks defined in an enterprise.
        /// The response is either a EnterpriseEnterpriseTrunkGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetListResponse> EnterpriseEnterpriseTrunkGetListRequestAsync(this OcipClientBase client, EnterpriseEnterpriseTrunkGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetListResponse;
        }
        /// <summary>
        /// Request to get an enterprise trunk
        /// The response is either an EnterpriseEnterpriseTrunkGetResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkGetRequest21Async instead.")]
        public static async Task<EnterpriseEnterpriseTrunkGetResponse21> EnterpriseEnterpriseTrunkGetRequest21(this OcipClientBase client, EnterpriseEnterpriseTrunkGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetResponse21;
        }

        /// <summary>
        /// Request to get an enterprise trunk
        /// The response is either an EnterpriseEnterpriseTrunkGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetResponse21> EnterpriseEnterpriseTrunkGetRequest21Async(this OcipClientBase client, EnterpriseEnterpriseTrunkGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetResponse21;
        }
        /// <summary>
        /// Request the list of users in an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a EnterpriseEnterpriseTrunkGetUserListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkGetUserListRequestAsync instead.")]
        public static async Task<EnterpriseEnterpriseTrunkGetUserListResponse> EnterpriseEnterpriseTrunkGetUserListRequest(this OcipClientBase client, EnterpriseEnterpriseTrunkGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetUserListResponse;
        }

        /// <summary>
        /// Request the list of users in an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a EnterpriseEnterpriseTrunkGetUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetUserListResponse> EnterpriseEnterpriseTrunkGetUserListRequestAsync(this OcipClientBase client, EnterpriseEnterpriseTrunkGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetUserListResponse;
        }
        /// <summary>
        /// Request to modify an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkModifyRequest(this OcipClientBase client, EnterpriseEnterpriseTrunkModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkModifyRequestAsync(this OcipClientBase client, EnterpriseEnterpriseTrunkModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkAddRequest21Async instead.")]
        public static async Task<SuccessResponse> GroupEnterpriseTrunkAddRequest21(this OcipClientBase client, GroupEnterpriseTrunkAddRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkAddRequest21Async(this OcipClientBase client, GroupEnterpriseTrunkAddRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add users to an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkAddUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEnterpriseTrunkAddUserListRequest(this OcipClientBase client, GroupEnterpriseTrunkAddUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add users to an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkAddUserListRequestAsync(this OcipClientBase client, GroupEnterpriseTrunkAddUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEnterpriseTrunkDeleteRequest(this OcipClientBase client, GroupEnterpriseTrunkDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkDeleteRequestAsync(this OcipClientBase client, GroupEnterpriseTrunkDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete users from an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkDeleteUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEnterpriseTrunkDeleteUserListRequest(this OcipClientBase client, GroupEnterpriseTrunkDeleteUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete users from an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkDeleteUserListRequestAsync(this OcipClientBase client, GroupEnterpriseTrunkDeleteUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add users to an enterprise trunk in a group. If the user is already assigned to another enterprise trunk,
        /// it will be unassigned from the old enterprise trunk and assigned to the new enterprise trunk specified in this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkForceAssignUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEnterpriseTrunkForceAssignUserListRequest(this OcipClientBase client, GroupEnterpriseTrunkForceAssignUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add users to an enterprise trunk in a group. If the user is already assigned to another enterprise trunk,
        /// it will be unassigned from the old enterprise trunk and assigned to the new enterprise trunk specified in this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkForceAssignUserListRequestAsync(this OcipClientBase client, GroupEnterpriseTrunkForceAssignUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of all available trunk groups defined in a group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkGetAvailableTrunkGroupListRequestAsync instead.")]
        public static async Task<GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse> GroupEnterpriseTrunkGetAvailableTrunkGroupListRequest(this OcipClientBase client, GroupEnterpriseTrunkGetAvailableTrunkGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse;
        }

        /// <summary>
        /// Request to get the list of all available trunk groups defined in a group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse> GroupEnterpriseTrunkGetAvailableTrunkGroupListRequestAsync(this OcipClientBase client, GroupEnterpriseTrunkGetAvailableTrunkGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse;
        }
        /// <summary>
        /// Request the list of users that are available to be added to an enterprise trunk.  This list contains users in the group that are trunk users and not already assigned to an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetAvailableUserListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkGetAvailableUserListRequestAsync instead.")]
        public static async Task<GroupEnterpriseTrunkGetAvailableUserListResponse> GroupEnterpriseTrunkGetAvailableUserListRequest(this OcipClientBase client, GroupEnterpriseTrunkGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEnterpriseTrunkGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request the list of users that are available to be added to an enterprise trunk.  This list contains users in the group that are trunk users and not already assigned to an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetAvailableUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetAvailableUserListResponse> GroupEnterpriseTrunkGetAvailableUserListRequestAsync(this OcipClientBase client, GroupEnterpriseTrunkGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEnterpriseTrunkGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request to get the list of all enterprise trunks defined in a group.
        /// The response is either a GroupEnterpriseTrunkGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkGetListRequestAsync instead.")]
        public static async Task<GroupEnterpriseTrunkGetListResponse> GroupEnterpriseTrunkGetListRequest(this OcipClientBase client, GroupEnterpriseTrunkGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEnterpriseTrunkGetListResponse;
        }

        /// <summary>
        /// Request to get the list of all enterprise trunks defined in a group.
        /// The response is either a GroupEnterpriseTrunkGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetListResponse> GroupEnterpriseTrunkGetListRequestAsync(this OcipClientBase client, GroupEnterpriseTrunkGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEnterpriseTrunkGetListResponse;
        }
        /// <summary>
        /// Request to get an enterprise trunk
        /// The response is either an GroupEnterpriseTrunkGetResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkGetRequest21Async instead.")]
        public static async Task<GroupEnterpriseTrunkGetResponse21> GroupEnterpriseTrunkGetRequest21(this OcipClientBase client, GroupEnterpriseTrunkGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEnterpriseTrunkGetResponse21;
        }

        /// <summary>
        /// Request to get an enterprise trunk
        /// The response is either an GroupEnterpriseTrunkGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetResponse21> GroupEnterpriseTrunkGetRequest21Async(this OcipClientBase client, GroupEnterpriseTrunkGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEnterpriseTrunkGetResponse21;
        }
        /// <summary>
        /// Request the list of users in an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetUserListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkGetUserListRequestAsync instead.")]
        public static async Task<GroupEnterpriseTrunkGetUserListResponse> GroupEnterpriseTrunkGetUserListRequest(this OcipClientBase client, GroupEnterpriseTrunkGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEnterpriseTrunkGetUserListResponse;
        }

        /// <summary>
        /// Request the list of users in an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetUserListResponse> GroupEnterpriseTrunkGetUserListRequestAsync(this OcipClientBase client, GroupEnterpriseTrunkGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEnterpriseTrunkGetUserListResponse;
        }
        /// <summary>
        /// Request to modify an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEnterpriseTrunkModifyRequest(this OcipClientBase client, GroupEnterpriseTrunkModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkModifyRequestAsync(this OcipClientBase client, GroupEnterpriseTrunkModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The command will fail if enableNetworkAddressIdentity is set to
        /// true and administrator is not System/Provisioning level administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupAddInstanceRequest21Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest21(this OcipClientBase client, GroupTrunkGroupAddInstanceRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The command will fail if enableNetworkAddressIdentity is set to
        /// true and administrator is not System/Provisioning level administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest21Async(this OcipClientBase client, GroupTrunkGroupAddInstanceRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The command will fail if enableNetworkAddressIdentity is set to
        /// true and administrator is not System/Provisioning level administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupAddInstanceRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest22(this OcipClientBase client, GroupTrunkGroupAddInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The command will fail if enableNetworkAddressIdentity is set to
        /// true and administrator is not System/Provisioning level administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest22Async(this OcipClientBase client, GroupTrunkGroupAddInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Trunk Group Instance from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupDeleteInstanceRequest14sp4Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupDeleteInstanceRequest14sp4(this OcipClientBase client, GroupTrunkGroupDeleteInstanceRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Trunk Group Instance from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupDeleteInstanceRequest14sp4Async(this OcipClientBase client, GroupTrunkGroupDeleteInstanceRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of hosted users that can be assigned to a Trunk Group.
        /// The response is either GroupTrunkGroupGetAvailableHostedUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupGetAvailableHostedUserListRequestAsync instead.")]
        public static async Task<GroupTrunkGroupGetAvailableHostedUserListResponse> GroupTrunkGroupGetAvailableHostedUserListRequest(this OcipClientBase client, GroupTrunkGroupGetAvailableHostedUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupGetAvailableHostedUserListResponse;
        }

        /// <summary>
        /// Get a list of hosted users that can be assigned to a Trunk Group.
        /// The response is either GroupTrunkGroupGetAvailableHostedUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetAvailableHostedUserListResponse> GroupTrunkGroupGetAvailableHostedUserListRequestAsync(this OcipClientBase client, GroupTrunkGroupGetAvailableHostedUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupGetAvailableHostedUserListResponse;
        }
        /// <summary>
        /// Get a list of Trunk Groups for the group or enterprise.
        /// It is possible to restrict the results to a particular department, or expand the list to the entire enterprise.
        /// The response is either a GroupTrunkGroupGetInstanceListResponse14sp4 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupGetInstanceListRequest14sp4Async instead.")]
        public static async Task<GroupTrunkGroupGetInstanceListResponse14sp4> GroupTrunkGroupGetInstanceListRequest14sp4(this OcipClientBase client, GroupTrunkGroupGetInstanceListRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupGetInstanceListResponse14sp4;
        }

        /// <summary>
        /// Get a list of Trunk Groups for the group or enterprise.
        /// It is possible to restrict the results to a particular department, or expand the list to the entire enterprise.
        /// The response is either a GroupTrunkGroupGetInstanceListResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceListResponse14sp4> GroupTrunkGroupGetInstanceListRequest14sp4Async(this OcipClientBase client, GroupTrunkGroupGetInstanceListRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupGetInstanceListResponse14sp4;
        }
        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse23 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
        /// "Department", "Email Address".
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupGetInstanceRequest23Async instead.")]
        public static async Task<GroupTrunkGroupGetInstanceResponse23> GroupTrunkGroupGetInstanceRequest23(this OcipClientBase client, GroupTrunkGroupGetInstanceRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupGetInstanceResponse23;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse23 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
        /// "Department", "Email Address".
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse23> GroupTrunkGroupGetInstanceRequest23Async(this OcipClientBase client, GroupTrunkGroupGetInstanceRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupGetInstanceResponse23;
        }
        /// <summary>
        /// Get a list of user's on a Trunk Group Instance.
        /// The response is either a GroupTrunkGroupGetInstanceUserListResponse14sp4 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupGetInstanceUserListRequest14sp4Async instead.")]
        public static async Task<GroupTrunkGroupGetInstanceUserListResponse14sp4> GroupTrunkGroupGetInstanceUserListRequest14sp4(this OcipClientBase client, GroupTrunkGroupGetInstanceUserListRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupGetInstanceUserListResponse14sp4;
        }

        /// <summary>
        /// Get a list of user's on a Trunk Group Instance.
        /// The response is either a GroupTrunkGroupGetInstanceUserListResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceUserListResponse14sp4> GroupTrunkGroupGetInstanceUserListRequest14sp4Async(this OcipClientBase client, GroupTrunkGroupGetInstanceUserListRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupGetInstanceUserListResponse14sp4;
        }
        /// <summary>
        /// Get the maximum and bursting maximum permissible active trunk group calls for the group.
        /// The response is either a GroupTrunkGroupGetResponse14sp9 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupGetRequest14sp9Async instead.")]
        public static async Task<GroupTrunkGroupGetResponse14sp9> GroupTrunkGroupGetRequest14sp9(this OcipClientBase client, GroupTrunkGroupGetRequest14sp9 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupGetResponse14sp9;
        }

        /// <summary>
        /// Get the maximum and bursting maximum permissible active trunk group calls for the group.
        /// The response is either a GroupTrunkGroupGetResponse14sp9 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetResponse14sp9> GroupTrunkGroupGetRequest14sp9Async(this OcipClientBase client, GroupTrunkGroupGetRequest14sp9 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupGetResponse14sp9;
        }
        /// <summary>
        /// Modify a Trunk Group Instance in a group.
        /// The access device cannot be modified or cleared if there are any users assigned to the Trunk Group.
        /// The command will fail if enableNetworkAddressIdentity is set and
        /// administrator is not System/Provisioning level administrator.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupModifyInstanceRequest20sp1Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupModifyInstanceRequest20sp1(this OcipClientBase client, GroupTrunkGroupModifyInstanceRequest20sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Trunk Group Instance in a group.
        /// The access device cannot be modified or cleared if there are any users assigned to the Trunk Group.
        /// The command will fail if enableNetworkAddressIdentity is set and
        /// administrator is not System/Provisioning level administrator.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupModifyInstanceRequest20sp1Async(this OcipClientBase client, GroupTrunkGroupModifyInstanceRequest20sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the maximum and bursting maximum permissible active Trunk Group calls for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupModifyRequest14sp9Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupModifyRequest14sp9(this OcipClientBase client, GroupTrunkGroupModifyRequest14sp9 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the maximum and bursting maximum permissible active Trunk Group calls for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupModifyRequest14sp9Async(this OcipClientBase client, GroupTrunkGroupModifyRequest14sp9 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of trunk group level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequest(this OcipClientBase client, GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of trunk group level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequestAsync(this OcipClientBase client, GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a user creation task for a trunk group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupUserCreationTaskAddRequest14sp4Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupUserCreationTaskAddRequest14sp4(this OcipClientBase client, GroupTrunkGroupUserCreationTaskAddRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a user creation task for a trunk group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupUserCreationTaskAddRequest14sp4Async(this OcipClientBase client, GroupTrunkGroupUserCreationTaskAddRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a user creation task for a trunk group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupUserCreationTaskDeleteRequest14sp4Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupUserCreationTaskDeleteRequest14sp4(this OcipClientBase client, GroupTrunkGroupUserCreationTaskDeleteRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a user creation task for a trunk group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupUserCreationTaskDeleteRequest14sp4Async(this OcipClientBase client, GroupTrunkGroupUserCreationTaskDeleteRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of user creation tasks for a trunk group.
        /// The response is either GroupTrunkGroupUserCreationTaskGetListResponse14sp4 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupUserCreationTaskGetListRequest14sp4Async instead.")]
        public static async Task<GroupTrunkGroupUserCreationTaskGetListResponse14sp4> GroupTrunkGroupUserCreationTaskGetListRequest14sp4(this OcipClientBase client, GroupTrunkGroupUserCreationTaskGetListRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupUserCreationTaskGetListResponse14sp4;
        }

        /// <summary>
        /// Get the list of user creation tasks for a trunk group.
        /// The response is either GroupTrunkGroupUserCreationTaskGetListResponse14sp4 or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupUserCreationTaskGetListResponse14sp4> GroupTrunkGroupUserCreationTaskGetListRequest14sp4Async(this OcipClientBase client, GroupTrunkGroupUserCreationTaskGetListRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupUserCreationTaskGetListResponse14sp4;
        }
        /// <summary>
        /// Request the details of a specified user creation task for a trunk group.
        /// The response is either GroupTrunkGroupUserCreationTaskGetResponse14sp4 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupUserCreationTaskGetRequest14sp4Async instead.")]
        public static async Task<GroupTrunkGroupUserCreationTaskGetResponse14sp4> GroupTrunkGroupUserCreationTaskGetRequest14sp4(this OcipClientBase client, GroupTrunkGroupUserCreationTaskGetRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupUserCreationTaskGetResponse14sp4;
        }

        /// <summary>
        /// Request the details of a specified user creation task for a trunk group.
        /// The response is either GroupTrunkGroupUserCreationTaskGetResponse14sp4 or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupUserCreationTaskGetResponse14sp4> GroupTrunkGroupUserCreationTaskGetRequest14sp4Async(this OcipClientBase client, GroupTrunkGroupUserCreationTaskGetRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupUserCreationTaskGetResponse14sp4;
        }
        /// <summary>
        /// Get the maximum and bursting maximum permissible active Trunk Group calls for the service provider.
        /// The response is either a ServiceProviderTrunkGroupGetResponse14sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderTrunkGroupGetRequest14sp1Async instead.")]
        public static async Task<ServiceProviderTrunkGroupGetResponse14sp1> ServiceProviderTrunkGroupGetRequest14sp1(this OcipClientBase client, ServiceProviderTrunkGroupGetRequest14sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderTrunkGroupGetResponse14sp1;
        }

        /// <summary>
        /// Get the maximum and bursting maximum permissible active Trunk Group calls for the service provider.
        /// The response is either a ServiceProviderTrunkGroupGetResponse14sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderTrunkGroupGetResponse14sp1> ServiceProviderTrunkGroupGetRequest14sp1Async(this OcipClientBase client, ServiceProviderTrunkGroupGetRequest14sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderTrunkGroupGetResponse14sp1;
        }
        /// <summary>
        /// Modify the maximum and bursting maximum permissible active Trunk Group calls for the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderTrunkGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderTrunkGroupModifyRequest(this OcipClientBase client, ServiceProviderTrunkGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the maximum and bursting maximum permissible active Trunk Group calls for the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderTrunkGroupModifyRequestAsync(this OcipClientBase client, ServiceProviderTrunkGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with the Trunk Group service.
        /// The response is either SystemTrunkGroupGetResponse23 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTrunkGroupGetRequest23Async instead.")]
        public static async Task<SystemTrunkGroupGetResponse23> SystemTrunkGroupGetRequest23(this OcipClientBase client, SystemTrunkGroupGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTrunkGroupGetResponse23;
        }

        /// <summary>
        /// Request the system level data associated with the Trunk Group service.
        /// The response is either SystemTrunkGroupGetResponse23 or ErrorResponse.
        /// </summary>
        public static async Task<SystemTrunkGroupGetResponse23> SystemTrunkGroupGetRequest23Async(this OcipClientBase client, SystemTrunkGroupGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTrunkGroupGetResponse23;
        }
        /// <summary>
        /// Modify the system level data associated with the Trunk Group Service.
        /// Following attributes are only used in IMS mode. The values are saved if specified not in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTrunkGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTrunkGroupModifyRequest(this OcipClientBase client, SystemTrunkGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with the Trunk Group Service.
        /// Following attributes are only used in IMS mode. The values are saved if specified not in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTrunkGroupModifyRequestAsync(this OcipClientBase client, SystemTrunkGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequest(this OcipClientBase client, SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequestAsync(this OcipClientBase client, SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequest(this OcipClientBase client, SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequestAsync(this OcipClientBase client, SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequestAsync instead.")]
        public static async Task<SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest(this OcipClientBase client, SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequestAsync(this OcipClientBase client, SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse;
        }
        /// <summary>
        /// Get the list of user creation tasks in the system.
        /// The response is either SystemTrunkGroupUserCreationTaskGetListResponse14sp4 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTrunkGroupUserCreationTaskGetListRequest14sp4Async instead.")]
        public static async Task<SystemTrunkGroupUserCreationTaskGetListResponse14sp4> SystemTrunkGroupUserCreationTaskGetListRequest14sp4(this OcipClientBase client, SystemTrunkGroupUserCreationTaskGetListRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTrunkGroupUserCreationTaskGetListResponse14sp4;
        }

        /// <summary>
        /// Get the list of user creation tasks in the system.
        /// The response is either SystemTrunkGroupUserCreationTaskGetListResponse14sp4 or ErrorResponse.
        /// </summary>
        public static async Task<SystemTrunkGroupUserCreationTaskGetListResponse14sp4> SystemTrunkGroupUserCreationTaskGetListRequest14sp4Async(this OcipClientBase client, SystemTrunkGroupUserCreationTaskGetListRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTrunkGroupUserCreationTaskGetListResponse14sp4;
        }

    }
}
