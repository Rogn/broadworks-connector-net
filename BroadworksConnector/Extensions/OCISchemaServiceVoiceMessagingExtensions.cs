using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceVoiceMessagingExtensions
    {

        /// <summary>
        /// Request to modify the group's voice messaging settings and voice portal branding settings.
        /// If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupConsolidatedModifyVoicePortalRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupConsolidatedModifyVoicePortalRequest(this OcipClientBase client, GroupVoiceMessagingGroupConsolidatedModifyVoicePortalRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the group's voice messaging settings and voice portal branding settings.
        /// If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupConsolidatedModifyVoicePortalRequestAsync(this OcipClientBase client, GroupVoiceMessagingGroupConsolidatedModifyVoicePortalRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the group's Voice Messaging settings.
        /// The response is either GroupVoiceMessagingGroupGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupGetRequestAsync instead.")]
        public static async Task<GroupVoiceMessagingGroupGetResponse> GroupVoiceMessagingGroupGetRequest(this OcipClientBase client, GroupVoiceMessagingGroupGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceMessagingGroupGetResponse;
        }

        /// <summary>
        /// Requests the group's Voice Messaging settings.
        /// The response is either GroupVoiceMessagingGroupGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetResponse> GroupVoiceMessagingGroupGetRequestAsync(this OcipClientBase client, GroupVoiceMessagingGroupGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceMessagingGroupGetResponse;
        }
        /// <summary>
        /// Get the group's voice portal branding settings.
        /// The response is either a GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20Async instead.")]
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20> GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20(this OcipClientBase client, GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20;
        }

        /// <summary>
        /// Get the group's voice portal branding settings.
        /// The response is either a GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20> GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20Async(this OcipClientBase client, GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20;
        }
        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse21sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupGetVoicePortalRequest21sp1Async instead.")]
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse21sp1> GroupVoiceMessagingGroupGetVoicePortalRequest21sp1(this OcipClientBase client, GroupVoiceMessagingGroupGetVoicePortalRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalResponse21sp1;
        }

        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse21sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse21sp1> GroupVoiceMessagingGroupGetVoicePortalRequest21sp1Async(this OcipClientBase client, GroupVoiceMessagingGroupGetVoicePortalRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalResponse21sp1;
        }
        /// <summary>
        /// Request to modify the group's voice messaging settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyRequest(this OcipClientBase client, GroupVoiceMessagingGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the group's voice messaging settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyRequestAsync(this OcipClientBase client, GroupVoiceMessagingGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the group's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20(this OcipClientBase client, GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20Async(this OcipClientBase client, GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify the group voice portal information for a voice messaging group.
        /// The following elements are only used in AS data mode:
        /// networkClassOfService
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// expressMode
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupModifyVoicePortalRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalRequest(this OcipClientBase client, GroupVoiceMessagingGroupModifyVoicePortalRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the group voice portal information for a voice messaging group.
        /// The following elements are only used in AS data mode:
        /// networkClassOfService
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// expressMode
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalRequestAsync(this OcipClientBase client, GroupVoiceMessagingGroupModifyVoicePortalRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the reseller level data associated with Voice Messaging.
        /// The response is either a ResellerVoiceMessagingGroupGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerVoiceMessagingGroupGetRequestAsync instead.")]
        public static async Task<ResellerVoiceMessagingGroupGetResponse> ResellerVoiceMessagingGroupGetRequest(this OcipClientBase client, ResellerVoiceMessagingGroupGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerVoiceMessagingGroupGetResponse;
        }

        /// <summary>
        /// Request the reseller level data associated with Voice Messaging.
        /// The response is either a ResellerVoiceMessagingGroupGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<ResellerVoiceMessagingGroupGetResponse> ResellerVoiceMessagingGroupGetRequestAsync(this OcipClientBase client, ResellerVoiceMessagingGroupGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerVoiceMessagingGroupGetResponse;
        }
        /// <summary>
        /// Modify the reseller level data associated with Voice Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerVoiceMessagingGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerVoiceMessagingGroupModifyRequest(this OcipClientBase client, ResellerVoiceMessagingGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller level data associated with Voice Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerVoiceMessagingGroupModifyRequestAsync(this OcipClientBase client, ResellerVoiceMessagingGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the service provider's or enterprise's voice messaging settings.
        /// The response is either ServiceProviderVoiceMessagingGroupGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderVoiceMessagingGroupGetRequestAsync instead.")]
        public static async Task<ServiceProviderVoiceMessagingGroupGetResponse> ServiceProviderVoiceMessagingGroupGetRequest(this OcipClientBase client, ServiceProviderVoiceMessagingGroupGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderVoiceMessagingGroupGetResponse;
        }

        /// <summary>
        /// Requests the service provider's or enterprise's voice messaging settings.
        /// The response is either ServiceProviderVoiceMessagingGroupGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderVoiceMessagingGroupGetResponse> ServiceProviderVoiceMessagingGroupGetRequestAsync(this OcipClientBase client, ServiceProviderVoiceMessagingGroupGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderVoiceMessagingGroupGetResponse;
        }
        /// <summary>
        /// Get the service provider's voice portal branding settings.
        /// The response is either a ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16Async instead.")]
        public static async Task<ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16> ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16(this OcipClientBase client, ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16;
        }

        /// <summary>
        /// Get the service provider's voice portal branding settings.
        /// The response is either a ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16> ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16Async(this OcipClientBase client, ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16;
        }
        /// <summary>
        /// Requests the service provider's or enterprise's voice portal settings.
        /// The response is either ServiceProviderVoiceMessagingGroupGetVoicePortalResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderVoiceMessagingGroupGetVoicePortalRequestAsync instead.")]
        public static async Task<ServiceProviderVoiceMessagingGroupGetVoicePortalResponse> ServiceProviderVoiceMessagingGroupGetVoicePortalRequest(this OcipClientBase client, ServiceProviderVoiceMessagingGroupGetVoicePortalRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderVoiceMessagingGroupGetVoicePortalResponse;
        }

        /// <summary>
        /// Requests the service provider's or enterprise's voice portal settings.
        /// The response is either ServiceProviderVoiceMessagingGroupGetVoicePortalResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderVoiceMessagingGroupGetVoicePortalResponse> ServiceProviderVoiceMessagingGroupGetVoicePortalRequestAsync(this OcipClientBase client, ServiceProviderVoiceMessagingGroupGetVoicePortalRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderVoiceMessagingGroupGetVoicePortalResponse;
        }
        /// <summary>
        /// Request to modify a service provider's or enterprise's voice messaging settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderVoiceMessagingGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderVoiceMessagingGroupModifyRequest(this OcipClientBase client, ServiceProviderVoiceMessagingGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a service provider's or enterprise's voice messaging settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderVoiceMessagingGroupModifyRequestAsync(this OcipClientBase client, ServiceProviderVoiceMessagingGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the service provider's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderVoiceMessagingGroupModifyVoicePortalBrandingRequest16Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderVoiceMessagingGroupModifyVoicePortalBrandingRequest16(this OcipClientBase client, ServiceProviderVoiceMessagingGroupModifyVoicePortalBrandingRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the service provider's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderVoiceMessagingGroupModifyVoicePortalBrandingRequest16Async(this OcipClientBase client, ServiceProviderVoiceMessagingGroupModifyVoicePortalBrandingRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to change the service provider's or enterprise's voice portal settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderVoiceMessagingGroupModifyVoicePortalRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderVoiceMessagingGroupModifyVoicePortalRequest(this OcipClientBase client, ServiceProviderVoiceMessagingGroupModifyVoicePortalRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to change the service provider's or enterprise's voice portal settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderVoiceMessagingGroupModifyVoicePortalRequestAsync(this OcipClientBase client, ServiceProviderVoiceMessagingGroupModifyVoicePortalRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests system voice mail message summary update parameter settings.
        /// The response is either SystemVoiceMessageSummaryUpdateGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVoiceMessageSummaryUpdateGetRequestAsync instead.")]
        public static async Task<SystemVoiceMessageSummaryUpdateGetResponse> SystemVoiceMessageSummaryUpdateGetRequest(this OcipClientBase client, SystemVoiceMessageSummaryUpdateGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVoiceMessageSummaryUpdateGetResponse;
        }

        /// <summary>
        /// Requests system voice mail message summary update parameter settings.
        /// The response is either SystemVoiceMessageSummaryUpdateGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemVoiceMessageSummaryUpdateGetResponse> SystemVoiceMessageSummaryUpdateGetRequestAsync(this OcipClientBase client, SystemVoiceMessageSummaryUpdateGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVoiceMessageSummaryUpdateGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Voice Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVoiceMessageSummaryUpdateModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemVoiceMessageSummaryUpdateModifyRequest(this OcipClientBase client, SystemVoiceMessageSummaryUpdateModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Voice Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVoiceMessageSummaryUpdateModifyRequestAsync(this OcipClientBase client, SystemVoiceMessageSummaryUpdateModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse22V2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVoiceMessagingGroupGetRequest22V2Async instead.")]
        public static async Task<SystemVoiceMessagingGroupGetResponse22V2> SystemVoiceMessagingGroupGetRequest22V2(this OcipClientBase client, SystemVoiceMessagingGroupGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse22V2;
        }

        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse22V2 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetResponse22V2> SystemVoiceMessagingGroupGetRequest22V2Async(this OcipClientBase client, SystemVoiceMessagingGroupGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse22V2;
        }
        /// <summary>
        /// Requests the system voice portal Menus setting.
        /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse21 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVoiceMessagingGroupGetVoicePortalMenusRequest21Async instead.")]
        public static async Task<SystemVoiceMessagingGroupGetVoicePortalMenusResponse21> SystemVoiceMessagingGroupGetVoicePortalMenusRequest21(this OcipClientBase client, SystemVoiceMessagingGroupGetVoicePortalMenusRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVoiceMessagingGroupGetVoicePortalMenusResponse21;
        }

        /// <summary>
        /// Requests the system voice portal Menus setting.
        /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse21 or ErrorResponse.
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetVoicePortalMenusResponse21> SystemVoiceMessagingGroupGetVoicePortalMenusRequest21Async(this OcipClientBase client, SystemVoiceMessagingGroupGetVoicePortalMenusRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVoiceMessagingGroupGetVoicePortalMenusResponse21;
        }
        /// <summary>
        /// Modify the system level data associated with Voice Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS/Amplify data mode:
        /// realDeleteForImap
        /// useDnInMailBody
        /// useShortSubjectLine
        /// maxMessageLengthMinutes
        /// maxMailboxLengthMinutes
        /// doesMessageAge
        /// holdPeriodDays
        /// mailServerNetAddress
        /// mailServerProtocol
        /// defaultDeliveryFromAddress
        /// defaultNotificationFromAddress
        /// useOutgoingMWIOnSMDI
        /// mwiDelayInSeconds
        /// voicePortalScope
        /// enterpriseVoicePortalLicensed
        /// networkWideMessaging
        /// useExternalRouting
        /// defaultExternalRoutingAddress
        /// vmOnlySystem, element is ignored in Amplify data mode.
        /// clientInitiatedMailServerSessionTimeoutMinutes
        /// recordingAudioFileFormat
        /// allowVoicePortalAccessFromVMDepositMenu
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// storageSelection
        /// vmBucketName
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVoiceMessagingGroupModifyRequest16Async instead.")]
        public static async Task<SuccessResponse> SystemVoiceMessagingGroupModifyRequest16(this OcipClientBase client, SystemVoiceMessagingGroupModifyRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Voice Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS/Amplify data mode:
        /// realDeleteForImap
        /// useDnInMailBody
        /// useShortSubjectLine
        /// maxMessageLengthMinutes
        /// maxMailboxLengthMinutes
        /// doesMessageAge
        /// holdPeriodDays
        /// mailServerNetAddress
        /// mailServerProtocol
        /// defaultDeliveryFromAddress
        /// defaultNotificationFromAddress
        /// useOutgoingMWIOnSMDI
        /// mwiDelayInSeconds
        /// voicePortalScope
        /// enterpriseVoicePortalLicensed
        /// networkWideMessaging
        /// useExternalRouting
        /// defaultExternalRoutingAddress
        /// vmOnlySystem, element is ignored in Amplify data mode.
        /// clientInitiatedMailServerSessionTimeoutMinutes
        /// recordingAudioFileFormat
        /// allowVoicePortalAccessFromVMDepositMenu
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// storageSelection
        /// vmBucketName
        /// </summary>
        public static async Task<SuccessResponse> SystemVoiceMessagingGroupModifyRequest16Async(this OcipClientBase client, SystemVoiceMessagingGroupModifyRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify the system voice portal menus setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19Async instead.")]
        public static async Task<SuccessResponse> SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19(this OcipClientBase client, SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system voice portal menus setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19Async(this OcipClientBase client, SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add one or more voice mail aliases to a users voice message.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserAddAliasListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserVoiceMessagingUserAddAliasListRequest(this OcipClientBase client, UserVoiceMessagingUserAddAliasListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add one or more voice mail aliases to a users voice message.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserAddAliasListRequestAsync(this OcipClientBase client, UserVoiceMessagingUserAddAliasListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete one or more voice mail aliases from a users voice message.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserDeleteAliasListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserVoiceMessagingUserDeleteAliasListRequest(this OcipClientBase client, UserVoiceMessagingUserDeleteAliasListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete one or more voice mail aliases from a users voice message.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserDeleteAliasListRequestAsync(this OcipClientBase client, UserVoiceMessagingUserDeleteAliasListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user's voice messaging advanced voice management service setting.
        /// The response is either a UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3Async instead.")]
        public static async Task<UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3> UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3(this OcipClientBase client, UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3;
        }

        /// <summary>
        /// Get the user's voice messaging advanced voice management service setting.
        /// The response is either a UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3> UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3Async(this OcipClientBase client, UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3;
        }
        /// <summary>
        /// Get the voice mail aliases for a users voice message.
        /// The response is either a UserVoiceMessagingUserGetAliasListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserGetAliasListRequestAsync instead.")]
        public static async Task<UserVoiceMessagingUserGetAliasListResponse> UserVoiceMessagingUserGetAliasListRequest(this OcipClientBase client, UserVoiceMessagingUserGetAliasListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserVoiceMessagingUserGetAliasListResponse;
        }

        /// <summary>
        /// Get the voice mail aliases for a users voice message.
        /// The response is either a UserVoiceMessagingUserGetAliasListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetAliasListResponse> UserVoiceMessagingUserGetAliasListRequestAsync(this OcipClientBase client, UserVoiceMessagingUserGetAliasListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserVoiceMessagingUserGetAliasListResponse;
        }
        /// <summary>
        /// Get a voice mail distribution list for a users voice message.
        /// The response is either UserVoiceMessagingUserGetDistributionListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserGetDistributionListRequestAsync instead.")]
        public static async Task<UserVoiceMessagingUserGetDistributionListResponse> UserVoiceMessagingUserGetDistributionListRequest(this OcipClientBase client, UserVoiceMessagingUserGetDistributionListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserVoiceMessagingUserGetDistributionListResponse;
        }

        /// <summary>
        /// Get a voice mail distribution list for a users voice message.
        /// The response is either UserVoiceMessagingUserGetDistributionListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetDistributionListResponse> UserVoiceMessagingUserGetDistributionListRequestAsync(this OcipClientBase client, UserVoiceMessagingUserGetDistributionListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserVoiceMessagingUserGetDistributionListResponse;
        }
        /// <summary>
        /// Get the user's voice messaging greeting information.
        /// The response is either a UserVoiceMessagingUserGetGreetingResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserGetGreetingRequest20Async instead.")]
        public static async Task<UserVoiceMessagingUserGetGreetingResponse20> UserVoiceMessagingUserGetGreetingRequest20(this OcipClientBase client, UserVoiceMessagingUserGetGreetingRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserVoiceMessagingUserGetGreetingResponse20;
        }

        /// <summary>
        /// Get the user's voice messaging greeting information.
        /// The response is either a UserVoiceMessagingUserGetGreetingResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetGreetingResponse20> UserVoiceMessagingUserGetGreetingRequest20Async(this OcipClientBase client, UserVoiceMessagingUserGetGreetingRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserVoiceMessagingUserGetGreetingResponse20;
        }
        /// <summary>
        /// Get the user's voice messaging outgoing SMDI message waiting indicator service setting.
        /// The response is either a UserVoiceMessagingUserGetOutgoingSMDIMWIResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserGetOutgoingSMDIMWIRequestAsync instead.")]
        public static async Task<UserVoiceMessagingUserGetOutgoingSMDIMWIResponse> UserVoiceMessagingUserGetOutgoingSMDIMWIRequest(this OcipClientBase client, UserVoiceMessagingUserGetOutgoingSMDIMWIRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserVoiceMessagingUserGetOutgoingSMDIMWIResponse;
        }

        /// <summary>
        /// Get the user's voice messaging outgoing SMDI message waiting indicator service setting.
        /// The response is either a UserVoiceMessagingUserGetOutgoingSMDIMWIResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetOutgoingSMDIMWIResponse> UserVoiceMessagingUserGetOutgoingSMDIMWIRequestAsync(this OcipClientBase client, UserVoiceMessagingUserGetOutgoingSMDIMWIRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserVoiceMessagingUserGetOutgoingSMDIMWIResponse;
        }
        /// <summary>
        /// Get the user's voice messaging voice management service settings.
        /// The response is either a UserVoiceMessagingUserGetVoiceManagementResponse17 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserGetVoiceManagementRequest17Async instead.")]
        public static async Task<UserVoiceMessagingUserGetVoiceManagementResponse17> UserVoiceMessagingUserGetVoiceManagementRequest17(this OcipClientBase client, UserVoiceMessagingUserGetVoiceManagementRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserVoiceMessagingUserGetVoiceManagementResponse17;
        }

        /// <summary>
        /// Get the user's voice messaging voice management service settings.
        /// The response is either a UserVoiceMessagingUserGetVoiceManagementResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetVoiceManagementResponse17> UserVoiceMessagingUserGetVoiceManagementRequest17Async(this OcipClientBase client, UserVoiceMessagingUserGetVoiceManagementRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserVoiceMessagingUserGetVoiceManagementResponse17;
        }
        /// <summary>
        /// Get the user's voice messaging voice portal settings.
        /// The response is either a UserVoiceMessagingUserGetVoicePortalResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserGetVoicePortalRequest20Async instead.")]
        public static async Task<UserVoiceMessagingUserGetVoicePortalResponse20> UserVoiceMessagingUserGetVoicePortalRequest20(this OcipClientBase client, UserVoiceMessagingUserGetVoicePortalRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserVoiceMessagingUserGetVoicePortalResponse20;
        }

        /// <summary>
        /// Get the user's voice messaging voice portal settings.
        /// The response is either a UserVoiceMessagingUserGetVoicePortalResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetVoicePortalResponse20> UserVoiceMessagingUserGetVoicePortalRequest20Async(this OcipClientBase client, UserVoiceMessagingUserGetVoicePortalRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserVoiceMessagingUserGetVoicePortalResponse20;
        }
        /// <summary>
        /// Modify the user's voice messaging advanced voice management service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserModifyAdvancedVoiceManagementRequestAsync instead.")]
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyAdvancedVoiceManagementRequest(this OcipClientBase client, UserVoiceMessagingUserModifyAdvancedVoiceManagementRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging advanced voice management service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyAdvancedVoiceManagementRequestAsync(this OcipClientBase client, UserVoiceMessagingUserModifyAdvancedVoiceManagementRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a voice mail distribution list for a users voice message.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserModifyDistributionListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyDistributionListRequest(this OcipClientBase client, UserVoiceMessagingUserModifyDistributionListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a voice mail distribution list for a users voice message.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyDistributionListRequestAsync(this OcipClientBase client, UserVoiceMessagingUserModifyDistributionListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's voice messaging greeting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// The following elements are only used in AS data mode:
        /// disableMessageDeposit
        /// disableMessageDepositAction
        /// greetingOnlyForwardDestination
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserModifyGreetingRequest20Async instead.")]
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyGreetingRequest20(this OcipClientBase client, UserVoiceMessagingUserModifyGreetingRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging greeting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// The following elements are only used in AS data mode:
        /// disableMessageDeposit
        /// disableMessageDepositAction
        /// greetingOnlyForwardDestination
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyGreetingRequest20Async(this OcipClientBase client, UserVoiceMessagingUserModifyGreetingRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's voice messaging outgoing message waiting indicator service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserModifyOutgoingSMDIMWIRequestAsync instead.")]
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyOutgoingSMDIMWIRequest(this OcipClientBase client, UserVoiceMessagingUserModifyOutgoingSMDIMWIRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging outgoing message waiting indicator service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyOutgoingSMDIMWIRequestAsync(this OcipClientBase client, UserVoiceMessagingUserModifyOutgoingSMDIMWIRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's voice messaging advanced voice management service setting.
        /// Modify a voice mail distribution list for a users voice message.
        /// Modify the user's voice messaging greeting.
        /// Modify the user's voice messaging outgoing message waiting indicator service setting.
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyRequest(this OcipClientBase client, UserVoiceMessagingUserModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging advanced voice management service setting.
        /// Modify a voice mail distribution list for a users voice message.
        /// Modify the user's voice messaging greeting.
        /// Modify the user's voice messaging outgoing message waiting indicator service setting.
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyRequestAsync(this OcipClientBase client, UserVoiceMessagingUserModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's voice messaging advanced voice management service setting.
        /// Modify a voice mail distribution list for a users voice message.
        /// Modify the user's voice messaging greeting.
        /// Modify the user's voice messaging outgoing message waiting indicator service setting.
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserModifyRequest23Async instead.")]
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyRequest23(this OcipClientBase client, UserVoiceMessagingUserModifyRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging advanced voice management service setting.
        /// Modify a voice mail distribution list for a users voice message.
        /// Modify the user's voice messaging greeting.
        /// Modify the user's voice messaging outgoing message waiting indicator service setting.
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyRequest23Async(this OcipClientBase client, UserVoiceMessagingUserModifyRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's voice messaging voice management service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserModifyVoiceManagementRequestAsync instead.")]
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyVoiceManagementRequest(this OcipClientBase client, UserVoiceMessagingUserModifyVoiceManagementRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging voice management service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyVoiceManagementRequestAsync(this OcipClientBase client, UserVoiceMessagingUserModifyVoiceManagementRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserModifyVoicePortalRequest20Async instead.")]
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyVoicePortalRequest20(this OcipClientBase client, UserVoiceMessagingUserModifyVoicePortalRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyVoicePortalRequest20Async(this OcipClientBase client, UserVoiceMessagingUserModifyVoicePortalRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
