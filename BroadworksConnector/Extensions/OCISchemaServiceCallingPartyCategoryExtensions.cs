using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallingPartyCategoryExtensions
    {

        /// <summary>
        /// Add a Calling Party Category to system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallingPartyCategoryAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallingPartyCategoryAddRequest(this OcipClientBase client, SystemCallingPartyCategoryAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Calling Party Category to system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallingPartyCategoryAddRequestAsync(this OcipClientBase client, SystemCallingPartyCategoryAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Calling Party Category from system. The category cannot be deleted if it is the default or is in use by any users.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallingPartyCategoryDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallingPartyCategoryDeleteRequest(this OcipClientBase client, SystemCallingPartyCategoryDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Calling Party Category from system. The category cannot be deleted if it is the default or is in use by any users.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallingPartyCategoryDeleteRequestAsync(this OcipClientBase client, SystemCallingPartyCategoryDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Calling Party Category in system.
        /// The response is either a SystemCallingPartyCategoryGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallingPartyCategoryGetListRequestAsync instead.")]
        public static async Task<SystemCallingPartyCategoryGetListResponse> SystemCallingPartyCategoryGetListRequest(this OcipClientBase client, SystemCallingPartyCategoryGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallingPartyCategoryGetListResponse;
        }

        /// <summary>
        /// Get the list of all Calling Party Category in system.
        /// The response is either a SystemCallingPartyCategoryGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallingPartyCategoryGetListResponse> SystemCallingPartyCategoryGetListRequestAsync(this OcipClientBase client, SystemCallingPartyCategoryGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallingPartyCategoryGetListResponse;
        }
        /// <summary>
        /// Get an existing Calling Party Category in system.
        /// The response is either a SystemCallingPartyCategoryGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallingPartyCategoryGetRequestAsync instead.")]
        public static async Task<SystemCallingPartyCategoryGetResponse> SystemCallingPartyCategoryGetRequest(this OcipClientBase client, SystemCallingPartyCategoryGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallingPartyCategoryGetResponse;
        }

        /// <summary>
        /// Get an existing Calling Party Category in system.
        /// The response is either a SystemCallingPartyCategoryGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallingPartyCategoryGetResponse> SystemCallingPartyCategoryGetRequestAsync(this OcipClientBase client, SystemCallingPartyCategoryGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallingPartyCategoryGetResponse;
        }
        /// <summary>
        /// Modify a Calling Party Category in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallingPartyCategoryModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallingPartyCategoryModifyRequest(this OcipClientBase client, SystemCallingPartyCategoryModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Calling Party Category in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallingPartyCategoryModifyRequestAsync(this OcipClientBase client, SystemCallingPartyCategoryModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Calling Party Category.
        /// The response is either a UserCallingPartyCategoryGetResponse16 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallingPartyCategoryGetRequest16Async instead.")]
        public static async Task<UserCallingPartyCategoryGetResponse16> UserCallingPartyCategoryGetRequest16(this OcipClientBase client, UserCallingPartyCategoryGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallingPartyCategoryGetResponse16;
        }

        /// <summary>
        /// Request the user level data associated with Calling Party Category.
        /// The response is either a UserCallingPartyCategoryGetResponse16 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallingPartyCategoryGetResponse16> UserCallingPartyCategoryGetRequest16Async(this OcipClientBase client, UserCallingPartyCategoryGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallingPartyCategoryGetResponse16;
        }
        /// <summary>
        /// Modify the user level data associated with Calling Party Category.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallingPartyCategoryModifyRequest16Async instead.")]
        public static async Task<SuccessResponse> UserCallingPartyCategoryModifyRequest16(this OcipClientBase client, UserCallingPartyCategoryModifyRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Calling Party Category.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallingPartyCategoryModifyRequest16Async(this OcipClientBase client, UserCallingPartyCategoryModifyRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
