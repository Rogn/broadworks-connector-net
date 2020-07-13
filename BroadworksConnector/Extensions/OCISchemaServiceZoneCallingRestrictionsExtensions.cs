using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceZoneCallingRestrictionsExtensions
    {

        /// <summary>
        /// Gets the Service Provider/Enterprise level Zone Calling Restrictions Policies.
        /// The response is ServiceProviderZoneCallingRestrictionsGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderZoneCallingRestrictionsGetRequestAsync instead.")]
        public static async Task<ServiceProviderZoneCallingRestrictionsGetResponse> ServiceProviderZoneCallingRestrictionsGetRequest(this OcipClientBase client, ServiceProviderZoneCallingRestrictionsGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderZoneCallingRestrictionsGetResponse;
        }

        /// <summary>
        /// Gets the Service Provider/Enterprise level Zone Calling Restrictions Policies.
        /// The response is ServiceProviderZoneCallingRestrictionsGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderZoneCallingRestrictionsGetResponse> ServiceProviderZoneCallingRestrictionsGetRequestAsync(this OcipClientBase client, ServiceProviderZoneCallingRestrictionsGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderZoneCallingRestrictionsGetResponse;
        }
        /// <summary>
        /// Modifies the Service Provider/Enterprise level Zone Calling Restrictions Policies.
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderZoneCallingRestrictionsModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderZoneCallingRestrictionsModifyRequest(this OcipClientBase client, ServiceProviderZoneCallingRestrictionsModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the Service Provider/Enterprise level Zone Calling Restrictions Policies.
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderZoneCallingRestrictionsModifyRequestAsync(this OcipClientBase client, ServiceProviderZoneCallingRestrictionsModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Gets the home zone for a user
        /// The response is either a UserZoneCallingRestrictionsGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserZoneCallingRestrictionsGetRequestAsync instead.")]
        public static async Task<UserZoneCallingRestrictionsGetResponse> UserZoneCallingRestrictionsGetRequest(this OcipClientBase client, UserZoneCallingRestrictionsGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserZoneCallingRestrictionsGetResponse;
        }

        /// <summary>
        /// Gets the home zone for a user
        /// The response is either a UserZoneCallingRestrictionsGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserZoneCallingRestrictionsGetResponse> UserZoneCallingRestrictionsGetRequestAsync(this OcipClientBase client, UserZoneCallingRestrictionsGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserZoneCallingRestrictionsGetResponse;
        }
        /// <summary>
        /// Modify the home zone for a user
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserZoneCallingRestrictionsModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserZoneCallingRestrictionsModifyRequest(this OcipClientBase client, UserZoneCallingRestrictionsModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the home zone for a user
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserZoneCallingRestrictionsModifyRequestAsync(this OcipClientBase client, UserZoneCallingRestrictionsModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
