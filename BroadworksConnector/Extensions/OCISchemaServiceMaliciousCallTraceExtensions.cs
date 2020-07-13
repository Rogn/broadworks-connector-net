using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceMaliciousCallTraceExtensions
    {

        /// <summary>
        /// Get the service provider's Malicious Call Trace settings.
        /// The response is either a ServiceProviderMaliciousCallTraceGetResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderMaliciousCallTraceGetRequestAsync instead.")]
        public static async Task<ServiceProviderMaliciousCallTraceGetResponse> ServiceProviderMaliciousCallTraceGetRequest(this OcipClientBase client, ServiceProviderMaliciousCallTraceGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderMaliciousCallTraceGetResponse;
        }

        /// <summary>
        /// Get the service provider's Malicious Call Trace settings.
        /// The response is either a ServiceProviderMaliciousCallTraceGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderMaliciousCallTraceGetResponse> ServiceProviderMaliciousCallTraceGetRequestAsync(this OcipClientBase client, ServiceProviderMaliciousCallTraceGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderMaliciousCallTraceGetResponse;
        }
        /// <summary>
        /// Modify the service provider's Malicious Call Trace settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderMaliciousCallTraceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderMaliciousCallTraceModifyRequest(this OcipClientBase client, ServiceProviderMaliciousCallTraceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the service provider's Malicious Call Trace settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderMaliciousCallTraceModifyRequestAsync(this OcipClientBase client, ServiceProviderMaliciousCallTraceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get Malicious Call Trace system parameters and the list of users that use the
        /// Malicious Call Trace feature.
        /// The response is either a SystemMaliciousCallTraceGetResponse or
        /// an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMaliciousCallTraceGetRequestAsync instead.")]
        public static async Task<SystemMaliciousCallTraceGetResponse> SystemMaliciousCallTraceGetRequest(this OcipClientBase client, SystemMaliciousCallTraceGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMaliciousCallTraceGetResponse;
        }

        /// <summary>
        /// Get Malicious Call Trace system parameters and the list of users that use the
        /// Malicious Call Trace feature.
        /// The response is either a SystemMaliciousCallTraceGetResponse or
        /// an ErrorResponse.
        /// </summary>
        public static async Task<SystemMaliciousCallTraceGetResponse> SystemMaliciousCallTraceGetRequestAsync(this OcipClientBase client, SystemMaliciousCallTraceGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMaliciousCallTraceGetResponse;
        }
        /// <summary>
        /// Modify a Malicious Call Trace system parameter.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMaliciousCallTraceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMaliciousCallTraceModifyRequest(this OcipClientBase client, SystemMaliciousCallTraceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Malicious Call Trace system parameter.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMaliciousCallTraceModifyRequestAsync(this OcipClientBase client, SystemMaliciousCallTraceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Malicious Call Trace.
        /// The response is either a UserMaliciousCallTraceGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMaliciousCallTraceGetRequestAsync instead.")]
        public static async Task<UserMaliciousCallTraceGetResponse> UserMaliciousCallTraceGetRequest(this OcipClientBase client, UserMaliciousCallTraceGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMaliciousCallTraceGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Malicious Call Trace.
        /// The response is either a UserMaliciousCallTraceGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserMaliciousCallTraceGetResponse> UserMaliciousCallTraceGetRequestAsync(this OcipClientBase client, UserMaliciousCallTraceGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMaliciousCallTraceGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Malicious Call Trace.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMaliciousCallTraceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserMaliciousCallTraceModifyRequest(this OcipClientBase client, UserMaliciousCallTraceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Malicious Call Trace.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserMaliciousCallTraceModifyRequestAsync(this OcipClientBase client, UserMaliciousCallTraceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
