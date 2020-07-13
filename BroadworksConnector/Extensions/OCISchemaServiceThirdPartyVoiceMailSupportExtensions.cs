using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceThirdPartyVoiceMailSupportExtensions
    {

        /// <summary>
        /// Request the group level data associated with Third-Party Voice Mail Support.
        /// The response is either a GroupThirdPartyVoiceMailSupportGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupThirdPartyVoiceMailSupportGetRequestAsync instead.")]
        public static async Task<GroupThirdPartyVoiceMailSupportGetResponse> GroupThirdPartyVoiceMailSupportGetRequest(this OcipClientBase client, GroupThirdPartyVoiceMailSupportGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupThirdPartyVoiceMailSupportGetResponse;
        }

        /// <summary>
        /// Request the group level data associated with Third-Party Voice Mail Support.
        /// The response is either a GroupThirdPartyVoiceMailSupportGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupThirdPartyVoiceMailSupportGetResponse> GroupThirdPartyVoiceMailSupportGetRequestAsync(this OcipClientBase client, GroupThirdPartyVoiceMailSupportGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupThirdPartyVoiceMailSupportGetResponse;
        }
        /// <summary>
        /// Modify the Third Party Voice Mail Support settings for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupThirdPartyVoiceMailSupportModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupThirdPartyVoiceMailSupportModifyRequest(this OcipClientBase client, GroupThirdPartyVoiceMailSupportModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Third Party Voice Mail Support settings for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupThirdPartyVoiceMailSupportModifyRequestAsync(this OcipClientBase client, GroupThirdPartyVoiceMailSupportModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a ThirdPartyVoiceMailSupport User DN to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemThirdPartyVoiceMailSupportAddDnRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemThirdPartyVoiceMailSupportAddDnRequest(this OcipClientBase client, SystemThirdPartyVoiceMailSupportAddDnRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a ThirdPartyVoiceMailSupport User DN to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemThirdPartyVoiceMailSupportAddDnRequestAsync(this OcipClientBase client, SystemThirdPartyVoiceMailSupportAddDnRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a ThirdPartyVoiceMailSupport User DN from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemThirdPartyVoiceMailSupportDeleteDnRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemThirdPartyVoiceMailSupportDeleteDnRequest(this OcipClientBase client, SystemThirdPartyVoiceMailSupportDeleteDnRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a ThirdPartyVoiceMailSupport User DN from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemThirdPartyVoiceMailSupportDeleteDnRequestAsync(this OcipClientBase client, SystemThirdPartyVoiceMailSupportDeleteDnRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of ThirdPartyVoiceMailSupport User DN's defined in the system.
        /// The response is either a SystemThirdPartyVoiceMailSupportGetDnListResponse or an ErrorResponse.
        /// The search can be done using multiple criterion.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemThirdPartyVoiceMailSupportGetDnListRequestAsync instead.")]
        public static async Task<SystemThirdPartyVoiceMailSupportGetDnListResponse> SystemThirdPartyVoiceMailSupportGetDnListRequest(this OcipClientBase client, SystemThirdPartyVoiceMailSupportGetDnListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemThirdPartyVoiceMailSupportGetDnListResponse;
        }

        /// <summary>
        /// Request to get a list of ThirdPartyVoiceMailSupport User DN's defined in the system.
        /// The response is either a SystemThirdPartyVoiceMailSupportGetDnListResponse or an ErrorResponse.
        /// The search can be done using multiple criterion.
        /// </summary>
        public static async Task<SystemThirdPartyVoiceMailSupportGetDnListResponse> SystemThirdPartyVoiceMailSupportGetDnListRequestAsync(this OcipClientBase client, SystemThirdPartyVoiceMailSupportGetDnListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemThirdPartyVoiceMailSupportGetDnListResponse;
        }
        /// <summary>
        /// Request the system level data associated with Third-party Voice Mail Support.
        /// The response is either a SystemThirdPartyVoiceMailSupportGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemThirdPartyVoiceMailSupportGetRequest17sp4Async instead.")]
        public static async Task<SystemThirdPartyVoiceMailSupportGetResponse17sp4> SystemThirdPartyVoiceMailSupportGetRequest17sp4(this OcipClientBase client, SystemThirdPartyVoiceMailSupportGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemThirdPartyVoiceMailSupportGetResponse17sp4;
        }

        /// <summary>
        /// Request the system level data associated with Third-party Voice Mail Support.
        /// The response is either a SystemThirdPartyVoiceMailSupportGetResponse17sp4 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemThirdPartyVoiceMailSupportGetResponse17sp4> SystemThirdPartyVoiceMailSupportGetRequest17sp4Async(this OcipClientBase client, SystemThirdPartyVoiceMailSupportGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemThirdPartyVoiceMailSupportGetResponse17sp4;
        }
        /// <summary>
        /// Request to modify a ThirdPartyVoiceMailSupport User DN and description in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemThirdPartyVoiceMailSupportModifyDnRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemThirdPartyVoiceMailSupportModifyDnRequest(this OcipClientBase client, SystemThirdPartyVoiceMailSupportModifyDnRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a ThirdPartyVoiceMailSupport User DN and description in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemThirdPartyVoiceMailSupportModifyDnRequestAsync(this OcipClientBase client, SystemThirdPartyVoiceMailSupportModifyDnRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Third-party Voice Mail Support.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// stripDiversionOnVMDestinationRetrieval
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemThirdPartyVoiceMailSupportModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemThirdPartyVoiceMailSupportModifyRequest(this OcipClientBase client, SystemThirdPartyVoiceMailSupportModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Third-party Voice Mail Support.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// stripDiversionOnVMDestinationRetrieval
        /// </summary>
        public static async Task<SuccessResponse> SystemThirdPartyVoiceMailSupportModifyRequestAsync(this OcipClientBase client, SystemThirdPartyVoiceMailSupportModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Third-Party Voice Mail Support.
        /// The response is either a UserThirdPartyVoiceMailSupportGetResponse17 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserThirdPartyVoiceMailSupportGetRequest17Async instead.")]
        public static async Task<UserThirdPartyVoiceMailSupportGetResponse17> UserThirdPartyVoiceMailSupportGetRequest17(this OcipClientBase client, UserThirdPartyVoiceMailSupportGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserThirdPartyVoiceMailSupportGetResponse17;
        }

        /// <summary>
        /// Request the user level data associated with Third-Party Voice Mail Support.
        /// The response is either a UserThirdPartyVoiceMailSupportGetResponse17 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserThirdPartyVoiceMailSupportGetResponse17> UserThirdPartyVoiceMailSupportGetRequest17Async(this OcipClientBase client, UserThirdPartyVoiceMailSupportGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserThirdPartyVoiceMailSupportGetResponse17;
        }
        /// <summary>
        /// Modify the Third Party Voice Mail Support settings for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserThirdPartyVoiceMailSupportModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserThirdPartyVoiceMailSupportModifyRequest(this OcipClientBase client, UserThirdPartyVoiceMailSupportModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Third Party Voice Mail Support settings for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserThirdPartyVoiceMailSupportModifyRequestAsync(this OcipClientBase client, UserThirdPartyVoiceMailSupportModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
