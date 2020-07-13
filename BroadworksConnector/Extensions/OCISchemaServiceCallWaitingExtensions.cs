using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallWaitingExtensions
    {

        /// <summary>
        /// Request the system level data associated with Call Waiting.
        /// The response is either a SystemCallWaitingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallWaitingGetRequestAsync instead.")]
        public static async Task<SystemCallWaitingGetResponse> SystemCallWaitingGetRequest(this OcipClientBase client, SystemCallWaitingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallWaitingGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Call Waiting.
        /// The response is either a SystemCallWaitingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallWaitingGetResponse> SystemCallWaitingGetRequestAsync(this OcipClientBase client, SystemCallWaitingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallWaitingGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Call Waiting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallWaitingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallWaitingModifyRequest(this OcipClientBase client, SystemCallWaitingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Call Waiting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallWaitingModifyRequestAsync(this OcipClientBase client, SystemCallWaitingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Call Waiting.
        /// The response is either a UserCallWaitingGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallWaitingGetRequest17sp4Async instead.")]
        public static async Task<UserCallWaitingGetResponse17sp4> UserCallWaitingGetRequest17sp4(this OcipClientBase client, UserCallWaitingGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallWaitingGetResponse17sp4;
        }

        /// <summary>
        /// Request the user level data associated with Call Waiting.
        /// The response is either a UserCallWaitingGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallWaitingGetResponse17sp4> UserCallWaitingGetRequest17sp4Async(this OcipClientBase client, UserCallWaitingGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallWaitingGetResponse17sp4;
        }
        /// <summary>
        /// Modify the user level data associated with Call Waiting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// disableCallingLineIdDelivery
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallWaitingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallWaitingModifyRequest(this OcipClientBase client, UserCallWaitingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Call Waiting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// disableCallingLineIdDelivery
        /// </summary>
        public static async Task<SuccessResponse> UserCallWaitingModifyRequestAsync(this OcipClientBase client, UserCallWaitingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
