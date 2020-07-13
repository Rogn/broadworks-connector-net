using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceOutgoingCallingPlanExtensions
    {

        /// <summary>
        /// Request the list of authorization codes for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanAuthorizationCodeGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanAuthorizationCodeGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanAuthorizationCodeGetListResponse> GroupOutgoingCallingPlanAuthorizationCodeGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanAuthorizationCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanAuthorizationCodeGetListResponse;
        }

        /// <summary>
        /// Request the list of authorization codes for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanAuthorizationCodeGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanAuthorizationCodeGetListResponse> GroupOutgoingCallingPlanAuthorizationCodeGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanAuthorizationCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanAuthorizationCodeGetListResponse;
        }
        /// <summary>
        /// Request the Call Me Now call permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanCallMeNowGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanCallMeNowGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanCallMeNowGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanCallMeNowGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanCallMeNowGetListResponse;
        }

        /// <summary>
        /// Request the Call Me Now call permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanCallMeNowGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanCallMeNowGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanCallMeNowGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanCallMeNowGetListResponse;
        }
        /// <summary>
        /// Modify the Call Me Now call permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanCallMeNowModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanCallMeNowModifyListRequest(this OcipClientBase client, GroupOutgoingCallingPlanCallMeNowModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Me Now call permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanCallMeNowModifyListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanCallMeNowModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of authorization codes to the group's default or a department. When department is not
        /// specified, it is for the group default.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequest(this OcipClientBase client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of authorization codes to the group's default or a department. When department is not
        /// specified, it is for the group default.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of authorization codes from the group's default or a department. When department is not
        /// specified, it is for the group default.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDepartmentAuthorizationCodeDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeDeleteListRequest(this OcipClientBase client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of authorization codes from the group's default or a department. When department is not
        /// specified, it is for the group default.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeDeleteListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of authorization codes for a group default or a department.  When department is not
        /// specified, it is for the group default.
        /// The response is either a GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse;
        }

        /// <summary>
        /// Request the list of authorization codes for a group default or a department.  When department is not
        /// specified, it is for the group default.
        /// The response is either a GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse;
        }
        /// <summary>
        /// Request the Call Me Now call permissions for digit patterns for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse;
        }

        /// <summary>
        /// Request the Call Me Now call permissions for digit patterns for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse;
        }
        /// <summary>
        /// Modify the Call Me Now call permissions for digit patterns for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequest(this OcipClientBase client, GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Me Now call permissions for digit patterns for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the originating permissions for digit patterns for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDigitPlanOriginatingGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse> GroupOutgoingCallingPlanDigitPlanOriginatingGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanDigitPlanOriginatingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse;
        }

        /// <summary>
        /// Request the originating permissions for digit patterns for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse> GroupOutgoingCallingPlanDigitPlanOriginatingGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanDigitPlanOriginatingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse;
        }
        /// <summary>
        /// Modify the originating permissions for digit patterns for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDigitPlanOriginatingModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanOriginatingModifyListRequest(this OcipClientBase client, GroupOutgoingCallingPlanDigitPlanOriginatingModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the originating permissions for digit patterns for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanOriginatingModifyListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanDigitPlanOriginatingModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the redirecting permissions for digit patterns for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDigitPlanRedirectingGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse> GroupOutgoingCallingPlanDigitPlanRedirectingGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanDigitPlanRedirectingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse;
        }

        /// <summary>
        /// Request the redirecting permissions for digit patterns for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse> GroupOutgoingCallingPlanDigitPlanRedirectingGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanDigitPlanRedirectingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse;
        }
        /// <summary>
        /// Modify the redirecting permissions for digit patterns for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDigitPlanRedirectingModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanRedirectingModifyListRequest(this OcipClientBase client, GroupOutgoingCallingPlanDigitPlanRedirectingModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the redirecting permissions for digit patterns for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanRedirectingModifyListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanDigitPlanRedirectingModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the originating permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanOriginatingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanOriginatingGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanOriginatingGetListResponse> GroupOutgoingCallingPlanOriginatingGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanOriginatingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanOriginatingGetListResponse;
        }

        /// <summary>
        /// Request the originating permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanOriginatingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanOriginatingGetListResponse> GroupOutgoingCallingPlanOriginatingGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanOriginatingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanOriginatingGetListResponse;
        }
        /// <summary>
        /// Modify the originating permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanOriginatingModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanOriginatingModifyListRequest(this OcipClientBase client, GroupOutgoingCallingPlanOriginatingModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the originating permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanOriginatingModifyListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanOriginatingModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new calling plan Pinhole digit string.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPatternAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternAddRequest(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPatternAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new calling plan Pinhole digit string.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternAddRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPatternAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete one or more calling plan Pinhole digit strings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPatternDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternDeleteListRequest(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPatternDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete one or more calling plan Pinhole digit strings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternDeleteListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPatternDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of calling plan Pinhole digit strings for a group.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPatternGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse> GroupOutgoingCallingPlanPinholeDigitPatternGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPatternGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse;
        }

        /// <summary>
        /// Get the list of calling plan Pinhole digit strings for a group.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse> GroupOutgoingCallingPlanPinholeDigitPatternGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPatternGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse;
        }
        /// <summary>
        /// Modify a calling plan Pinhole digit string. The name is a key; it cannot be changed.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPatternModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternModifyRequest(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPatternModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a calling plan Pinhole digit string. The name is a key; it cannot be changed.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternModifyRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPatternModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Call Me Now permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse;
        }

        /// <summary>
        /// Request the Call Me Now permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse;
        }
        /// <summary>
        /// Modify the Call Me Now permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequest(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Me Now permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the originating permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse;
        }

        /// <summary>
        /// Request the originating permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse;
        }
        /// <summary>
        /// Modify the originating permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPlanOriginatingModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanOriginatingModifyListRequest(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPlanOriginatingModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the originating permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanOriginatingModifyListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPlanOriginatingModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the redirecting permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse;
        }

        /// <summary>
        /// Request the redirecting permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse;
        }
        /// <summary>
        /// Modify the redirecting permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPlanRedirectingModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanRedirectingModifyListRequest(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPlanRedirectingModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the redirecting permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanRedirectingModifyListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanPinholeDigitPlanRedirectingModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the call forwarded/transferred permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanRedirectedGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanRedirectedGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanRedirectedGetListResponse> GroupOutgoingCallingPlanRedirectedGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanRedirectedGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanRedirectedGetListResponse;
        }

        /// <summary>
        /// Request the call forwarded/transferred permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanRedirectedGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanRedirectedGetListResponse> GroupOutgoingCallingPlanRedirectedGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanRedirectedGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanRedirectedGetListResponse;
        }
        /// <summary>
        /// Modify the call forwarded/transferred permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanRedirectedModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanRedirectedModifyListRequest(this OcipClientBase client, GroupOutgoingCallingPlanRedirectedModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the call forwarded/transferred permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanRedirectedModifyListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanRedirectedModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the initiating call forwards/transfer permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanRedirectingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanRedirectingGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanRedirectingGetListResponse> GroupOutgoingCallingPlanRedirectingGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanRedirectingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanRedirectingGetListResponse;
        }

        /// <summary>
        /// Request the initiating call forwards/transfer permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanRedirectingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanRedirectingGetListResponse> GroupOutgoingCallingPlanRedirectingGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanRedirectingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanRedirectingGetListResponse;
        }
        /// <summary>
        /// Modify the initiating call forwards/transfer permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanRedirectingModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanRedirectingModifyListRequest(this OcipClientBase client, GroupOutgoingCallingPlanRedirectingModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the initiating call forwards/transfer permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanRedirectingModifyListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanRedirectingModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of transfer numbers for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanTransferNumbersGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanTransferNumbersGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanTransferNumbersGetListResponse> GroupOutgoingCallingPlanTransferNumbersGetListRequest(this OcipClientBase client, GroupOutgoingCallingPlanTransferNumbersGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanTransferNumbersGetListResponse;
        }

        /// <summary>
        /// Request the list of transfer numbers for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanTransferNumbersGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanTransferNumbersGetListResponse> GroupOutgoingCallingPlanTransferNumbersGetListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanTransferNumbersGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanTransferNumbersGetListResponse;
        }
        /// <summary>
        /// Modify the list of transfer numbers for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanTransferNumbersModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanTransferNumbersModifyListRequest(this OcipClientBase client, GroupOutgoingCallingPlanTransferNumbersModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the list of transfer numbers for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanTransferNumbersModifyListRequestAsync(this OcipClientBase client, GroupOutgoingCallingPlanTransferNumbersModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system outgoing calling plan call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOutgoingCallingPlanCallTypeAddMappingRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOutgoingCallingPlanCallTypeAddMappingRequest(this OcipClientBase client, SystemOutgoingCallingPlanCallTypeAddMappingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system outgoing calling plan call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOutgoingCallingPlanCallTypeAddMappingRequestAsync(this OcipClientBase client, SystemOutgoingCallingPlanCallTypeAddMappingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a system outgoing calling plan call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOutgoingCallingPlanCallTypeDeleteMappingRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOutgoingCallingPlanCallTypeDeleteMappingRequest(this OcipClientBase client, SystemOutgoingCallingPlanCallTypeDeleteMappingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system outgoing calling plan call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOutgoingCallingPlanCallTypeDeleteMappingRequestAsync(this OcipClientBase client, SystemOutgoingCallingPlanCallTypeDeleteMappingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of call types of outgoing calling plan
        /// The response is SystemOutgoingCallingPlanCallTypeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOutgoingCallingPlanCallTypeGetListRequestAsync instead.")]
        public static async Task<SystemOutgoingCallingPlanCallTypeGetListResponse> SystemOutgoingCallingPlanCallTypeGetListRequest(this OcipClientBase client, SystemOutgoingCallingPlanCallTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOutgoingCallingPlanCallTypeGetListResponse;
        }

        /// <summary>
        /// Request to get the list of call types of outgoing calling plan
        /// The response is SystemOutgoingCallingPlanCallTypeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOutgoingCallingPlanCallTypeGetListResponse> SystemOutgoingCallingPlanCallTypeGetListRequestAsync(this OcipClientBase client, SystemOutgoingCallingPlanCallTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOutgoingCallingPlanCallTypeGetListResponse;
        }
        /// <summary>
        /// Get a list of system outgoing calling plan call type mappings.
        /// The response is either SystemOutgoingCallingPlanCallTypeGetMappingListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOutgoingCallingPlanCallTypeGetMappingListRequestAsync instead.")]
        public static async Task<SystemOutgoingCallingPlanCallTypeGetMappingListResponse> SystemOutgoingCallingPlanCallTypeGetMappingListRequest(this OcipClientBase client, SystemOutgoingCallingPlanCallTypeGetMappingListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOutgoingCallingPlanCallTypeGetMappingListResponse;
        }

        /// <summary>
        /// Get a list of system outgoing calling plan call type mappings.
        /// The response is either SystemOutgoingCallingPlanCallTypeGetMappingListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOutgoingCallingPlanCallTypeGetMappingListResponse> SystemOutgoingCallingPlanCallTypeGetMappingListRequestAsync(this OcipClientBase client, SystemOutgoingCallingPlanCallTypeGetMappingListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOutgoingCallingPlanCallTypeGetMappingListResponse;
        }
        /// <summary>
        /// Request the system level data associated with Outgoing Calling Plan.
        /// The response is either a SystemOutgoingCallingPlanGetResponse17sp3 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOutgoingCallingPlanGetRequest17sp3Async instead.")]
        public static async Task<SystemOutgoingCallingPlanGetResponse17sp3> SystemOutgoingCallingPlanGetRequest17sp3(this OcipClientBase client, SystemOutgoingCallingPlanGetRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOutgoingCallingPlanGetResponse17sp3;
        }

        /// <summary>
        /// Request the system level data associated with Outgoing Calling Plan.
        /// The response is either a SystemOutgoingCallingPlanGetResponse17sp3 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOutgoingCallingPlanGetResponse17sp3> SystemOutgoingCallingPlanGetRequest17sp3Async(this OcipClientBase client, SystemOutgoingCallingPlanGetRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOutgoingCallingPlanGetResponse17sp3;
        }
        /// <summary>
        /// Modify the system level data associated with Outgoing Calling Plan.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOutgoingCallingPlanModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOutgoingCallingPlanModifyRequest(this OcipClientBase client, SystemOutgoingCallingPlanModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Outgoing Calling Plan.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOutgoingCallingPlanModifyRequestAsync(this OcipClientBase client, SystemOutgoingCallingPlanModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of authorization codes to a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanAuthorizationCodeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeAddListRequest(this OcipClientBase client, UserOutgoingCallingPlanAuthorizationCodeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of authorization codes to a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeAddListRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanAuthorizationCodeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of authorization codes from a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanAuthorizationCodeDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeDeleteListRequest(this OcipClientBase client, UserOutgoingCallingPlanAuthorizationCodeDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of authorization codes from a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeDeleteListRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanAuthorizationCodeDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of authorization codes for a user.
        /// The response is either a UserOutgoingCallingPlanAuthorizationCodeGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanAuthorizationCodeGetListRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanAuthorizationCodeGetListResponse> UserOutgoingCallingPlanAuthorizationCodeGetListRequest(this OcipClientBase client, UserOutgoingCallingPlanAuthorizationCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanAuthorizationCodeGetListResponse;
        }

        /// <summary>
        /// Request the list of authorization codes for a user.
        /// The response is either a UserOutgoingCallingPlanAuthorizationCodeGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanAuthorizationCodeGetListResponse> UserOutgoingCallingPlanAuthorizationCodeGetListRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanAuthorizationCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanAuthorizationCodeGetListResponse;
        }
        /// <summary>
        /// Request the authorization code setting for a user.
        /// The response is either a UserOutgoingCallingPlanAuthorizationCodeGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanAuthorizationCodeGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanAuthorizationCodeGetResponse> UserOutgoingCallingPlanAuthorizationCodeGetRequest(this OcipClientBase client, UserOutgoingCallingPlanAuthorizationCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanAuthorizationCodeGetResponse;
        }

        /// <summary>
        /// Request the authorization code setting for a user.
        /// The response is either a UserOutgoingCallingPlanAuthorizationCodeGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanAuthorizationCodeGetResponse> UserOutgoingCallingPlanAuthorizationCodeGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanAuthorizationCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanAuthorizationCodeGetResponse;
        }
        /// <summary>
        /// Modify the authorization setting for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanAuthorizationCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanAuthorizationCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the authorization setting for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanAuthorizationCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Call Me Now call permissions for a user.
        /// The response is either a UserOutgoingCallingPlanCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanCallMeNowGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanCallMeNowGetResponse> UserOutgoingCallingPlanCallMeNowGetRequest(this OcipClientBase client, UserOutgoingCallingPlanCallMeNowGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanCallMeNowGetResponse;
        }

        /// <summary>
        /// Request the Call Me Now call permissions for a user.
        /// The response is either a UserOutgoingCallingPlanCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanCallMeNowGetResponse> UserOutgoingCallingPlanCallMeNowGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanCallMeNowGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanCallMeNowGetResponse;
        }
        /// <summary>
        /// Modify the Call Me Now call permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanCallMeNowModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanCallMeNowModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanCallMeNowModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Me Now call permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanCallMeNowModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanCallMeNowModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Call Me Now call permissions for digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanDigitPlanCallMeNowGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse> UserOutgoingCallingPlanDigitPlanCallMeNowGetRequest(this OcipClientBase client, UserOutgoingCallingPlanDigitPlanCallMeNowGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse;
        }

        /// <summary>
        /// Request the Call Me Now call permissions for digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse> UserOutgoingCallingPlanDigitPlanCallMeNowGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanDigitPlanCallMeNowGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse;
        }
        /// <summary>
        /// Modify the Call Me Now call permissions for digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanDigitPlanCallMeNowModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanCallMeNowModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanDigitPlanCallMeNowModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Me Now call permissions for digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanCallMeNowModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanDigitPlanCallMeNowModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the originating permissions for digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanDigitPlanOriginatingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanDigitPlanOriginatingGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanDigitPlanOriginatingGetResponse> UserOutgoingCallingPlanDigitPlanOriginatingGetRequest(this OcipClientBase client, UserOutgoingCallingPlanDigitPlanOriginatingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanDigitPlanOriginatingGetResponse;
        }

        /// <summary>
        /// Request the originating permissions for digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanDigitPlanOriginatingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanDigitPlanOriginatingGetResponse> UserOutgoingCallingPlanDigitPlanOriginatingGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanDigitPlanOriginatingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanDigitPlanOriginatingGetResponse;
        }
        /// <summary>
        /// Modify the originating permissions for digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanDigitPlanOriginatingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanOriginatingModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanDigitPlanOriginatingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the originating permissions for digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanOriginatingModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanDigitPlanOriginatingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the redirecting permissions for digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanDigitPlanRedirectingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanDigitPlanRedirectingGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanDigitPlanRedirectingGetResponse> UserOutgoingCallingPlanDigitPlanRedirectingGetRequest(this OcipClientBase client, UserOutgoingCallingPlanDigitPlanRedirectingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanDigitPlanRedirectingGetResponse;
        }

        /// <summary>
        /// Request the redirecting permissions for digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanDigitPlanRedirectingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanDigitPlanRedirectingGetResponse> UserOutgoingCallingPlanDigitPlanRedirectingGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanDigitPlanRedirectingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanDigitPlanRedirectingGetResponse;
        }
        /// <summary>
        /// Modify the redirecting permissions for digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanDigitPlanRedirectingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanRedirectingModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanDigitPlanRedirectingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the redirecting permissions for digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanRedirectingModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanDigitPlanRedirectingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the originating permissions for a user.
        /// The response is either a UserOutgoingCallingPlanOriginatingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanOriginatingGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanOriginatingGetResponse> UserOutgoingCallingPlanOriginatingGetRequest(this OcipClientBase client, UserOutgoingCallingPlanOriginatingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanOriginatingGetResponse;
        }

        /// <summary>
        /// Request the originating permissions for a user.
        /// The response is either a UserOutgoingCallingPlanOriginatingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanOriginatingGetResponse> UserOutgoingCallingPlanOriginatingGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanOriginatingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanOriginatingGetResponse;
        }
        /// <summary>
        /// Modify the originating permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanOriginatingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanOriginatingModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanOriginatingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the originating permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanOriginatingModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanOriginatingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Call Me Now permissions for Pinhole digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse> UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequest(this OcipClientBase client, UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse;
        }

        /// <summary>
        /// Request the Call Me Now permissions for Pinhole digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse> UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse;
        }
        /// <summary>
        /// Modify the Call Me Now permissions for Pinhole digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Me Now permissions for Pinhole digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the originating permissions for Pinhole digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse> UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetRequest(this OcipClientBase client, UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse;
        }

        /// <summary>
        /// Request the originating permissions for Pinhole digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse> UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse;
        }
        /// <summary>
        /// Modify the originating permissions for Pinhole digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the originating permissions for Pinhole digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the redirecting permissions for Pinhole digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse> UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetRequest(this OcipClientBase client, UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse;
        }

        /// <summary>
        /// Request the redirecting permissions for Pinhole digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse> UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse;
        }
        /// <summary>
        /// Modify the redirecting permissions for Pinhole digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanPinholeDigitPlanRedirectingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanRedirectingModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanPinholeDigitPlanRedirectingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the redirecting permissions for Pinhole digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanRedirectingModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanPinholeDigitPlanRedirectingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the call forwarded/transferred permissions for a user.
        /// The response is either a UserOutgoingCallingPlanRedirectedGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanRedirectedGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanRedirectedGetResponse> UserOutgoingCallingPlanRedirectedGetRequest(this OcipClientBase client, UserOutgoingCallingPlanRedirectedGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanRedirectedGetResponse;
        }

        /// <summary>
        /// Request the call forwarded/transferred permissions for a user.
        /// The response is either a UserOutgoingCallingPlanRedirectedGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanRedirectedGetResponse> UserOutgoingCallingPlanRedirectedGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanRedirectedGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanRedirectedGetResponse;
        }
        /// <summary>
        /// Modify the call forwarded/transferred permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanRedirectedModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanRedirectedModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanRedirectedModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the call forwarded/transferred permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanRedirectedModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanRedirectedModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the initiating call forwards/transfer permissions for a user.
        /// The response is either a UserOutgoingCallingPlanRedirectingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanRedirectingGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanRedirectingGetResponse> UserOutgoingCallingPlanRedirectingGetRequest(this OcipClientBase client, UserOutgoingCallingPlanRedirectingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanRedirectingGetResponse;
        }

        /// <summary>
        /// Request the initiating call forwards/transfer permissions for a user.
        /// The response is either a UserOutgoingCallingPlanRedirectingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanRedirectingGetResponse> UserOutgoingCallingPlanRedirectingGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanRedirectingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanRedirectingGetResponse;
        }
        /// <summary>
        /// Modify the initiating call forwards/transfer permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanRedirectingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanRedirectingModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanRedirectingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the initiating call forwards/transfer permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanRedirectingModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanRedirectingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the sustained authorization code setting for a user.
        /// The response is either a UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanSustainedAuthorizationCodeGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse> UserOutgoingCallingPlanSustainedAuthorizationCodeGetRequest(this OcipClientBase client, UserOutgoingCallingPlanSustainedAuthorizationCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse;
        }

        /// <summary>
        /// Request the sustained authorization code setting for a user.
        /// The response is either a UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse> UserOutgoingCallingPlanSustainedAuthorizationCodeGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanSustainedAuthorizationCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse;
        }
        /// <summary>
        /// Modify or clear the sustained authorization code for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanSustainedAuthorizationCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanSustainedAuthorizationCodeModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanSustainedAuthorizationCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify or clear the sustained authorization code for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanSustainedAuthorizationCodeModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanSustainedAuthorizationCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the transfer numbers for a user.
        /// The response is either a UserOutgoingCallingPlanTransferNumbersGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanTransferNumbersGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanTransferNumbersGetResponse> UserOutgoingCallingPlanTransferNumbersGetRequest(this OcipClientBase client, UserOutgoingCallingPlanTransferNumbersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanTransferNumbersGetResponse;
        }

        /// <summary>
        /// Request the transfer numbers for a user.
        /// The response is either a UserOutgoingCallingPlanTransferNumbersGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanTransferNumbersGetResponse> UserOutgoingCallingPlanTransferNumbersGetRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanTransferNumbersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanTransferNumbersGetResponse;
        }
        /// <summary>
        /// Modify the transfer numbers for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanTransferNumbersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanTransferNumbersModifyRequest(this OcipClientBase client, UserOutgoingCallingPlanTransferNumbersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the transfer numbers for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanTransferNumbersModifyRequestAsync(this OcipClientBase client, UserOutgoingCallingPlanTransferNumbersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
