using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceVirtualOnNetEnterpriseExtensionsExtensions
    {

        /// <summary>
        /// Request the list of Virtual On-Net users in an Enterprise.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a  EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse or
        /// an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListRequestAsync instead.")]
        public static async Task<EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse> EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListRequest(this OcipClientBase client, EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse;
        }

        /// <summary>
        /// Request the list of Virtual On-Net users in an Enterprise.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a  EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse or
        /// an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse> EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListRequestAsync(this OcipClientBase client, EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse;
        }
        /// <summary>
        /// Adds Virtual On-Net users to a Group. It is possible to add
        /// either: a single user,  or a list of users, or a range of users,
        /// or any combination thereof.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVirtualOnNetEnterpriseExtensionsAddUserRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVirtualOnNetEnterpriseExtensionsAddUserRequest(this OcipClientBase client, GroupVirtualOnNetEnterpriseExtensionsAddUserRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds Virtual On-Net users to a Group. It is possible to add
        /// either: a single user,  or a list of users, or a range of users,
        /// or any combination thereof.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVirtualOnNetEnterpriseExtensionsAddUserRequestAsync(this OcipClientBase client, GroupVirtualOnNetEnterpriseExtensionsAddUserRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an existing Virtual On-Net user from a Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVirtualOnNetEnterpriseExtensionsDeleteUserRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVirtualOnNetEnterpriseExtensionsDeleteUserRequest(this OcipClientBase client, GroupVirtualOnNetEnterpriseExtensionsDeleteUserRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an existing Virtual On-Net user from a Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVirtualOnNetEnterpriseExtensionsDeleteUserRequestAsync(this OcipClientBase client, GroupVirtualOnNetEnterpriseExtensionsDeleteUserRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of Virtual On-Net users in a Group.
        /// It is possible to search by various criteria to restrict the number
        /// of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVirtualOnNetEnterpriseExtensionsGetUserListRequestAsync instead.")]
        public static async Task<GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse> GroupVirtualOnNetEnterpriseExtensionsGetUserListRequest(this OcipClientBase client, GroupVirtualOnNetEnterpriseExtensionsGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse;
        }

        /// <summary>
        /// Request the list of Virtual On-Net users in a Group.
        /// It is possible to search by various criteria to restrict the number
        /// of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse> GroupVirtualOnNetEnterpriseExtensionsGetUserListRequestAsync(this OcipClientBase client, GroupVirtualOnNetEnterpriseExtensionsGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVirtualOnNetEnterpriseExtensionsGetUserListResponse;
        }
        /// <summary>
        /// Get an existing Virtual On-Net user from a Group.
        /// The response is either a GroupVirtualOnNetEnterpriseExtensionsGetUserResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVirtualOnNetEnterpriseExtensionsGetUserRequestAsync instead.")]
        public static async Task<GroupVirtualOnNetEnterpriseExtensionsGetUserResponse> GroupVirtualOnNetEnterpriseExtensionsGetUserRequest(this OcipClientBase client, GroupVirtualOnNetEnterpriseExtensionsGetUserRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVirtualOnNetEnterpriseExtensionsGetUserResponse;
        }

        /// <summary>
        /// Get an existing Virtual On-Net user from a Group.
        /// The response is either a GroupVirtualOnNetEnterpriseExtensionsGetUserResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupVirtualOnNetEnterpriseExtensionsGetUserResponse> GroupVirtualOnNetEnterpriseExtensionsGetUserRequestAsync(this OcipClientBase client, GroupVirtualOnNetEnterpriseExtensionsGetUserRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVirtualOnNetEnterpriseExtensionsGetUserResponse;
        }
        /// <summary>
        /// Modify an existing Virtual On-Net user of a Group.
        /// The serviceProviderId, groupId and phoneNumber combination uniquely
        /// identifies a Virtual On-Net User.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVirtualOnNetEnterpriseExtensionsModifyUserRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVirtualOnNetEnterpriseExtensionsModifyUserRequest(this OcipClientBase client, GroupVirtualOnNetEnterpriseExtensionsModifyUserRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Virtual On-Net user of a Group.
        /// The serviceProviderId, groupId and phoneNumber combination uniquely
        /// identifies a Virtual On-Net User.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVirtualOnNetEnterpriseExtensionsModifyUserRequestAsync(this OcipClientBase client, GroupVirtualOnNetEnterpriseExtensionsModifyUserRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Virtual On-Net Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVirtualOnNetCallTypeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVirtualOnNetCallTypeAddRequest(this OcipClientBase client, SystemVirtualOnNetCallTypeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Virtual On-Net Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVirtualOnNetCallTypeAddRequestAsync(this OcipClientBase client, SystemVirtualOnNetCallTypeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Virtual On-Net Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVirtualOnNetCallTypeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVirtualOnNetCallTypeDeleteRequest(this OcipClientBase client, SystemVirtualOnNetCallTypeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Virtual On-Net Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVirtualOnNetCallTypeDeleteRequestAsync(this OcipClientBase client, SystemVirtualOnNetCallTypeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list Virtual On-Net Call Types in the system.
        /// The response is either a SystemVirtualOnNetCallTypeGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVirtualOnNetCallTypeGetListRequestAsync instead.")]
        public static async Task<SystemVirtualOnNetCallTypeGetListResponse> SystemVirtualOnNetCallTypeGetListRequest(this OcipClientBase client, SystemVirtualOnNetCallTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVirtualOnNetCallTypeGetListResponse;
        }

        /// <summary>
        /// Get the list Virtual On-Net Call Types in the system.
        /// The response is either a SystemVirtualOnNetCallTypeGetListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemVirtualOnNetCallTypeGetListResponse> SystemVirtualOnNetCallTypeGetListRequestAsync(this OcipClientBase client, SystemVirtualOnNetCallTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVirtualOnNetCallTypeGetListResponse;
        }
        /// <summary>
        /// Modify a Virtual On-Net Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVirtualOnNetCallTypeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVirtualOnNetCallTypeModifyRequest(this OcipClientBase client, SystemVirtualOnNetCallTypeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Virtual On-Net Call Type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVirtualOnNetCallTypeModifyRequestAsync(this OcipClientBase client, SystemVirtualOnNetCallTypeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
