using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceRouteListExtensions
    {

        /// <summary>
        /// Request a list of number prefixes that are assigned to an enterprise and still available for assignment to users within the enterprise.
        /// The response is either EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequestAsync instead.")]
        public static async Task<EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse> EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest(this OcipClientBase client, EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse;
        }

        /// <summary>
        /// Request a list of number prefixes that are assigned to an enterprise and still available for assignment to users within the enterprise.
        /// The response is either EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse> EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequestAsync(this OcipClientBase client, EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse;
        }
        /// <summary>
        /// Request a summary table of all enterprise trunk number prefixes in the enterprise.
        /// The response is either EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequestAsync instead.")]
        public static async Task<EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse> EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest(this OcipClientBase client, EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all enterprise trunk number prefixes in the enterprise.
        /// The response is either EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse> EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequestAsync(this OcipClientBase client, EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse;
        }
        /// <summary>
        /// Request a list of number ranges that are assigned to an enterprise and still available for assignment to users within the enterprise.
        /// The response is either EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListRequestAsync instead.")]
        public static async Task<EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse> EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest(this OcipClientBase client, EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse;
        }

        /// <summary>
        /// Request a list of number ranges that are assigned to an enterprise and still available for assignment to users within the enterprise.
        /// The response is either EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse> EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListRequestAsync(this OcipClientBase client, EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse;
        }
        /// <summary>
        /// Request a summary table of all enterprise trunk number ranges in the enterprise.
        /// The response is either EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListRequestAsync instead.")]
        public static async Task<EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse> EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest(this OcipClientBase client, EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all enterprise trunk number ranges in the enterprise.
        /// The response is either EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse> EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListRequestAsync(this OcipClientBase client, EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse;
        }
        /// <summary>
        /// Assign a list of service provider number prefixes to a group.
        /// The number prefixes must have previously been added to the service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRouteListEnterpriseTrunkNumberPrefixAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRouteListEnterpriseTrunkNumberPrefixAssignListRequest(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberPrefixAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of service provider number prefixes to a group.
        /// The number prefixes must have previously been added to the service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRouteListEnterpriseTrunkNumberPrefixAssignListRequestAsync(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberPrefixAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of number prefixess that are assigned to a group and still available for assignment to users within the group.
        /// The response is either GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequestAsync instead.")]
        public static async Task<GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse> GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse;
        }

        /// <summary>
        /// Request a list of number prefixess that are assigned to a group and still available for assignment to users within the group.
        /// The response is either GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse> GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequestAsync(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse;
        }
        /// <summary>
        /// Get the list of assigned and unassigned enterprise trunknumber prefixes in a group.
        /// The response is either GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequestAsync instead.")]
        public static async Task<GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse> GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse;
        }

        /// <summary>
        /// Get the list of assigned and unassigned enterprise trunknumber prefixes in a group.
        /// The response is either GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse> GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequestAsync(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse;
        }
        /// <summary>
        /// Unassign a list of service provider number prefixes from a group. The number prefixes then become available for assignment to other groups.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRouteListEnterpriseTrunkNumberPrefixUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRouteListEnterpriseTrunkNumberPrefixUnassignListRequest(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberPrefixUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of service provider number prefixes from a group. The number prefixes then become available for assignment to other groups.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRouteListEnterpriseTrunkNumberPrefixUnassignListRequestAsync(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberPrefixUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of service provider number ranges to a group.
        /// The number ranges must have previously been added to the service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRouteListEnterpriseTrunkNumberRangeAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRouteListEnterpriseTrunkNumberRangeAssignListRequest(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberRangeAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of service provider number ranges to a group.
        /// The number ranges must have previously been added to the service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRouteListEnterpriseTrunkNumberRangeAssignListRequestAsync(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberRangeAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of number ranges that are assigned to a group and still available for assignment to users within the group.
        /// The response is either GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListRequestAsync instead.")]
        public static async Task<GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse> GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse;
        }

        /// <summary>
        /// Request a list of number ranges that are assigned to a group and still available for assignment to users within the group.
        /// The response is either GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse> GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListRequestAsync(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse;
        }
        /// <summary>
        /// Get the list of assigned and unassigned enterprise trunknumber ranges in a group.
        /// The response is either GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListRequestAsync instead.")]
        public static async Task<GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse> GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse;
        }

        /// <summary>
        /// Get the list of assigned and unassigned enterprise trunknumber ranges in a group.
        /// The response is either GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse> GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListRequestAsync(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse;
        }
        /// <summary>
        /// Unassign a list of service provider number ranges from a group. The number ranges then become available for assignment to other groups.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRouteListEnterpriseTrunkNumberRangeUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRouteListEnterpriseTrunkNumberRangeUnassignListRequest(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberRangeUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of service provider number ranges from a group. The number ranges then become available for assignment to other groups.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRouteListEnterpriseTrunkNumberRangeUnassignListRequestAsync(this OcipClientBase client, GroupRouteListEnterpriseTrunkNumberRangeUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Activate number prefixes in a service provider.
        /// It is not an error to activate an already activated number prefix.
        /// The command fails if executed when system level enterprise trunk number prefix activation is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberPrefixActivateListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixActivateListRequest(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixActivateListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Activate number prefixes in a service provider.
        /// It is not an error to activate an already activated number prefix.
        /// The command fails if executed when system level enterprise trunk number prefix activation is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixActivateListRequestAsync(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixActivateListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add number prefixes to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequest(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add number prefixes to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequestAsync(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deactivate number prefixes in a service provider.
        /// It is not an error to deactivate an already deactivated number prefix.
        /// The command fails if executed when system level enterprise trunk number prefix activation is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeactivateListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeactivateListRequest(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeactivateListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deactivate number prefixes in a service provider.
        /// It is not an error to deactivate an already deactivated number prefix.
        /// The command fails if executed when system level enterprise trunk number prefix activation is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeactivateListRequestAsync(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeactivateListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete number prefixes from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeleteListRequest(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete number prefixes from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeleteListRequestAsync(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of available number prefixes not yet assigned to any group.
        /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequestAsync instead.")]
        public static async Task<ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse;
        }

        /// <summary>
        /// Request a list of available number prefixes not yet assigned to any group.
        /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequestAsync(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse;
        }
        /// <summary>
        /// Request a summary table of all enterprise trunk number prefixes in the service provider.
        /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequestAsync instead.")]
        public static async Task<ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all enterprise trunk number prefixes in the service provider.
        /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequestAsync(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse;
        }
        /// <summary>
        /// Activate number ranges in a service provider.
        /// It is not an error to activate an already activated number range.
        /// The command fails if executed when system level enterprise trunk number range activation is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberRangeActivateListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeActivateListRequest(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberRangeActivateListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Activate number ranges in a service provider.
        /// It is not an error to activate an already activated number range.
        /// The command fails if executed when system level enterprise trunk number range activation is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeActivateListRequestAsync(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberRangeActivateListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add number ranges to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequest(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add number ranges to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequestAsync(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deactivate number ranges in a service provider.
        /// It is not an error to deactivate an already deactivated number range.
        /// The command fails if executed when system level enterprise trunk number range activation is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberRangeDeactivateListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeDeactivateListRequest(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberRangeDeactivateListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deactivate number ranges in a service provider.
        /// It is not an error to deactivate an already deactivated number range.
        /// The command fails if executed when system level enterprise trunk number range activation is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeDeactivateListRequestAsync(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberRangeDeactivateListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete number ranges from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberRangeDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeDeleteListRequest(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberRangeDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete number ranges from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeDeleteListRequestAsync(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberRangeDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of available number ranges not yet assigned to any group.
        /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListRequestAsync instead.")]
        public static async Task<ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse;
        }

        /// <summary>
        /// Request a list of available number ranges not yet assigned to any group.
        /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListRequestAsync(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse;
        }
        /// <summary>
        /// Request a summary table of all enterprise trunk number ranges in the service provider.
        /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListRequestAsync instead.")]
        public static async Task<ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all enterprise trunk number ranges in the service provider.
        /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListRequestAsync(this OcipClientBase client, ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse;
        }
        /// <summary>
        /// Request a summary table of all enterprise trunk prefixes in the system.
        /// If resellerId is specified, only the prefixes assigned to the enterprise/service provider within
        /// the given reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequestAsync instead.")]
        public static async Task<SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse> SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest(this OcipClientBase client, SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all enterprise trunk prefixes in the system.
        /// If resellerId is specified, only the prefixes assigned to the enterprise/service provider within
        /// the given reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse> SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequestAsync(this OcipClientBase client, SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse;
        }
        /// <summary>
        /// Request a summary table of all enterprise trunk number ranges in the system.
        /// If resellerId is specified, the number ranges assigned to the enterprises/service providers
        /// within the reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListRequestAsync instead.")]
        public static async Task<SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse> SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest(this OcipClientBase client, SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all enterprise trunk number ranges in the system.
        /// If resellerId is specified, the number ranges assigned to the enterprises/service providers
        /// within the reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse> SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListRequestAsync(this OcipClientBase client, SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse;
        }
        /// <summary>
        /// Get the route list setting and the list of number ranges assigned to a user.
        /// The response is either UserRouteListGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserRouteListGetRequest22Async instead.")]
        public static async Task<UserRouteListGetResponse22> UserRouteListGetRequest22(this OcipClientBase client, UserRouteListGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserRouteListGetResponse22;
        }

        /// <summary>
        /// Get the route list setting and the list of number ranges assigned to a user.
        /// The response is either UserRouteListGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<UserRouteListGetResponse22> UserRouteListGetRequest22Async(this OcipClientBase client, UserRouteListGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserRouteListGetResponse22;
        }
        /// <summary>
        /// Modify the route list setting and the list of number ranges and number prefixes assigned to a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserRouteListModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserRouteListModifyRequest(this OcipClientBase client, UserRouteListModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the route list setting and the list of number ranges and number prefixes assigned to a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserRouteListModifyRequestAsync(this OcipClientBase client, UserRouteListModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
