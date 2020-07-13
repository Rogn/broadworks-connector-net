using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceInterceptExtensions
    {

        /// <summary>
        /// Get the group's intercept group service settings.
        /// The response is either a GroupInterceptGroupGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupInterceptGroupGetRequest21sp1Async instead.")]
        public static async Task<GroupInterceptGroupGetResponse21sp1> GroupInterceptGroupGetRequest21sp1(this OcipClientBase client, GroupInterceptGroupGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupInterceptGroupGetResponse21sp1;
        }

        /// <summary>
        /// Get the group's intercept group service settings.
        /// The response is either a GroupInterceptGroupGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupInterceptGroupGetResponse21sp1> GroupInterceptGroupGetRequest21sp1Async(this OcipClientBase client, GroupInterceptGroupGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupInterceptGroupGetResponse21sp1;
        }
        /// <summary>
        /// Modify the group's intercept group service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// exemptInboundMobilityCalls
        /// exemptOutboundMobilityCalls
        /// disableParallelRingingToNetworkLocations
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupInterceptGroupModifyRequest21sp1Async instead.")]
        public static async Task<SuccessResponse> GroupInterceptGroupModifyRequest21sp1(this OcipClientBase client, GroupInterceptGroupModifyRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's intercept group service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// exemptInboundMobilityCalls
        /// exemptOutboundMobilityCalls
        /// disableParallelRingingToNetworkLocations
        /// </summary>
        public static async Task<SuccessResponse> GroupInterceptGroupModifyRequest21sp1Async(this OcipClientBase client, GroupInterceptGroupModifyRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add an Intercept User number(s) to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemInterceptUserAddDnListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemInterceptUserAddDnListRequest(this OcipClientBase client, SystemInterceptUserAddDnListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an Intercept User number(s) to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemInterceptUserAddDnListRequestAsync(this OcipClientBase client, SystemInterceptUserAddDnListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete an Intercept User number(s) from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemInterceptUserDeleteDnListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemInterceptUserDeleteDnListRequest(this OcipClientBase client, SystemInterceptUserDeleteDnListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an Intercept User number(s) from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemInterceptUserDeleteDnListRequestAsync(this OcipClientBase client, SystemInterceptUserDeleteDnListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of Intercept User dns defined in the system.
        /// The response is either a SystemInterceptUserGetDnListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemInterceptUserGetDnListRequestAsync instead.")]
        public static async Task<SystemInterceptUserGetDnListResponse> SystemInterceptUserGetDnListRequest(this OcipClientBase client, SystemInterceptUserGetDnListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemInterceptUserGetDnListResponse;
        }

        /// <summary>
        /// Request to get a list of Intercept User dns defined in the system.
        /// The response is either a SystemInterceptUserGetDnListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemInterceptUserGetDnListResponse> SystemInterceptUserGetDnListRequestAsync(this OcipClientBase client, SystemInterceptUserGetDnListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemInterceptUserGetDnListResponse;
        }
        /// <summary>
        /// Get the system-level intercept user service settings.
        /// The response is either a SystemInterceptUserGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemInterceptUserGetRequestAsync instead.")]
        public static async Task<SystemInterceptUserGetResponse> SystemInterceptUserGetRequest(this OcipClientBase client, SystemInterceptUserGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemInterceptUserGetResponse;
        }

        /// <summary>
        /// Get the system-level intercept user service settings.
        /// The response is either a SystemInterceptUserGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemInterceptUserGetResponse> SystemInterceptUserGetRequestAsync(this OcipClientBase client, SystemInterceptUserGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemInterceptUserGetResponse;
        }
        /// <summary>
        /// Request to modify a Intercept User number's description in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemInterceptUserModifyDnRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemInterceptUserModifyDnRequest(this OcipClientBase client, SystemInterceptUserModifyDnRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Intercept User number's description in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemInterceptUserModifyDnRequestAsync(this OcipClientBase client, SystemInterceptUserModifyDnRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the system-level intercept user service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemInterceptUserModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemInterceptUserModifyRequest(this OcipClientBase client, SystemInterceptUserModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system-level intercept user service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemInterceptUserModifyRequestAsync(this OcipClientBase client, SystemInterceptUserModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user's intercept user service settings.
        /// The response is either a UserInterceptUserGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserInterceptUserGetRequest21sp1Async instead.")]
        public static async Task<UserInterceptUserGetResponse21sp1> UserInterceptUserGetRequest21sp1(this OcipClientBase client, UserInterceptUserGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserInterceptUserGetResponse21sp1;
        }

        /// <summary>
        /// Get the user's intercept user service settings.
        /// The response is either a UserInterceptUserGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<UserInterceptUserGetResponse21sp1> UserInterceptUserGetRequest21sp1Async(this OcipClientBase client, UserInterceptUserGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserInterceptUserGetResponse21sp1;
        }
        /// <summary>
        /// Modify the user's intercept user service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// exemptInboundMobilityCalls
        /// exemptOutboundMobilityCalls
        /// disableParallelRingingToNetworkLocations
        /// </summary>
        [Obsolete("This method is deprecated. Use UserInterceptUserModifyRequest21sp1Async instead.")]
        public static async Task<SuccessResponse> UserInterceptUserModifyRequest21sp1(this OcipClientBase client, UserInterceptUserModifyRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's intercept user service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// exemptInboundMobilityCalls
        /// exemptOutboundMobilityCalls
        /// disableParallelRingingToNetworkLocations
        /// </summary>
        public static async Task<SuccessResponse> UserInterceptUserModifyRequest21sp1Async(this OcipClientBase client, UserInterceptUserModifyRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
