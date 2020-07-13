using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceInCallServiceActivationExtensions
    {

        /// <summary>
        /// Request the service provider's DTMF based in-call service activation trigger attributes.The response is either a ServiceProviderInCallServiceActivationGetResponse17 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderInCallServiceActivationGetRequest17Async instead.")]
        public static async Task<ServiceProviderInCallServiceActivationGetResponse17> ServiceProviderInCallServiceActivationGetRequest17(this OcipClientBase client, ServiceProviderInCallServiceActivationGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderInCallServiceActivationGetResponse17;
        }

        /// <summary>
        /// Request the service provider's DTMF based in-call service activation trigger attributes.The response is either a ServiceProviderInCallServiceActivationGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderInCallServiceActivationGetResponse17> ServiceProviderInCallServiceActivationGetRequest17Async(this OcipClientBase client, ServiceProviderInCallServiceActivationGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderInCallServiceActivationGetResponse17;
        }
        /// <summary>
        /// Modifies the service provider's DTMF based in-call service activation trigger attributes.The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderInCallServiceActivationModifyRequest17Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderInCallServiceActivationModifyRequest17(this OcipClientBase client, ServiceProviderInCallServiceActivationModifyRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the service provider's DTMF based in-call service activation trigger attributes.The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderInCallServiceActivationModifyRequest17Async(this OcipClientBase client, ServiceProviderInCallServiceActivationModifyRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system's DTMF based in-call service activation trigger attributes. The response is either a SystemInCallServiceActivationGetResponse17 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemInCallServiceActivationGetRequest17Async instead.")]
        public static async Task<SystemInCallServiceActivationGetResponse17> SystemInCallServiceActivationGetRequest17(this OcipClientBase client, SystemInCallServiceActivationGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemInCallServiceActivationGetResponse17;
        }

        /// <summary>
        /// Request the system's DTMF based in-call service activation trigger attributes. The response is either a SystemInCallServiceActivationGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemInCallServiceActivationGetResponse17> SystemInCallServiceActivationGetRequest17Async(this OcipClientBase client, SystemInCallServiceActivationGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemInCallServiceActivationGetResponse17;
        }
        /// <summary>
        /// Modifies the system's DTMF based in-call service activation trigger  attributes.The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemInCallServiceActivationModifyRequest17Async instead.")]
        public static async Task<SuccessResponse> SystemInCallServiceActivationModifyRequest17(this OcipClientBase client, SystemInCallServiceActivationModifyRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the system's DTMF based in-call service activation trigger  attributes.The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemInCallServiceActivationModifyRequest17Async(this OcipClientBase client, SystemInCallServiceActivationModifyRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with In-Call Service Activation.
        /// The response is either a UserInCallServiceActivationGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserInCallServiceActivationGetRequestAsync instead.")]
        public static async Task<UserInCallServiceActivationGetResponse> UserInCallServiceActivationGetRequest(this OcipClientBase client, UserInCallServiceActivationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserInCallServiceActivationGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with In-Call Service Activation.
        /// The response is either a UserInCallServiceActivationGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserInCallServiceActivationGetResponse> UserInCallServiceActivationGetRequestAsync(this OcipClientBase client, UserInCallServiceActivationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserInCallServiceActivationGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with In-Call Service Activation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserInCallServiceActivationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserInCallServiceActivationModifyRequest(this OcipClientBase client, UserInCallServiceActivationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with In-Call Service Activation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserInCallServiceActivationModifyRequestAsync(this OcipClientBase client, UserInCallServiceActivationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
