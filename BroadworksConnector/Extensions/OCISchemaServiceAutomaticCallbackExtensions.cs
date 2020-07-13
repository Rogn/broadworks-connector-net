using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceAutomaticCallbackExtensions
    {

        /// <summary>
        /// Adds automatic callback release cause to the releaseCause attribute.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAutomaticCallbackAddReleaseCauseListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAutomaticCallbackAddReleaseCauseListRequest(this OcipClientBase client, SystemAutomaticCallbackAddReleaseCauseListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds automatic callback release cause to the releaseCause attribute.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAutomaticCallbackAddReleaseCauseListRequestAsync(this OcipClientBase client, SystemAutomaticCallbackAddReleaseCauseListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes automatic callback release causes from the release cause attribute.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAutomaticCallbackDeleteReleaseCauseListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAutomaticCallbackDeleteReleaseCauseListRequest(this OcipClientBase client, SystemAutomaticCallbackDeleteReleaseCauseListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes automatic callback release causes from the release cause attribute.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAutomaticCallbackDeleteReleaseCauseListRequestAsync(this OcipClientBase client, SystemAutomaticCallbackDeleteReleaseCauseListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system's automatic callback attributes.
        /// The response is either a SystemAutomaticCallbackGetReleaseCauseListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAutomaticCallbackGetReleaseCauseListRequestAsync instead.")]
        public static async Task<SystemAutomaticCallbackGetReleaseCauseListResponse> SystemAutomaticCallbackGetReleaseCauseListRequest(this OcipClientBase client, SystemAutomaticCallbackGetReleaseCauseListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAutomaticCallbackGetReleaseCauseListResponse;
        }

        /// <summary>
        /// Request the system's automatic callback attributes.
        /// The response is either a SystemAutomaticCallbackGetReleaseCauseListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAutomaticCallbackGetReleaseCauseListResponse> SystemAutomaticCallbackGetReleaseCauseListRequestAsync(this OcipClientBase client, SystemAutomaticCallbackGetReleaseCauseListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAutomaticCallbackGetReleaseCauseListResponse;
        }
        /// <summary>
        /// Request the system's automatic callback attributes.
        /// The response is either a SystemAutomaticCallbackGetResponse17 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAutomaticCallbackGetRequest17Async instead.")]
        public static async Task<SystemAutomaticCallbackGetResponse17> SystemAutomaticCallbackGetRequest17(this OcipClientBase client, SystemAutomaticCallbackGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAutomaticCallbackGetResponse17;
        }

        /// <summary>
        /// Request the system's automatic callback attributes.
        /// The response is either a SystemAutomaticCallbackGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemAutomaticCallbackGetResponse17> SystemAutomaticCallbackGetRequest17Async(this OcipClientBase client, SystemAutomaticCallbackGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAutomaticCallbackGetResponse17;
        }
        /// <summary>
        /// Modifies the system's automatic callback attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAutomaticCallbackModifyRequest15Async instead.")]
        public static async Task<SuccessResponse> SystemAutomaticCallbackModifyRequest15(this OcipClientBase client, SystemAutomaticCallbackModifyRequest15 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the system's automatic callback attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAutomaticCallbackModifyRequest15Async(this OcipClientBase client, SystemAutomaticCallbackModifyRequest15 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Automatic Callback.
        /// The response is either a UserAutomaticCallbackGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAutomaticCallbackGetRequestAsync instead.")]
        public static async Task<UserAutomaticCallbackGetResponse> UserAutomaticCallbackGetRequest(this OcipClientBase client, UserAutomaticCallbackGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAutomaticCallbackGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Automatic Callback.
        /// The response is either a UserAutomaticCallbackGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserAutomaticCallbackGetResponse> UserAutomaticCallbackGetRequestAsync(this OcipClientBase client, UserAutomaticCallbackGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAutomaticCallbackGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Automatic Callback.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAutomaticCallbackModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAutomaticCallbackModifyRequest(this OcipClientBase client, UserAutomaticCallbackModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Automatic Callback.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAutomaticCallbackModifyRequestAsync(this OcipClientBase client, UserAutomaticCallbackModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
