using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaResellerExtensions
    {

        /// <summary>
        /// Add a reseller.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerAddRequest(this OcipClientBase client, ResellerAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a reseller.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAddRequestAsync(this OcipClientBase client, ResellerAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a reseller administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerAdminAddRequest(this OcipClientBase client, ResellerAdminAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a reseller administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAdminAddRequestAsync(this OcipClientBase client, ResellerAdminAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a reseller administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerAdminDeleteRequest(this OcipClientBase client, ResellerAdminDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a reseller administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAdminDeleteRequestAsync(this OcipClientBase client, ResellerAdminDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of reseller administrators.
        /// The response is either a ResellerAdminGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminGetListRequestAsync instead.")]
        public static async Task<ResellerAdminGetListResponse> ResellerAdminGetListRequest(this OcipClientBase client, ResellerAdminGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerAdminGetListResponse;
        }

        /// <summary>
        /// Get a list of reseller administrators.
        /// The response is either a ResellerAdminGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerAdminGetListResponse> ResellerAdminGetListRequestAsync(this OcipClientBase client, ResellerAdminGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerAdminGetListResponse;
        }
        /// <summary>
        /// Get a reseller administrators profile.
        /// The response is either a ResellerAdminGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminGetRequestAsync instead.")]
        public static async Task<ResellerAdminGetResponse> ResellerAdminGetRequest(this OcipClientBase client, ResellerAdminGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerAdminGetResponse;
        }

        /// <summary>
        /// Get a reseller administrators profile.
        /// The response is either a ResellerAdminGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerAdminGetResponse> ResellerAdminGetRequestAsync(this OcipClientBase client, ResellerAdminGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerAdminGetResponse;
        }
        /// <summary>
        /// Modify the profile for a reseller administrator.
        /// Since old password is not specified here, any password rule related to old password does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerAdminModifyRequest(this OcipClientBase client, ResellerAdminModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the profile for a reseller administrator.
        /// Since old password is not specified here, any password rule related to old password does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerAdminModifyRequestAsync(this OcipClientBase client, ResellerAdminModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a reseller call admission control policies.
        /// The response is either a ResellerCallAdmissionControlPoliciesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerCallAdmissionControlPoliciesGetRequestAsync instead.")]
        public static async Task<ResellerCallAdmissionControlPoliciesGetResponse> ResellerCallAdmissionControlPoliciesGetRequest(this OcipClientBase client, ResellerCallAdmissionControlPoliciesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerCallAdmissionControlPoliciesGetResponse;
        }

        /// <summary>
        /// Get a reseller call admission control policies.
        /// The response is either a ResellerCallAdmissionControlPoliciesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerCallAdmissionControlPoliciesGetResponse> ResellerCallAdmissionControlPoliciesGetRequestAsync(this OcipClientBase client, ResellerCallAdmissionControlPoliciesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerCallAdmissionControlPoliciesGetResponse;
        }
        /// <summary>
        /// Modify the reseller call admission control policies.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerCallAdmissionControlPoliciesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerCallAdmissionControlPoliciesModifyRequest(this OcipClientBase client, ResellerCallAdmissionControlPoliciesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller call admission control policies.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerCallAdmissionControlPoliciesModifyRequestAsync(this OcipClientBase client, ResellerCallAdmissionControlPoliciesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a reseller.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerDeleteRequest(this OcipClientBase client, ResellerDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a reseller.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerDeleteRequestAsync(this OcipClientBase client, ResellerDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the reseller level data associated with Emergency Call
        /// Notification.
        /// The response is either a ResellerEmergencyCallNotificationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerEmergencyCallNotificationGetRequestAsync instead.")]
        public static async Task<ResellerEmergencyCallNotificationGetResponse> ResellerEmergencyCallNotificationGetRequest(this OcipClientBase client, ResellerEmergencyCallNotificationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerEmergencyCallNotificationGetResponse;
        }

        /// <summary>
        /// Request the reseller level data associated with Emergency Call
        /// Notification.
        /// The response is either a ResellerEmergencyCallNotificationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerEmergencyCallNotificationGetResponse> ResellerEmergencyCallNotificationGetRequestAsync(this OcipClientBase client, ResellerEmergencyCallNotificationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerEmergencyCallNotificationGetResponse;
        }
        /// <summary>
        /// Modify the reseller level data associated with Emergency Call
        /// Notification.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerEmergencyCallNotificationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerEmergencyCallNotificationModifyRequest(this OcipClientBase client, ResellerEmergencyCallNotificationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller level data associated with Emergency Call
        /// Notification.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerEmergencyCallNotificationModifyRequestAsync(this OcipClientBase client, ResellerEmergencyCallNotificationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a list of resellers in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a ResellerGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerGetListRequestAsync instead.")]
        public static async Task<ResellerGetListResponse> ResellerGetListRequest(this OcipClientBase client, ResellerGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerGetListResponse;
        }

        /// <summary>
        /// Request a list of resellers in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a ResellerGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerGetListResponse> ResellerGetListRequestAsync(this OcipClientBase client, ResellerGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerGetListResponse;
        }
        /// <summary>
        /// Get the profile for a reseller.
        /// The response is either ResellerGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerGetRequestAsync instead.")]
        public static async Task<ResellerGetResponse> ResellerGetRequest(this OcipClientBase client, ResellerGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerGetResponse;
        }

        /// <summary>
        /// Get the profile for a reseller.
        /// The response is either ResellerGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ResellerGetResponse> ResellerGetRequestAsync(this OcipClientBase client, ResellerGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerGetResponse;
        }
        /// <summary>
        /// Request the reseller Mail parameters.
        /// The response is either a ResellerMailParametersGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerMailParametersGetRequestAsync instead.")]
        public static async Task<ResellerMailParametersGetResponse> ResellerMailParametersGetRequest(this OcipClientBase client, ResellerMailParametersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerMailParametersGetResponse;
        }

        /// <summary>
        /// Request the reseller Mail parameters.
        /// The response is either a ResellerMailParametersGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<ResellerMailParametersGetResponse> ResellerMailParametersGetRequestAsync(this OcipClientBase client, ResellerMailParametersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerMailParametersGetResponse;
        }
        /// <summary>
        /// Request to modify the reseller Mail parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerMailParametersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerMailParametersModifyRequest(this OcipClientBase client, ResellerMailParametersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the reseller Mail parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerMailParametersModifyRequestAsync(this OcipClientBase client, ResellerMailParametersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the reseller profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerModifyRequest(this OcipClientBase client, ResellerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerModifyRequestAsync(this OcipClientBase client, ResellerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of Network Classes of Service to a reseller.
        /// A default Network Class of Service is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerNetworkClassOfServiceAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceAssignListRequest(this OcipClientBase client, ResellerNetworkClassOfServiceAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Network Classes of Service to a reseller.
        /// A default Network Class of Service is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceAssignListRequestAsync(this OcipClientBase client, ResellerNetworkClassOfServiceAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Network Classes of Service assigned to a reseller.
        /// The response is either a ResellerNetworkClassOfServiceGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerNetworkClassOfServiceGetAssignedListRequestAsync instead.")]
        public static async Task<ResellerNetworkClassOfServiceGetAssignedListResponse> ResellerNetworkClassOfServiceGetAssignedListRequest(this OcipClientBase client, ResellerNetworkClassOfServiceGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerNetworkClassOfServiceGetAssignedListResponse;
        }

        /// <summary>
        /// Get a list of Network Classes of Service assigned to a reseller.
        /// The response is either a ResellerNetworkClassOfServiceGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerNetworkClassOfServiceGetAssignedListResponse> ResellerNetworkClassOfServiceGetAssignedListRequestAsync(this OcipClientBase client, ResellerNetworkClassOfServiceGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerNetworkClassOfServiceGetAssignedListResponse;
        }
        /// <summary>
        /// Get a list of service provider/enterprises within a reseller that have a given
        /// Network Class of Service assigned.
        /// The response is either a ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequestAsync instead.")]
        public static async Task<ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse> ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest(this OcipClientBase client, ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse;
        }

        /// <summary>
        /// Get a list of service provider/enterprises within a reseller that have a given
        /// Network Class of Service assigned.
        /// The response is either a ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse> ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequestAsync(this OcipClientBase client, ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse;
        }
        /// <summary>
        /// Modifies the default Network Classes of Service of a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerNetworkClassOfServiceModifyDefaultRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceModifyDefaultRequest(this OcipClientBase client, ResellerNetworkClassOfServiceModifyDefaultRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the default Network Classes of Service of a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceModifyDefaultRequestAsync(this OcipClientBase client, ResellerNetworkClassOfServiceModifyDefaultRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Unassign a list of Network Classes of Service from a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerNetworkClassOfServiceUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceUnassignListRequest(this OcipClientBase client, ResellerNetworkClassOfServiceUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Network Classes of Service from a reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerNetworkClassOfServiceUnassignListRequestAsync(this OcipClientBase client, ResellerNetworkClassOfServiceUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the reseller service authorization
        /// The response is either ResellerServiceAuthorizationGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerServiceAuthorizationGetRequestAsync instead.")]
        public static async Task<ResellerServiceAuthorizationGetResponse> ResellerServiceAuthorizationGetRequest(this OcipClientBase client, ResellerServiceAuthorizationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerServiceAuthorizationGetResponse;
        }

        /// <summary>
        /// Get the reseller service authorization
        /// The response is either ResellerServiceAuthorizationGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ResellerServiceAuthorizationGetResponse> ResellerServiceAuthorizationGetRequestAsync(this OcipClientBase client, ResellerServiceAuthorizationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerServiceAuthorizationGetResponse;
        }
        /// <summary>
        /// Modify the reseller service authorization file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerServiceAuthorizationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerServiceAuthorizationModifyRequest(this OcipClientBase client, ResellerServiceAuthorizationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller service authorization file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerServiceAuthorizationModifyRequestAsync(this OcipClientBase client, ResellerServiceAuthorizationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
