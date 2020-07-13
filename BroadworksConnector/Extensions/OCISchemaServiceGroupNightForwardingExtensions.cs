using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceGroupNightForwardingExtensions
    {

        /// <summary>
        /// Request to get the Group Night Forwarding group parameters.
        /// The response is either GroupGroupNightForwardingGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupNightForwardingGetRequestAsync instead.")]
        public static async Task<GroupGroupNightForwardingGetResponse> GroupGroupNightForwardingGetRequest(this OcipClientBase client, GroupGroupNightForwardingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGroupNightForwardingGetResponse;
        }

        /// <summary>
        /// Request to get the Group Night Forwarding group parameters.
        /// The response is either GroupGroupNightForwardingGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupNightForwardingGetResponse> GroupGroupNightForwardingGetRequestAsync(this OcipClientBase client, GroupGroupNightForwardingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGroupNightForwardingGetResponse;
        }
        /// <summary>
        /// Request to modify the Group Night Forwarding group parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupNightForwardingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupNightForwardingModifyRequest(this OcipClientBase client, GroupGroupNightForwardingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the Group Night Forwarding group parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupNightForwardingModifyRequestAsync(this OcipClientBase client, GroupGroupNightForwardingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the Group Night Forwarding system parameters.
        /// The response is either SystemGroupNightForwardingGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGroupNightForwardingGetRequestAsync instead.")]
        public static async Task<SystemGroupNightForwardingGetResponse> SystemGroupNightForwardingGetRequest(this OcipClientBase client, SystemGroupNightForwardingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemGroupNightForwardingGetResponse;
        }

        /// <summary>
        /// Request to get the Group Night Forwarding system parameters.
        /// The response is either SystemGroupNightForwardingGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGroupNightForwardingGetResponse> SystemGroupNightForwardingGetRequestAsync(this OcipClientBase client, SystemGroupNightForwardingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemGroupNightForwardingGetResponse;
        }
        /// <summary>
        /// Request to modify the Group Night Forwarding system parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemGroupNightForwardingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemGroupNightForwardingModifyRequest(this OcipClientBase client, SystemGroupNightForwardingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the Group Night Forwarding system parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGroupNightForwardingModifyRequestAsync(this OcipClientBase client, SystemGroupNightForwardingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the Group Night Forwarding user parameters.
        /// The response is either UserGroupNightForwardingGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGroupNightForwardingGetRequestAsync instead.")]
        public static async Task<UserGroupNightForwardingGetResponse> UserGroupNightForwardingGetRequest(this OcipClientBase client, UserGroupNightForwardingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGroupNightForwardingGetResponse;
        }

        /// <summary>
        /// Request to get the Group Night Forwarding user parameters.
        /// The response is either UserGroupNightForwardingGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserGroupNightForwardingGetResponse> UserGroupNightForwardingGetRequestAsync(this OcipClientBase client, UserGroupNightForwardingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGroupNightForwardingGetResponse;
        }
        /// <summary>
        /// Request to modify the Group Night Forwarding user parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGroupNightForwardingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserGroupNightForwardingModifyRequest(this OcipClientBase client, UserGroupNightForwardingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the Group Night Forwarding user parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserGroupNightForwardingModifyRequestAsync(this OcipClientBase client, UserGroupNightForwardingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
