using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceRoutePointExtensions
    {

        /// <summary>
        /// Add a Route Point DNIS.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointAddDNISRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointAddDNISRequest(this OcipClientBase client, GroupRoutePointAddDNISRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Route Point DNIS.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointAddDNISRequestAsync(this OcipClientBase client, GroupRoutePointAddDNISRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Route Point instance to a group.
        /// The Route Point is a Call Center queue that performs the same function but
        /// allows an external system to perform the distribution of calls instead of making
        /// those decisions itself.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointAddInstanceRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointAddInstanceRequest22(this OcipClientBase client, GroupRoutePointAddInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Route Point instance to a group.
        /// The Route Point is a Call Center queue that performs the same function but
        /// allows an external system to perform the distribution of calls instead of making
        /// those decisions itself.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointAddInstanceRequest22Async(this OcipClientBase client, GroupRoutePointAddInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a route point's bounced call settings.
        /// The response is either a GroupRoutePointBouncedCallGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointBouncedCallGetRequestAsync instead.")]
        public static async Task<GroupRoutePointBouncedCallGetResponse> GroupRoutePointBouncedCallGetRequest(this OcipClientBase client, GroupRoutePointBouncedCallGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointBouncedCallGetResponse;
        }

        /// <summary>
        /// Get a route point's bounced call settings.
        /// The response is either a GroupRoutePointBouncedCallGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointBouncedCallGetResponse> GroupRoutePointBouncedCallGetRequestAsync(this OcipClientBase client, GroupRoutePointBouncedCallGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointBouncedCallGetResponse;
        }
        /// <summary>
        /// Modify a route point's bounced call settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointBouncedCallModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointBouncedCallModifyRequest(this OcipClientBase client, GroupRoutePointBouncedCallModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's bounced call settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointBouncedCallModifyRequestAsync(this OcipClientBase client, GroupRoutePointBouncedCallModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a route point's DNIS.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointDeleteDNISRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointDeleteDNISRequest(this OcipClientBase client, GroupRoutePointDeleteDNISRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a route point's DNIS.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointDeleteDNISRequestAsync(this OcipClientBase client, GroupRoutePointDeleteDNISRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Route Point instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointDeleteInstanceRequest(this OcipClientBase client, GroupRoutePointDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Route Point instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointDeleteInstanceRequestAsync(this OcipClientBase client, GroupRoutePointDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the distinctive ringing configuration values for route point.
        /// The response is either a GroupRoutePointDistinctiveRingingGetResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointDistinctiveRingingGetRequestAsync instead.")]
        public static async Task<GroupRoutePointDistinctiveRingingGetResponse> GroupRoutePointDistinctiveRingingGetRequest(this OcipClientBase client, GroupRoutePointDistinctiveRingingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointDistinctiveRingingGetResponse;
        }

        /// <summary>
        /// Get the distinctive ringing configuration values for route point.
        /// The response is either a GroupRoutePointDistinctiveRingingGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointDistinctiveRingingGetResponse> GroupRoutePointDistinctiveRingingGetRequestAsync(this OcipClientBase client, GroupRoutePointDistinctiveRingingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointDistinctiveRingingGetResponse;
        }
        /// <summary>
        /// Modify the distinctive ringing configuration values for route point.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointDistinctiveRingingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointDistinctiveRingingModifyRequest(this OcipClientBase client, GroupRoutePointDistinctiveRingingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the distinctive ringing configuration values for route point.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointDistinctiveRingingModifyRequestAsync(this OcipClientBase client, GroupRoutePointDistinctiveRingingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a route point's forced forwarding settings.
        /// The response is either a GroupRoutePointForcedForwardingGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointForcedForwardingGetRequest20Async instead.")]
        public static async Task<GroupRoutePointForcedForwardingGetResponse20> GroupRoutePointForcedForwardingGetRequest20(this OcipClientBase client, GroupRoutePointForcedForwardingGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointForcedForwardingGetResponse20;
        }

        /// <summary>
        /// Get a route point's forced forwarding settings.
        /// The response is either a GroupRoutePointForcedForwardingGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointForcedForwardingGetResponse20> GroupRoutePointForcedForwardingGetRequest20Async(this OcipClientBase client, GroupRoutePointForcedForwardingGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointForcedForwardingGetResponse20;
        }
        /// <summary>
        /// Modify a route point's forced forwarding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointForcedForwardingModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointForcedForwardingModifyRequest20(this OcipClientBase client, GroupRoutePointForcedForwardingModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's forced forwarding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointForcedForwardingModifyRequest20Async(this OcipClientBase client, GroupRoutePointForcedForwardingModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a route point's announcement settings.
        /// The response is either a GroupRoutePointGetAnnouncementResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetAnnouncementRequest20Async instead.")]
        public static async Task<GroupRoutePointGetAnnouncementResponse20> GroupRoutePointGetAnnouncementRequest20(this OcipClientBase client, GroupRoutePointGetAnnouncementRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetAnnouncementResponse20;
        }

        /// <summary>
        /// Get a route point's announcement settings.
        /// The response is either a GroupRoutePointGetAnnouncementResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetAnnouncementResponse20> GroupRoutePointGetAnnouncementRequest20Async(this OcipClientBase client, GroupRoutePointGetAnnouncementRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetAnnouncementResponse20;
        }
        /// <summary>
        /// Get a route point's announcement settings.
        /// The response is either a GroupRoutePointGetAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetAnnouncementRequest22Async instead.")]
        public static async Task<GroupRoutePointGetAnnouncementResponse22> GroupRoutePointGetAnnouncementRequest22(this OcipClientBase client, GroupRoutePointGetAnnouncementRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetAnnouncementResponse22;
        }

        /// <summary>
        /// Get a route point's announcement settings.
        /// The response is either a GroupRoutePointGetAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetAnnouncementResponse22> GroupRoutePointGetAnnouncementRequest22Async(this OcipClientBase client, GroupRoutePointGetAnnouncementRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetAnnouncementResponse22;
        }
        /// <summary>
        /// Get a list of agent who selected the DNIS as the outgoing call.
        /// The response is either GroupRoutePointGetDNISAgentListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetDNISAgentListRequestAsync instead.")]
        public static async Task<GroupRoutePointGetDNISAgentListResponse> GroupRoutePointGetDNISAgentListRequest(this OcipClientBase client, GroupRoutePointGetDNISAgentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetDNISAgentListResponse;
        }

        /// <summary>
        /// Get a list of agent who selected the DNIS as the outgoing call.
        /// The response is either GroupRoutePointGetDNISAgentListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISAgentListResponse> GroupRoutePointGetDNISAgentListRequestAsync(this OcipClientBase client, GroupRoutePointGetDNISAgentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetDNISAgentListResponse;
        }
        /// <summary>
        /// Get a route point's DNIS Announcements
        /// The response is either a GroupRoutePointGetDNISAnnouncementResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetDNISAnnouncementRequest20Async instead.")]
        public static async Task<GroupRoutePointGetDNISAnnouncementResponse20> GroupRoutePointGetDNISAnnouncementRequest20(this OcipClientBase client, GroupRoutePointGetDNISAnnouncementRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetDNISAnnouncementResponse20;
        }

        /// <summary>
        /// Get a route point's DNIS Announcements
        /// The response is either a GroupRoutePointGetDNISAnnouncementResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISAnnouncementResponse20> GroupRoutePointGetDNISAnnouncementRequest20Async(this OcipClientBase client, GroupRoutePointGetDNISAnnouncementRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetDNISAnnouncementResponse20;
        }
        /// <summary>
        /// Get a route point's DNIS Announcements
        /// The response is either a GroupRoutePointGetDNISAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetDNISAnnouncementRequest22Async instead.")]
        public static async Task<GroupRoutePointGetDNISAnnouncementResponse22> GroupRoutePointGetDNISAnnouncementRequest22(this OcipClientBase client, GroupRoutePointGetDNISAnnouncementRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetDNISAnnouncementResponse22;
        }

        /// <summary>
        /// Get a route point's DNIS Announcements
        /// The response is either a GroupRoutePointGetDNISAnnouncementResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISAnnouncementResponse22> GroupRoutePointGetDNISAnnouncementRequest22Async(this OcipClientBase client, GroupRoutePointGetDNISAnnouncementRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetDNISAnnouncementResponse22;
        }
        /// <summary>
        /// Get a list of DNIS that are configured for a Route Point.
        /// The response is either GroupRoutePointGetDNISListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetDNISListRequestAsync instead.")]
        public static async Task<GroupRoutePointGetDNISListResponse> GroupRoutePointGetDNISListRequest(this OcipClientBase client, GroupRoutePointGetDNISListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetDNISListResponse;
        }

        /// <summary>
        /// Get a list of DNIS that are configured for a Route Point.
        /// The response is either GroupRoutePointGetDNISListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISListResponse> GroupRoutePointGetDNISListRequestAsync(this OcipClientBase client, GroupRoutePointGetDNISListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetDNISListResponse;
        }
        /// <summary>
        /// Get a route point's DNIS.
        /// The response is either a GroupRoutePointGetDNISResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetDNISRequestAsync instead.")]
        public static async Task<GroupRoutePointGetDNISResponse> GroupRoutePointGetDNISRequest(this OcipClientBase client, GroupRoutePointGetDNISRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetDNISResponse;
        }

        /// <summary>
        /// Get a route point's DNIS.
        /// The response is either a GroupRoutePointGetDNISResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISResponse> GroupRoutePointGetDNISRequestAsync(this OcipClientBase client, GroupRoutePointGetDNISRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetDNISResponse;
        }
        /// <summary>
        /// Get the route point failover policy.
        /// The response is either a GroupRoutePointGetFailoverPolicyResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetFailoverPolicyRequestAsync instead.")]
        public static async Task<GroupRoutePointGetFailoverPolicyResponse> GroupRoutePointGetFailoverPolicyRequest(this OcipClientBase client, GroupRoutePointGetFailoverPolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetFailoverPolicyResponse;
        }

        /// <summary>
        /// Get the route point failover policy.
        /// The response is either a GroupRoutePointGetFailoverPolicyResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetFailoverPolicyResponse> GroupRoutePointGetFailoverPolicyRequestAsync(this OcipClientBase client, GroupRoutePointGetFailoverPolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetFailoverPolicyResponse;
        }
        /// <summary>
        /// Get a list of Route Point instances within a group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// The response is either GroupRoutePointGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetInstanceListRequestAsync instead.")]
        public static async Task<GroupRoutePointGetInstanceListResponse> GroupRoutePointGetInstanceListRequest(this OcipClientBase client, GroupRoutePointGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetInstanceListResponse;
        }

        /// <summary>
        /// Get a list of Route Point instances within a group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// The response is either GroupRoutePointGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupRoutePointGetInstanceListResponse> GroupRoutePointGetInstanceListRequestAsync(this OcipClientBase client, GroupRoutePointGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetInstanceListResponse;
        }
        /// <summary>
        /// Request to get all the information of a Route Point instance.
        /// The response is either GroupRoutePointGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetInstanceRequest22Async instead.")]
        public static async Task<GroupRoutePointGetInstanceResponse19sp1> GroupRoutePointGetInstanceRequest22(this OcipClientBase client, GroupRoutePointGetInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a Route Point instance.
        /// The response is either GroupRoutePointGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetInstanceResponse19sp1> GroupRoutePointGetInstanceRequest22Async(this OcipClientBase client, GroupRoutePointGetInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetInstanceResponse19sp1;
        }
        /// <summary>
        /// Get a route point's holiday service settings.
        /// The response is either a GroupRoutePointHolidayServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointHolidayServiceGetRequest20Async instead.")]
        public static async Task<GroupRoutePointHolidayServiceGetResponse20> GroupRoutePointHolidayServiceGetRequest20(this OcipClientBase client, GroupRoutePointHolidayServiceGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointHolidayServiceGetResponse20;
        }

        /// <summary>
        /// Get a route point's holiday service settings.
        /// The response is either a GroupRoutePointHolidayServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointHolidayServiceGetResponse20> GroupRoutePointHolidayServiceGetRequest20Async(this OcipClientBase client, GroupRoutePointHolidayServiceGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointHolidayServiceGetResponse20;
        }
        /// <summary>
        /// Modify a route point's holiday service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointHolidayServiceModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointHolidayServiceModifyRequest20(this OcipClientBase client, GroupRoutePointHolidayServiceModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's holiday service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointHolidayServiceModifyRequest20Async(this OcipClientBase client, GroupRoutePointHolidayServiceModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Initiate manual failover for the Route Point.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointManualFailoverRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointManualFailoverRequest(this OcipClientBase client, GroupRoutePointManualFailoverRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Initiate manual failover for the Route Point.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointManualFailoverRequestAsync(this OcipClientBase client, GroupRoutePointManualFailoverRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to set the active status of Route Point instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyActiveInstanceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyActiveInstanceListRequest(this OcipClientBase client, GroupRoutePointModifyActiveInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of Route Point instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyActiveInstanceListRequestAsync(this OcipClientBase client, GroupRoutePointModifyActiveInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a route point's announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyAnnouncementRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyAnnouncementRequest20(this OcipClientBase client, GroupRoutePointModifyAnnouncementRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyAnnouncementRequest20Async(this OcipClientBase client, GroupRoutePointModifyAnnouncementRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a route point DNIS announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyDNISAnnouncementRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISAnnouncementRequest20(this OcipClientBase client, GroupRoutePointModifyDNISAnnouncementRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point DNIS announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISAnnouncementRequest20Async(this OcipClientBase client, GroupRoutePointModifyDNISAnnouncementRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the setting that are configured for all the DNIS in a Route Point.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyDNISParametersRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISParametersRequest(this OcipClientBase client, GroupRoutePointModifyDNISParametersRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the setting that are configured for all the DNIS in a Route Point.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISParametersRequestAsync(this OcipClientBase client, GroupRoutePointModifyDNISParametersRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a route point's DNIS settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyDNISRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISRequest(this OcipClientBase client, GroupRoutePointModifyDNISRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's DNIS settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISRequestAsync(this OcipClientBase client, GroupRoutePointModifyDNISRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the route point failover policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyFailoverPolicyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyFailoverPolicyRequest(this OcipClientBase client, GroupRoutePointModifyFailoverPolicyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the route point failover policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyFailoverPolicyRequestAsync(this OcipClientBase client, GroupRoutePointModifyFailoverPolicyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a Route Point instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyInstanceRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyInstanceRequest22(this OcipClientBase client, GroupRoutePointModifyInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Route Point instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyInstanceRequest22Async(this OcipClientBase client, GroupRoutePointModifyInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a route point's night service settings.
        /// The response is either a GroupRoutePointNightServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointNightServiceGetRequest20Async instead.")]
        public static async Task<GroupRoutePointNightServiceGetResponse20> GroupRoutePointNightServiceGetRequest20(this OcipClientBase client, GroupRoutePointNightServiceGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointNightServiceGetResponse20;
        }

        /// <summary>
        /// Get a route point's night service settings.
        /// The response is either a GroupRoutePointNightServiceGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointNightServiceGetResponse20> GroupRoutePointNightServiceGetRequest20Async(this OcipClientBase client, GroupRoutePointNightServiceGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointNightServiceGetResponse20;
        }
        /// <summary>
        /// Modify a route point's night service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointNightServiceModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointNightServiceModifyRequest20(this OcipClientBase client, GroupRoutePointNightServiceModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's night service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointNightServiceModifyRequest20Async(this OcipClientBase client, GroupRoutePointNightServiceModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a route point's overflow settings.
        /// The response is either a GroupRoutePointOverflowGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointOverflowGetRequest20Async instead.")]
        public static async Task<GroupRoutePointOverflowGetResponse20> GroupRoutePointOverflowGetRequest20(this OcipClientBase client, GroupRoutePointOverflowGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointOverflowGetResponse20;
        }

        /// <summary>
        /// Get a route point's overflow settings.
        /// The response is either a GroupRoutePointOverflowGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointOverflowGetResponse20> GroupRoutePointOverflowGetRequest20Async(this OcipClientBase client, GroupRoutePointOverflowGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointOverflowGetResponse20;
        }
        /// <summary>
        /// Modify a route point's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointOverflowModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointOverflowModifyRequest20(this OcipClientBase client, GroupRoutePointOverflowModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointOverflowModifyRequest20Async(this OcipClientBase client, GroupRoutePointOverflowModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeAddRequest(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeAddRequestAsync(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeDeleteRequest(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeDeleteRequestAsync(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of Route Point Level and Organization Level Call Disposition Codes.
        /// The response is either GroupRoutePointQueueCallDispositionCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeGetListRequestAsync instead.")]
        public static async Task<GroupRoutePointQueueCallDispositionCodeGetListResponse> GroupRoutePointQueueCallDispositionCodeGetListRequest(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointQueueCallDispositionCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of Route Point Level and Organization Level Call Disposition Codes.
        /// The response is either GroupRoutePointQueueCallDispositionCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointQueueCallDispositionCodeGetListResponse> GroupRoutePointQueueCallDispositionCodeGetListRequestAsync(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointQueueCallDispositionCodeGetListResponse;
        }
        /// <summary>
        /// Get a Route Point Call Disposition Code.
        /// The response is either GroupRoutePointQueueCallDispositionCodeGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeGetRequestAsync instead.")]
        public static async Task<GroupRoutePointQueueCallDispositionCodeGetResponse> GroupRoutePointQueueCallDispositionCodeGetRequest(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointQueueCallDispositionCodeGetResponse;
        }

        /// <summary>
        /// Get a Route Point Call Disposition Code.
        /// The response is either GroupRoutePointQueueCallDispositionCodeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointQueueCallDispositionCodeGetResponse> GroupRoutePointQueueCallDispositionCodeGetRequestAsync(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointQueueCallDispositionCodeGetResponse;
        }
        /// <summary>
        /// Modify a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeModifyRequest(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Route Point Call Disposition Code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeModifyRequestAsync(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the queue level data associated with Route Point Call Disposition Code Settings.
        /// The response is either an GroupRoutePointQueueCallDispositionCodeSettingsGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeSettingsGetRequestAsync instead.")]
        public static async Task<GroupRoutePointQueueCallDispositionCodeSettingsGetResponse> GroupRoutePointQueueCallDispositionCodeSettingsGetRequest(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeSettingsGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointQueueCallDispositionCodeSettingsGetResponse;
        }

        /// <summary>
        /// Request the queue level data associated with Route Point Call Disposition Code Settings.
        /// The response is either an GroupRoutePointQueueCallDispositionCodeSettingsGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointQueueCallDispositionCodeSettingsGetResponse> GroupRoutePointQueueCallDispositionCodeSettingsGetRequestAsync(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeSettingsGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointQueueCallDispositionCodeSettingsGetResponse;
        }
        /// <summary>
        /// Modify the queue level data associated with Route Point Agents Unavailable Code Settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointQueueCallDispositionCodeSettingsModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeSettingsModifyRequest(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeSettingsModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the queue level data associated with Route Point Agents Unavailable Code Settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointQueueCallDispositionCodeSettingsModifyRequestAsync(this OcipClientBase client, GroupRoutePointQueueCallDispositionCodeSettingsModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of available Route Point Call Disposition Codes to be used by a client.
        /// The response is either UserRoutePointCallDispositionCodeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserRoutePointCallDispositionCodeGetAvailableListRequestAsync instead.")]
        public static async Task<UserRoutePointCallDispositionCodeGetAvailableListResponse> UserRoutePointCallDispositionCodeGetAvailableListRequest(this OcipClientBase client, UserRoutePointCallDispositionCodeGetAvailableListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserRoutePointCallDispositionCodeGetAvailableListResponse;
        }

        /// <summary>
        /// Get the list of available Route Point Call Disposition Codes to be used by a client.
        /// The response is either UserRoutePointCallDispositionCodeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserRoutePointCallDispositionCodeGetAvailableListResponse> UserRoutePointCallDispositionCodeGetAvailableListRequestAsync(this OcipClientBase client, UserRoutePointCallDispositionCodeGetAvailableListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserRoutePointCallDispositionCodeGetAvailableListResponse;
        }
        /// <summary>
        /// Get a list of Route Point supervisors assigned to a user.
        /// The response is either a UserRoutePointSupervisorGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserRoutePointSupervisorGetListRequestAsync instead.")]
        public static async Task<UserRoutePointSupervisorGetListResponse> UserRoutePointSupervisorGetListRequest(this OcipClientBase client, UserRoutePointSupervisorGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserRoutePointSupervisorGetListResponse;
        }

        /// <summary>
        /// Get a list of Route Point supervisors assigned to a user.
        /// The response is either a UserRoutePointSupervisorGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserRoutePointSupervisorGetListResponse> UserRoutePointSupervisorGetListRequestAsync(this OcipClientBase client, UserRoutePointSupervisorGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserRoutePointSupervisorGetListResponse;
        }
        /// <summary>
        /// Request to modify the Route Point supervisor list for a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserRoutePointSupervisorModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserRoutePointSupervisorModifyListRequest(this OcipClientBase client, UserRoutePointSupervisorModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the Route Point supervisor list for a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserRoutePointSupervisorModifyListRequestAsync(this OcipClientBase client, UserRoutePointSupervisorModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
