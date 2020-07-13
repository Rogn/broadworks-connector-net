using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaDeprecatedASExtensions
    {

        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse18 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminGetPolicyRequest18Async instead.")]
        public static async Task<GroupAdminGetPolicyResponse18> GroupAdminGetPolicyRequest18(this OcipClientBase client, GroupAdminGetPolicyRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdminGetPolicyResponse18;
        }

        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse18 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAdminGetPolicyResponse18> GroupAdminGetPolicyRequest18Async(this OcipClientBase client, GroupAdminGetPolicyRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdminGetPolicyResponse18;
        }
        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse19sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminGetPolicyRequest19sp1Async instead.")]
        public static async Task<GroupAdminGetPolicyResponse19sp1> GroupAdminGetPolicyRequest19sp1(this OcipClientBase client, GroupAdminGetPolicyRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdminGetPolicyResponse19sp1;
        }

        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse19sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAdminGetPolicyResponse19sp1> GroupAdminGetPolicyRequest19sp1Async(this OcipClientBase client, GroupAdminGetPolicyRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdminGetPolicyResponse19sp1;
        }
        /// <summary>
        /// Add a Auto Attendant instance to a group.
        /// The domain is required in the serviceUserId.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// type, use value "Basic" in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// holidayMenu
        /// The following elements are only valid for Standard Auto Attendants:
        /// holidayMenu
        /// 
        /// Replaced by: GroupAutoAttendantAddInstanceRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantAddInstanceRequest19Async instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantAddInstanceRequest19(this OcipClientBase client, GroupAutoAttendantAddInstanceRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Auto Attendant instance to a group.
        /// The domain is required in the serviceUserId.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// type, use value "Basic" in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// holidayMenu
        /// The following elements are only valid for Standard Auto Attendants:
        /// holidayMenu
        /// 
        /// Replaced by: GroupAutoAttendantAddInstanceRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantAddInstanceRequest19Async(this OcipClientBase client, GroupAutoAttendantAddInstanceRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse19 or ErrorResponse.
        /// 
        /// Replaced by: GroupAutoAttendantGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantGetInstanceRequest19Async instead.")]
        public static async Task<GroupAutoAttendantGetInstanceResponse19> GroupAutoAttendantGetInstanceRequest19(this OcipClientBase client, GroupAutoAttendantGetInstanceRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAutoAttendantGetInstanceResponse19;
        }

        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse19 or ErrorResponse.
        /// 
        /// Replaced by: GroupAutoAttendantGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<GroupAutoAttendantGetInstanceResponse19> GroupAutoAttendantGetInstanceRequest19Async(this OcipClientBase client, GroupAutoAttendantGetInstanceRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAutoAttendantGetInstanceResponse19;
        }
        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupAutoAttendantGetInstanceRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantGetInstanceRequest19sp1Async instead.")]
        public static async Task<GroupAutoAttendantGetInstanceResponse19sp1> GroupAutoAttendantGetInstanceRequest19sp1(this OcipClientBase client, GroupAutoAttendantGetInstanceRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAutoAttendantGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupAutoAttendantGetInstanceRequest20 in AS data mode
        /// </summary>
        public static async Task<GroupAutoAttendantGetInstanceResponse19sp1> GroupAutoAttendantGetInstanceRequest19sp1Async(this OcipClientBase client, GroupAutoAttendantGetInstanceRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAutoAttendantGetInstanceResponse19sp1;
        }
        /// <summary>
        /// Request to modify an Auto Attendant instance.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and not returned in XS data mode:
        /// holidayMenu.
        /// The following elementsare only valid for Standard Auto Attendants:
        /// holidayMenu
        /// 
        /// Replaced by: GroupAutoAttendantModifyInstanceRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantModifyInstanceRequest17sp1Async instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantModifyInstanceRequest17sp1(this OcipClientBase client, GroupAutoAttendantModifyInstanceRequest17sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an Auto Attendant instance.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and not returned in XS data mode:
        /// holidayMenu.
        /// The following elementsare only valid for Standard Auto Attendants:
        /// holidayMenu
        /// 
        /// Replaced by: GroupAutoAttendantModifyInstanceRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantModifyInstanceRequest17sp1Async(this OcipClientBase client, GroupAutoAttendantModifyInstanceRequest17sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add an Auto Attendant submenu instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// 
        /// Replaced by: GroupAutoAttendantSubmenuAddRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantSubmenuAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuAddRequest(this OcipClientBase client, GroupAutoAttendantSubmenuAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an Auto Attendant submenu instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// 
        /// Replaced by: GroupAutoAttendantSubmenuAddRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuAddRequestAsync(this OcipClientBase client, GroupAutoAttendantSubmenuAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get an Auto Attendant submenu instance.
        /// The response is either GroupAutoAttendantSubmenuGetResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// 
        /// Replaced by: GroupAutoAttendantSubmenuGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantSubmenuGetRequestAsync instead.")]
        public static async Task<GroupAutoAttendantSubmenuGetResponse> GroupAutoAttendantSubmenuGetRequest(this OcipClientBase client, GroupAutoAttendantSubmenuGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAutoAttendantSubmenuGetResponse;
        }

        /// <summary>
        /// Request to get an Auto Attendant submenu instance.
        /// The response is either GroupAutoAttendantSubmenuGetResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// 
        /// Replaced by: GroupAutoAttendantSubmenuGetRequest20 in AS data mode
        /// </summary>
        public static async Task<GroupAutoAttendantSubmenuGetResponse> GroupAutoAttendantSubmenuGetRequestAsync(this OcipClientBase client, GroupAutoAttendantSubmenuGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAutoAttendantSubmenuGetResponse;
        }
        /// <summary>
        /// Request to modify an Auto Attendant submenu instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// 
        /// Replaced by: GroupAutoAttendantSubmenuModifyRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantSubmenuModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuModifyRequest(this OcipClientBase client, GroupAutoAttendantSubmenuModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an Auto Attendant submenu instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// 
        /// Replaced by: GroupAutoAttendantSubmenuModifyRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuModifyRequestAsync(this OcipClientBase client, GroupAutoAttendantSubmenuModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all the information of a BroadWorks Anywhere instance.
        /// The response is either GroupBroadWorksAnywhereGetInstanceResponse17 or ErrorResponse.
        /// 
        /// Replaced by: GroupBroadWorksAnywhereGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksAnywhereGetInstanceRequest17Async instead.")]
        public static async Task<GroupBroadWorksAnywhereGetInstanceResponse17> GroupBroadWorksAnywhereGetInstanceRequest17(this OcipClientBase client, GroupBroadWorksAnywhereGetInstanceRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupBroadWorksAnywhereGetInstanceResponse17;
        }

        /// <summary>
        /// Request to get all the information of a BroadWorks Anywhere instance.
        /// The response is either GroupBroadWorksAnywhereGetInstanceResponse17 or ErrorResponse.
        /// 
        /// Replaced by: GroupBroadWorksAnywhereGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<GroupBroadWorksAnywhereGetInstanceResponse17> GroupBroadWorksAnywhereGetInstanceRequest17Async(this OcipClientBase client, GroupBroadWorksAnywhereGetInstanceRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupBroadWorksAnywhereGetInstanceResponse17;
        }
        /// <summary>
        /// Get the group's custom ring back service settings.
        /// The response is either a GroupCustomRingbackGroupGetResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: GroupCustomRingbackGroupGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCustomRingbackGroupGetRequest16Async instead.")]
        public static async Task<GroupCustomRingbackGroupGetResponse16> GroupCustomRingbackGroupGetRequest16(this OcipClientBase client, GroupCustomRingbackGroupGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCustomRingbackGroupGetResponse16;
        }

        /// <summary>
        /// Get the group's custom ring back service settings.
        /// The response is either a GroupCustomRingbackGroupGetResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: GroupCustomRingbackGroupGetRequest20 in AS data mode
        /// </summary>
        public static async Task<GroupCustomRingbackGroupGetResponse16> GroupCustomRingbackGroupGetRequest16Async(this OcipClientBase client, GroupCustomRingbackGroupGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCustomRingbackGroupGetResponse16;
        }
        /// <summary>
        /// Modify the group's custom ring back service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupCustomRingbackGroupModifyRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCustomRingbackGroupModifyRequest16Async instead.")]
        public static async Task<SuccessResponse> GroupCustomRingbackGroupModifyRequest16(this OcipClientBase client, GroupCustomRingbackGroupModifyRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's custom ring back service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupCustomRingbackGroupModifyRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupCustomRingbackGroupModifyRequest16Async(this OcipClientBase client, GroupCustomRingbackGroupModifyRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Hunt Group instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// useSystemHuntGroupCLIDSetting, use value "true" in XS data mode
        /// includeHuntGroupNameInCLID, use value "true" in XS data mode
        /// 
        /// Replaced by: GroupHuntGroupAddInstanceRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupHuntGroupAddInstanceRequest19Async instead.")]
        public static async Task<SuccessResponse> GroupHuntGroupAddInstanceRequest19(this OcipClientBase client, GroupHuntGroupAddInstanceRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Hunt Group instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// useSystemHuntGroupCLIDSetting, use value "true" in XS data mode
        /// includeHuntGroupNameInCLID, use value "true" in XS data mode
        /// 
        /// Replaced by: GroupHuntGroupAddInstanceRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupHuntGroupAddInstanceRequest19Async(this OcipClientBase client, GroupHuntGroupAddInstanceRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all the information of a Hunt Group instance.
        /// The response is either GroupHuntGroupGetInstanceResponse19 or ErrorResponse.
        /// 
        /// Replaced by: GroupHuntGroupGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupHuntGroupGetInstanceRequest19Async instead.")]
        public static async Task<GroupHuntGroupGetInstanceResponse19> GroupHuntGroupGetInstanceRequest19(this OcipClientBase client, GroupHuntGroupGetInstanceRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupHuntGroupGetInstanceResponse19;
        }

        /// <summary>
        /// Request to get all the information of a Hunt Group instance.
        /// The response is either GroupHuntGroupGetInstanceResponse19 or ErrorResponse.
        /// 
        /// Replaced by: GroupHuntGroupGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<GroupHuntGroupGetInstanceResponse19> GroupHuntGroupGetInstanceRequest19Async(this OcipClientBase client, GroupHuntGroupGetInstanceRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupHuntGroupGetInstanceResponse19;
        }
        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse19 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetInstanceRequest19Async instead.")]
        public static async Task<GroupMusicOnHoldGetInstanceResponse19> GroupMusicOnHoldGetInstanceRequest19(this OcipClientBase client, GroupMusicOnHoldGetInstanceRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse19;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse19 or ErrorResponse.
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse19> GroupMusicOnHoldGetInstanceRequest19Async(this OcipClientBase client, GroupMusicOnHoldGetInstanceRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse19;
        }
        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse17 or ErrorResponse.
        /// 
        /// Replaced by: GroupPolicyGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPolicyGetRequest17Async instead.")]
        public static async Task<GroupPolicyGetResponse17> GroupPolicyGetRequest17(this OcipClientBase client, GroupPolicyGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPolicyGetResponse17;
        }

        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse17 or ErrorResponse.
        /// 
        /// Replaced by: GroupPolicyGetRequest20 in AS data mode
        /// </summary>
        public static async Task<GroupPolicyGetResponse17> GroupPolicyGetRequest17Async(this OcipClientBase client, GroupPolicyGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPolicyGetResponse17;
        }
        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPolicyGetRequest20Async instead.")]
        public static async Task<GroupPolicyGetResponse20> GroupPolicyGetRequest20(this OcipClientBase client, GroupPolicyGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPolicyGetResponse20;
        }

        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<GroupPolicyGetResponse20> GroupPolicyGetRequest20Async(this OcipClientBase client, GroupPolicyGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPolicyGetResponse20;
        }
        /// <summary>
        /// Request to modify the policies for a Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// userAutoAttendantNameDialingAccess
        /// 
        /// Replaced by: GroupPolicyModifyRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPolicyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupPolicyModifyRequest(this OcipClientBase client, GroupPolicyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the policies for a Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// userAutoAttendantNameDialingAccess
        /// 
        /// Replaced by: GroupPolicyModifyRequest22 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupPolicyModifyRequestAsync(this OcipClientBase client, GroupPolicyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the group PreAlertingservice settings.
        /// The response is either a GroupPreAlertingAnnouncementGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupPreAlertingAnnouncementGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPreAlertingAnnouncementGetRequestAsync instead.")]
        public static async Task<GroupPreAlertingAnnouncementGetResponse> GroupPreAlertingAnnouncementGetRequest(this OcipClientBase client, GroupPreAlertingAnnouncementGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPreAlertingAnnouncementGetResponse;
        }

        /// <summary>
        /// Get the group PreAlertingservice settings.
        /// The response is either a GroupPreAlertingAnnouncementGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupPreAlertingAnnouncementGetRequest20 in AS data mode
        /// </summary>
        public static async Task<GroupPreAlertingAnnouncementGetResponse> GroupPreAlertingAnnouncementGetRequestAsync(this OcipClientBase client, GroupPreAlertingAnnouncementGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPreAlertingAnnouncementGetResponse;
        }
        /// <summary>
        /// Modify the group level pre-alerting service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupPreAlertingAnnouncementModifyRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPreAlertingAnnouncementModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupPreAlertingAnnouncementModifyRequest(this OcipClientBase client, GroupPreAlertingAnnouncementModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level pre-alerting service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupPreAlertingAnnouncementModifyRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupPreAlertingAnnouncementModifyRequestAsync(this OcipClientBase client, GroupPreAlertingAnnouncementModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the group's voice portal branding settings.
        /// The response is either a GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16Async instead.")]
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16> GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16(this OcipClientBase client, GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16;
        }

        /// <summary>
        /// Get the group's voice portal branding settings.
        /// The response is either a GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20 in AS data mode
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16> GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16Async(this OcipClientBase client, GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16;
        }
        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse17sp4 or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupGetVoicePortalRequest17sp4Async instead.")]
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse17sp4> GroupVoiceMessagingGroupGetVoicePortalRequest17sp4(this OcipClientBase client, GroupVoiceMessagingGroupGetVoicePortalRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalResponse17sp4;
        }

        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse17sp4 or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse17sp4> GroupVoiceMessagingGroupGetVoicePortalRequest17sp4Async(this OcipClientBase client, GroupVoiceMessagingGroupGetVoicePortalRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalResponse17sp4;
        }
        /// <summary>
        /// Modify the group's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest16Async instead.")]
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest16(this OcipClientBase client, GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest16Async(this OcipClientBase client, GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all the information of a VoiceXML instance.
        /// The response is either GroupVoiceXmlGetInstanceResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceXmlGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceXmlGetInstanceRequestAsync instead.")]
        public static async Task<GroupVoiceXmlGetInstanceResponse> GroupVoiceXmlGetInstanceRequest(this OcipClientBase client, GroupVoiceXmlGetInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceXmlGetInstanceResponse;
        }

        /// <summary>
        /// Request to get all the information of a VoiceXML instance.
        /// The response is either GroupVoiceXmlGetInstanceResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceXmlGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<GroupVoiceXmlGetInstanceResponse> GroupVoiceXmlGetInstanceRequestAsync(this OcipClientBase client, GroupVoiceXmlGetInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceXmlGetInstanceResponse;
        }
        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse18 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderAdminGetPolicyRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminGetPolicyRequest18Async instead.")]
        public static async Task<ServiceProviderAdminGetPolicyResponse18> ServiceProviderAdminGetPolicyRequest18(this OcipClientBase client, ServiceProviderAdminGetPolicyRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAdminGetPolicyResponse18;
        }

        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse18 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderAdminGetPolicyRequest20 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderAdminGetPolicyResponse18> ServiceProviderAdminGetPolicyRequest18Async(this OcipClientBase client, ServiceProviderAdminGetPolicyRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAdminGetPolicyResponse18;
        }
        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for OriginatingRules, RedirectingRules, CallMeNowRules and IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// 
        /// Replaced By : ServiceProviderCommunicationBarringProfileAddRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileAddRequest17sp3Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileAddRequest17sp3(this OcipClientBase client, ServiceProviderCommunicationBarringProfileAddRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for OriginatingRules, RedirectingRules, CallMeNowRules and IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// 
        /// Replaced By : ServiceProviderCommunicationBarringProfileAddRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileAddRequest17sp3Async(this OcipClientBase client, ServiceProviderCommunicationBarringProfileAddRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetResponse17sp3
        /// or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileGetRequest17sp3Async instead.")]
        public static async Task<ServiceProviderCommunicationBarringProfileGetResponse17sp3> ServiceProviderCommunicationBarringProfileGetRequest17sp3(this OcipClientBase client, ServiceProviderCommunicationBarringProfileGetRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetResponse17sp3;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetResponse17sp3
        /// or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetResponse17sp3> ServiceProviderCommunicationBarringProfileGetRequest17sp3Async(this OcipClientBase client, ServiceProviderCommunicationBarringProfileGetRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetResponse17sp3;
        }
        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetResponse19sp1
        /// or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileGetRequest19sp1Async instead.")]
        public static async Task<ServiceProviderCommunicationBarringProfileGetResponse19sp1> ServiceProviderCommunicationBarringProfileGetRequest19sp1(this OcipClientBase client, ServiceProviderCommunicationBarringProfileGetRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetResponse19sp1;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetResponse19sp1
        /// or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetResponse19sp1> ServiceProviderCommunicationBarringProfileGetRequest19sp1Async(this OcipClientBase client, ServiceProviderCommunicationBarringProfileGetRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetResponse19sp1;
        }
        /// <summary>
        /// Get the list of feature access codes for a service provider or enterprise.
        /// The response is either a ServiceProviderFeatureAccessCodeGetListResponse or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderFeatureAccessCodeGetListRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderFeatureAccessCodeGetListRequestAsync instead.")]
        public static async Task<ServiceProviderFeatureAccessCodeGetListResponse> ServiceProviderFeatureAccessCodeGetListRequest(this OcipClientBase client, ServiceProviderFeatureAccessCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderFeatureAccessCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of feature access codes for a service provider or enterprise.
        /// The response is either a ServiceProviderFeatureAccessCodeGetListResponse or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderFeatureAccessCodeGetListRequest20 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderFeatureAccessCodeGetListResponse> ServiceProviderFeatureAccessCodeGetListRequestAsync(this OcipClientBase client, ServiceProviderFeatureAccessCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderFeatureAccessCodeGetListResponse;
        }
        /// <summary>
        /// Modify a list of feature access codes for a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By : ServiceProviderFeatureAccessCodeModifyListRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderFeatureAccessCodeModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderFeatureAccessCodeModifyListRequest(this OcipClientBase client, ServiceProviderFeatureAccessCodeModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a list of feature access codes for a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By : ServiceProviderFeatureAccessCodeModifyListRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderFeatureAccessCodeModifyListRequestAsync(this OcipClientBase client, ServiceProviderFeatureAccessCodeModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// 
        /// Replaced by: SystemCommunicationBarringProfileAddRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileAddRequest17sp3Async instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileAddRequest17sp3(this OcipClientBase client, SystemCommunicationBarringProfileAddRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// 
        /// Replaced by: SystemCommunicationBarringProfileAddRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileAddRequest17sp3Async(this OcipClientBase client, SystemCommunicationBarringProfileAddRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse17sp3
        /// or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringProfileGetRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetRequest17sp3Async instead.")]
        public static async Task<SystemCommunicationBarringProfileGetResponse17sp3> SystemCommunicationBarringProfileGetRequest17sp3(this OcipClientBase client, SystemCommunicationBarringProfileGetRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetResponse17sp3;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse17sp3
        /// or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringProfileGetRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetResponse17sp3> SystemCommunicationBarringProfileGetRequest17sp3Async(this OcipClientBase client, SystemCommunicationBarringProfileGetRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetResponse17sp3;
        }
        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse19sp1
        /// or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetRequest19sp1Async instead.")]
        public static async Task<SystemCommunicationBarringProfileGetResponse19sp1> SystemCommunicationBarringProfileGetRequest19sp1(this OcipClientBase client, SystemCommunicationBarringProfileGetRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetResponse19sp1;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse19sp1
        /// or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetResponse19sp1> SystemCommunicationBarringProfileGetRequest19sp1Async(this OcipClientBase client, SystemCommunicationBarringProfileGetRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetResponse19sp1;
        }
        /// <summary>
        /// Request to get the File System parameters.
        /// The response is either SystemConfigurableFileSystemGetResponse or ErrorResponse.
        /// Replaced by: SystemConfigurableFileSystemGetRequest23
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableFileSystemGetRequestAsync instead.")]
        public static async Task<SystemConfigurableFileSystemGetResponse> SystemConfigurableFileSystemGetRequest(this OcipClientBase client, SystemConfigurableFileSystemGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemConfigurableFileSystemGetResponse;
        }

        /// <summary>
        /// Request to get the File System parameters.
        /// The response is either SystemConfigurableFileSystemGetResponse or ErrorResponse.
        /// Replaced by: SystemConfigurableFileSystemGetRequest23
        /// </summary>
        public static async Task<SystemConfigurableFileSystemGetResponse> SystemConfigurableFileSystemGetRequestAsync(this OcipClientBase client, SystemConfigurableFileSystemGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemConfigurableFileSystemGetResponse;
        }
        /// <summary>
        /// Get an existing Network Class of Service.
        /// The response is either a SystemNetworkClassOfServiceGetResponse17
        /// or an ErrorResponse.
        /// 
        /// Replaced by: SystemNetworkClassOfServiceGetRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceGetRequest17Async instead.")]
        public static async Task<SystemNetworkClassOfServiceGetResponse17> SystemNetworkClassOfServiceGetRequest17(this OcipClientBase client, SystemNetworkClassOfServiceGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkClassOfServiceGetResponse17;
        }

        /// <summary>
        /// Get an existing Network Class of Service.
        /// The response is either a SystemNetworkClassOfServiceGetResponse17
        /// or an ErrorResponse.
        /// 
        /// Replaced by: SystemNetworkClassOfServiceGetRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<SystemNetworkClassOfServiceGetResponse17> SystemNetworkClassOfServiceGetRequest17Async(this OcipClientBase client, SystemNetworkClassOfServiceGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkClassOfServiceGetResponse17;
        }
        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse18 or ErrorResponse.
        /// 
        /// Replaced by: SystemPolicyGetDefaultRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPolicyGetDefaultRequest18Async instead.")]
        public static async Task<SystemPolicyGetDefaultResponse18> SystemPolicyGetDefaultRequest18(this OcipClientBase client, SystemPolicyGetDefaultRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPolicyGetDefaultResponse18;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse18 or ErrorResponse.
        /// 
        /// Replaced by: SystemPolicyGetDefaultRequest20 in AS data mode
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse18> SystemPolicyGetDefaultRequest18Async(this OcipClientBase client, SystemPolicyGetDefaultRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPolicyGetDefaultResponse18;
        }
        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: SystemPolicyGetDefaultRequest20 in AS mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPolicyGetDefaultRequest19sp1Async instead.")]
        public static async Task<SystemPolicyGetDefaultResponse19sp1> SystemPolicyGetDefaultRequest19sp1(this OcipClientBase client, SystemPolicyGetDefaultRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPolicyGetDefaultResponse19sp1;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: SystemPolicyGetDefaultRequest20 in AS mode
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse19sp1> SystemPolicyGetDefaultRequest19sp1Async(this OcipClientBase client, SystemPolicyGetDefaultRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPolicyGetDefaultResponse19sp1;
        }
        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse20 or ErrorResponse.
        /// 
        /// Replaced by: SystemPolicyGetDefaultRequest22 in AS mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPolicyGetDefaultRequest20Async instead.")]
        public static async Task<SystemPolicyGetDefaultResponse20> SystemPolicyGetDefaultRequest20(this OcipClientBase client, SystemPolicyGetDefaultRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPolicyGetDefaultResponse20;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse20 or ErrorResponse.
        /// 
        /// Replaced by: SystemPolicyGetDefaultRequest22 in AS mode
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse20> SystemPolicyGetDefaultRequest20Async(this OcipClientBase client, SystemPolicyGetDefaultRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPolicyGetDefaultResponse20;
        }
        /// <summary>
        /// Request to modify the system's default policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// GroupAdminDialableCallerIDAccess
        /// ServiceProviderAdminDialableCallerIDAccess
        /// GroupAdminCommunicationBarringUserProfileAccess (This element is only used for groups in an Enterprise)
        /// GroupAdminVerifyTranslationAndRoutingAccess
        /// ServiceProviderVerifyTranslationAndRoutingAccess
        /// groupUserAutoAttendantNameDialingAccess
        /// The following elements are only used in XS data mode:
        /// serviceProviderAdminCommunicationBarringAccess
        /// 
        /// Replaced by: SystemPolicyModifyDefaultRequest22 in AS mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPolicyModifyDefaultRequest14Async instead.")]
        public static async Task<SuccessResponse> SystemPolicyModifyDefaultRequest14(this OcipClientBase client, SystemPolicyModifyDefaultRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system's default policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// GroupAdminDialableCallerIDAccess
        /// ServiceProviderAdminDialableCallerIDAccess
        /// GroupAdminCommunicationBarringUserProfileAccess (This element is only used for groups in an Enterprise)
        /// GroupAdminVerifyTranslationAndRoutingAccess
        /// ServiceProviderVerifyTranslationAndRoutingAccess
        /// groupUserAutoAttendantNameDialingAccess
        /// The following elements are only used in XS data mode:
        /// serviceProviderAdminCommunicationBarringAccess
        /// 
        /// Replaced by: SystemPolicyModifyDefaultRequest22 in AS mode
        /// </summary>
        public static async Task<SuccessResponse> SystemPolicyModifyDefaultRequest14Async(this OcipClientBase client, SystemPolicyModifyDefaultRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of time zone names.
        /// The response is either SystemTimeZoneGetListResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemTimeZoneGetListRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTimeZoneGetListRequestAsync instead.")]
        public static async Task<SystemTimeZoneGetListResponse> SystemTimeZoneGetListRequest(this OcipClientBase client, SystemTimeZoneGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTimeZoneGetListResponse;
        }

        /// <summary>
        /// Requests the list of time zone names.
        /// The response is either SystemTimeZoneGetListResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemTimeZoneGetListRequest20 in AS data mode
        /// </summary>
        public static async Task<SystemTimeZoneGetListResponse> SystemTimeZoneGetListRequestAsync(this OcipClientBase client, SystemTimeZoneGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTimeZoneGetListResponse;
        }
        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse16sp2 or an ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVoiceMessagingGroupGetRequest16sp2Async instead.")]
        public static async Task<SystemVoiceMessagingGroupGetResponse16sp2> SystemVoiceMessagingGroupGetRequest16sp2(this OcipClientBase client, SystemVoiceMessagingGroupGetRequest16sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse16sp2;
        }

        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse16sp2 or an ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest20 in AS data mode
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetResponse16sp2> SystemVoiceMessagingGroupGetRequest16sp2Async(this OcipClientBase client, SystemVoiceMessagingGroupGetRequest16sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse16sp2;
        }
        /// <summary>
        /// Request the user level data associated with Call Policies.
        /// The response is either a UserCallPoliciesGetResponse17
        /// or an ErrorResponse.
        /// 
        /// Replaced by: UserCallPoliciesGetRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallPoliciesGetRequest17Async instead.")]
        public static async Task<UserCallPoliciesGetResponse17> UserCallPoliciesGetRequest17(this OcipClientBase client, UserCallPoliciesGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallPoliciesGetResponse17;
        }

        /// <summary>
        /// Request the user level data associated with Call Policies.
        /// The response is either a UserCallPoliciesGetResponse17
        /// or an ErrorResponse.
        /// 
        /// Replaced by: UserCallPoliciesGetRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<UserCallPoliciesGetResponse17> UserCallPoliciesGetRequest17Async(this OcipClientBase client, UserCallPoliciesGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallPoliciesGetResponse17;
        }
        /// <summary>
        /// Get the list of feature access codes for a user.
        /// The response is either a UserFeatureAccessCodeGetListResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserFeatureAccessCodeGetListRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserFeatureAccessCodeGetListRequestAsync instead.")]
        public static async Task<UserFeatureAccessCodeGetListResponse> UserFeatureAccessCodeGetListRequest(this OcipClientBase client, UserFeatureAccessCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserFeatureAccessCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of feature access codes for a user.
        /// The response is either a UserFeatureAccessCodeGetListResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserFeatureAccessCodeGetListRequest20 in AS data mode
        /// </summary>
        public static async Task<UserFeatureAccessCodeGetListResponse> UserFeatureAccessCodeGetListRequestAsync(this OcipClientBase client, UserFeatureAccessCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserFeatureAccessCodeGetListResponse;
        }
        /// <summary>
        /// Request the user level data associated with Music On Hold User.
        /// The response is either a UserMusicOnHoldUserGetResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: UserMusicOnHoldUserGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMusicOnHoldUserGetRequest16Async instead.")]
        public static async Task<UserMusicOnHoldUserGetResponse16> UserMusicOnHoldUserGetRequest16(this OcipClientBase client, UserMusicOnHoldUserGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMusicOnHoldUserGetResponse16;
        }

        /// <summary>
        /// Request the user level data associated with Music On Hold User.
        /// The response is either a UserMusicOnHoldUserGetResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: UserMusicOnHoldUserGetRequest20 in AS data mode
        /// </summary>
        public static async Task<UserMusicOnHoldUserGetResponse16> UserMusicOnHoldUserGetRequest16Async(this OcipClientBase client, UserMusicOnHoldUserGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMusicOnHoldUserGetResponse16;
        }
        /// <summary>
        /// Modify data for Music On Hold User.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserMusicOnHoldUserModifyRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMusicOnHoldUserModifyRequest16Async instead.")]
        public static async Task<SuccessResponse> UserMusicOnHoldUserModifyRequest16(this OcipClientBase client, UserMusicOnHoldUserModifyRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify data for Music On Hold User.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserMusicOnHoldUserModifyRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> UserMusicOnHoldUserModifyRequest16Async(this OcipClientBase client, UserMusicOnHoldUserModifyRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user's pre-alerting service setting.
        /// The response is either a UserPreAlertingAnnouncementGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserPreAlertingAnnouncementGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreAlertingAnnouncementGetRequestAsync instead.")]
        public static async Task<UserPreAlertingAnnouncementGetResponse> UserPreAlertingAnnouncementGetRequest(this OcipClientBase client, UserPreAlertingAnnouncementGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPreAlertingAnnouncementGetResponse;
        }

        /// <summary>
        /// Get the user's pre-alerting service setting.
        /// The response is either a UserPreAlertingAnnouncementGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserPreAlertingAnnouncementGetRequest20 in AS data mode
        /// </summary>
        public static async Task<UserPreAlertingAnnouncementGetResponse> UserPreAlertingAnnouncementGetRequestAsync(this OcipClientBase client, UserPreAlertingAnnouncementGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPreAlertingAnnouncementGetResponse;
        }
        /// <summary>
        /// Modify the user's pre-alerting service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserPreAlertingAnnouncementModifyRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreAlertingAnnouncementModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPreAlertingAnnouncementModifyRequest(this OcipClientBase client, UserPreAlertingAnnouncementModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's pre-alerting service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserPreAlertingAnnouncementModifyRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> UserPreAlertingAnnouncementModifyRequestAsync(this OcipClientBase client, UserPreAlertingAnnouncementModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user's voice messaging greeting information.
        /// The response is either a UserVoiceMessagingUserGetGreetingResponse18 or an ErrorResponse.
        /// 
        /// Replaced by UserVoiceMessagingUserGetGreetingRequest18sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserGetGreetingRequest18Async instead.")]
        public static async Task<UserVoiceMessagingUserGetGreetingResponse18> UserVoiceMessagingUserGetGreetingRequest18(this OcipClientBase client, UserVoiceMessagingUserGetGreetingRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserVoiceMessagingUserGetGreetingResponse18;
        }

        /// <summary>
        /// Get the user's voice messaging greeting information.
        /// The response is either a UserVoiceMessagingUserGetGreetingResponse18 or an ErrorResponse.
        /// 
        /// Replaced by UserVoiceMessagingUserGetGreetingRequest18sp1 in AS data mode
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetGreetingResponse18> UserVoiceMessagingUserGetGreetingRequest18Async(this OcipClientBase client, UserVoiceMessagingUserGetGreetingRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserVoiceMessagingUserGetGreetingResponse18;
        }
        /// <summary>
        /// Get group FAC code level and the list of feature access codes for a group.
        /// The response is either a GroupFeatureAccessCodeGetResponse or an ErrorResponse.
        /// Returned Feature Access Codes may be group specific, or Service Provider Feature Access Codes, depending on FAC code level.
        /// 
        /// Replaced by: GroupFeatureAccessCodeGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFeatureAccessCodeGetRequestAsync instead.")]
        public static async Task<GroupFeatureAccessCodeGetResponse> GroupFeatureAccessCodeGetRequest(this OcipClientBase client, GroupFeatureAccessCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupFeatureAccessCodeGetResponse;
        }

        /// <summary>
        /// Get group FAC code level and the list of feature access codes for a group.
        /// The response is either a GroupFeatureAccessCodeGetResponse or an ErrorResponse.
        /// Returned Feature Access Codes may be group specific, or Service Provider Feature Access Codes, depending on FAC code level.
        /// 
        /// Replaced by: GroupFeatureAccessCodeGetRequest21 in AS data mode
        /// </summary>
        public static async Task<GroupFeatureAccessCodeGetResponse> GroupFeatureAccessCodeGetRequestAsync(this OcipClientBase client, GroupFeatureAccessCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupFeatureAccessCodeGetResponse;
        }
        /// <summary>
        /// Modify group FAC code level and the list of feature access codes for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note: choice element is only valid when useFeatureAccessCodeLevel is set to "Group", otherwise an ErrorResponse will be returned.
        /// 
        /// Replaced by: GroupFeatureAccessCodeModifyRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFeatureAccessCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFeatureAccessCodeModifyRequest(this OcipClientBase client, GroupFeatureAccessCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify group FAC code level and the list of feature access codes for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note: choice element is only valid when useFeatureAccessCodeLevel is set to "Group", otherwise an ErrorResponse will be returned.
        /// 
        /// Replaced by: GroupFeatureAccessCodeModifyRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupFeatureAccessCodeModifyRequestAsync(this OcipClientBase client, GroupFeatureAccessCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldAddInstanceRequest21
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldAddInstanceRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest20(this OcipClientBase client, GroupMusicOnHoldAddInstanceRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldAddInstanceRequest21
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest20Async(this OcipClientBase client, GroupMusicOnHoldAddInstanceRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse20 or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest21
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetInstanceRequest20Async instead.")]
        public static async Task<GroupMusicOnHoldGetInstanceResponse20> GroupMusicOnHoldGetInstanceRequest20(this OcipClientBase client, GroupMusicOnHoldGetInstanceRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse20;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse20 or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest21
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse20> GroupMusicOnHoldGetInstanceRequest20Async(this OcipClientBase client, GroupMusicOnHoldGetInstanceRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse20;
        }
        /// <summary>
        /// Modify data for a group or department Music On Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldModifyInstanceRequest21
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldModifyInstanceRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest20(this OcipClientBase client, GroupMusicOnHoldModifyInstanceRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify data for a group or department Music On Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldModifyInstanceRequest21
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest20Async(this OcipClientBase client, GroupMusicOnHoldModifyInstanceRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of Network Classes of Service to a group.
        /// The Element defaultNetworkClassOfService is required only for the first
        /// assignment, for subsequent assignments it is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNetworkClassOfServiceAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceAssignListRequest(this OcipClientBase client, GroupNetworkClassOfServiceAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Network Classes of Service to a group.
        /// The Element defaultNetworkClassOfService is required only for the first
        /// assignment, for subsequent assignments it is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceAssignListRequestAsync(this OcipClientBase client, GroupNetworkClassOfServiceAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of users within a group that have a given Network Class
        /// of Service assigned.
        /// The response is either a GroupNetworkClassOfServiceGetAssignedUserListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNetworkClassOfServiceGetAssignedUserListRequestAsync instead.")]
        public static async Task<GroupNetworkClassOfServiceGetAssignedUserListResponse> GroupNetworkClassOfServiceGetAssignedUserListRequest(this OcipClientBase client, GroupNetworkClassOfServiceGetAssignedUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupNetworkClassOfServiceGetAssignedUserListResponse;
        }

        /// <summary>
        /// Get a list of users within a group that have a given Network Class
        /// of Service assigned.
        /// The response is either a GroupNetworkClassOfServiceGetAssignedUserListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupNetworkClassOfServiceGetAssignedUserListResponse> GroupNetworkClassOfServiceGetAssignedUserListRequestAsync(this OcipClientBase client, GroupNetworkClassOfServiceGetAssignedUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupNetworkClassOfServiceGetAssignedUserListResponse;
        }
        /// <summary>
        /// Unassign a list of Network Classes of Service from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNetworkClassOfServiceUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceUnassignListRequest(this OcipClientBase client, GroupNetworkClassOfServiceUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Network Classes of Service from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceUnassignListRequestAsync(this OcipClientBase client, GroupNetworkClassOfServiceUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request a table containing the phone directory for a group.
        /// If the specified group is part of an enterprise, the directory
        /// includes all users in the enterprise and all entries in the enterprise
        /// common phone list and the common phone list of the specified group.
        /// 
        /// If the specified group is part of a service provider, the directory
        /// includes all users in the group and all entries in the common phone
        /// list of the specified group.
        /// 
        /// It is possible to search by various criteria to restrict the number of
        /// rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together.
        /// The response is either GroupPhoneDirectoryGetListResponse18 or
        /// ErrorResponse.
        /// 
        /// Replaced By: GroupPhoneDirectoryGetPagedSortedListRequest
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPhoneDirectoryGetListRequest18Async instead.")]
        public static async Task<GroupPhoneDirectoryGetListResponse18> GroupPhoneDirectoryGetListRequest18(this OcipClientBase client, GroupPhoneDirectoryGetListRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPhoneDirectoryGetListResponse18;
        }

        /// <summary>
        /// Request a table containing the phone directory for a group.
        /// If the specified group is part of an enterprise, the directory
        /// includes all users in the enterprise and all entries in the enterprise
        /// common phone list and the common phone list of the specified group.
        /// 
        /// If the specified group is part of a service provider, the directory
        /// includes all users in the group and all entries in the common phone
        /// list of the specified group.
        /// 
        /// It is possible to search by various criteria to restrict the number of
        /// rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together.
        /// The response is either GroupPhoneDirectoryGetListResponse18 or
        /// ErrorResponse.
        /// 
        /// Replaced By: GroupPhoneDirectoryGetPagedSortedListRequest
        /// </summary>
        public static async Task<GroupPhoneDirectoryGetListResponse18> GroupPhoneDirectoryGetListRequest18Async(this OcipClientBase client, GroupPhoneDirectoryGetListRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPhoneDirectoryGetListResponse18;
        }
        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse or ErrorResponse.
        /// Replaced by: ServiceProviderIntegratedIMPGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderIntegratedIMPGetRequestAsync instead.")]
        public static async Task<ServiceProviderIntegratedIMPGetResponse> ServiceProviderIntegratedIMPGetRequest(this OcipClientBase client, ServiceProviderIntegratedIMPGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderIntegratedIMPGetResponse;
        }

        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse or ErrorResponse.
        /// Replaced by: ServiceProviderIntegratedIMPGetRequest21 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderIntegratedIMPGetResponse> ServiceProviderIntegratedIMPGetRequestAsync(this OcipClientBase client, ServiceProviderIntegratedIMPGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderIntegratedIMPGetResponse;
        }
        /// <summary>
        /// Assign a list of Network Classes of Service to a service provider.
        /// The Element defaultNetworkClassOfService is required only
        /// for the first assignment,
        /// for subsequent assignments it is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderNetworkClassOfServiceAssignListRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNetworkClassOfServiceAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignListRequest(this OcipClientBase client, ServiceProviderNetworkClassOfServiceAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Network Classes of Service to a service provider.
        /// The Element defaultNetworkClassOfService is required only
        /// for the first assignment,
        /// for subsequent assignments it is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderNetworkClassOfServiceAssignListRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignListRequestAsync(this OcipClientBase client, ServiceProviderNetworkClassOfServiceAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Unassign a list of Network Classes of Service from a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderNetworkClassOfServiceUnassignListRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNetworkClassOfServiceUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceUnassignListRequest(this OcipClientBase client, ServiceProviderNetworkClassOfServiceUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Network Classes of Service from a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderNetworkClassOfServiceUnassignListRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceUnassignListRequestAsync(this OcipClientBase client, ServiceProviderNetworkClassOfServiceUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Create a service pack migration task.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderServicePackMigrationTaskAddRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskAddRequest(this OcipClientBase client, ServiceProviderServicePackMigrationTaskAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Create a service pack migration task.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderServicePackMigrationTaskAddRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskAddRequestAsync(this OcipClientBase client, ServiceProviderServicePackMigrationTaskAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a list of all service pack migration task for a service provider.
        /// The response is either ServiceProviderServicePackMigrationTaskGetListResponse
        /// or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderServicePackMigrationTaskGetListRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskGetListRequestAsync instead.")]
        public static async Task<ServiceProviderServicePackMigrationTaskGetListResponse> ServiceProviderServicePackMigrationTaskGetListRequest(this OcipClientBase client, ServiceProviderServicePackMigrationTaskGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetListResponse;
        }

        /// <summary>
        /// Requests a list of all service pack migration task for a service provider.
        /// The response is either ServiceProviderServicePackMigrationTaskGetListResponse
        /// or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderServicePackMigrationTaskGetListRequest21 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderServicePackMigrationTaskGetListResponse> ServiceProviderServicePackMigrationTaskGetListRequestAsync(this OcipClientBase client, ServiceProviderServicePackMigrationTaskGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetListResponse;
        }
        /// <summary>
        /// Requests the details of a specified service pack migration task.
        /// The response is either ServiceProviderServicePackMigrationTaskGetResponse14sp4
        /// or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderServicePackMigrationTaskGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskGetRequest14sp4Async instead.")]
        public static async Task<ServiceProviderServicePackMigrationTaskGetResponse14sp4> ServiceProviderServicePackMigrationTaskGetRequest14sp4(this OcipClientBase client, ServiceProviderServicePackMigrationTaskGetRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetResponse14sp4;
        }

        /// <summary>
        /// Requests the details of a specified service pack migration task.
        /// The response is either ServiceProviderServicePackMigrationTaskGetResponse14sp4
        /// or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderServicePackMigrationTaskGetRequest21 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderServicePackMigrationTaskGetResponse14sp4> ServiceProviderServicePackMigrationTaskGetRequest14sp4Async(this OcipClientBase client, ServiceProviderServicePackMigrationTaskGetRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetResponse14sp4;
        }
        /// <summary>
        /// Request the system level data associated with Enhanced Call Logs.
        /// The response is either a SystemEnhancedCallLogsGetResponse17sp4 or an ErrorResponse.
        /// Replaced by:SystemEnhancedCallLogsGetRequest20sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEnhancedCallLogsGetRequest17sp4Async instead.")]
        public static async Task<SystemEnhancedCallLogsGetResponse17sp4> SystemEnhancedCallLogsGetRequest17sp4(this OcipClientBase client, SystemEnhancedCallLogsGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEnhancedCallLogsGetResponse17sp4;
        }

        /// <summary>
        /// Request the system level data associated with Enhanced Call Logs.
        /// The response is either a SystemEnhancedCallLogsGetResponse17sp4 or an ErrorResponse.
        /// Replaced by:SystemEnhancedCallLogsGetRequest20sp1 in AS data mode
        /// </summary>
        public static async Task<SystemEnhancedCallLogsGetResponse17sp4> SystemEnhancedCallLogsGetRequest17sp4Async(this OcipClientBase client, SystemEnhancedCallLogsGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEnhancedCallLogsGetResponse17sp4;
        }
        /// <summary>
        /// Request to get list of default Feature Access Codes defined on system level.
        /// The response is either SystemFeatureAccessCodeGetListResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemFeatureAccessCodeGetListRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFeatureAccessCodeGetListRequestAsync instead.")]
        public static async Task<SystemFeatureAccessCodeGetListResponse> SystemFeatureAccessCodeGetListRequest(this OcipClientBase client, SystemFeatureAccessCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFeatureAccessCodeGetListResponse;
        }

        /// <summary>
        /// Request to get list of default Feature Access Codes defined on system level.
        /// The response is either SystemFeatureAccessCodeGetListResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemFeatureAccessCodeGetListRequest21 in AS data mode
        /// </summary>
        public static async Task<SystemFeatureAccessCodeGetListResponse> SystemFeatureAccessCodeGetListRequestAsync(this OcipClientBase client, SystemFeatureAccessCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFeatureAccessCodeGetListResponse;
        }
        /// <summary>
        /// Modify default Feature Access Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemFeatureAccessCodeModifyListRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFeatureAccessCodeModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFeatureAccessCodeModifyListRequest(this OcipClientBase client, SystemFeatureAccessCodeModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify default Feature Access Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemFeatureAccessCodeModifyListRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemFeatureAccessCodeModifyListRequestAsync(this OcipClientBase client, SystemFeatureAccessCodeModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Hunt Group.
        /// The response is either a SystemHuntGroupGetResponse or an ErrorResponse.
        /// Replaced by: SystemHuntGroupGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHuntGroupGetRequest17Async instead.")]
        public static async Task<SystemHuntGroupGetResponse> SystemHuntGroupGetRequest17(this OcipClientBase client, SystemHuntGroupGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemHuntGroupGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Hunt Group.
        /// The response is either a SystemHuntGroupGetResponse or an ErrorResponse.
        /// Replaced by: SystemHuntGroupGetRequest21 in AS data mode
        /// </summary>
        public static async Task<SystemHuntGroupGetResponse> SystemHuntGroupGetRequest17Async(this OcipClientBase client, SystemHuntGroupGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemHuntGroupGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Hunt Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemHuntGroupModifyRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHuntGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHuntGroupModifyRequest(this OcipClientBase client, SystemHuntGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Hunt Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemHuntGroupModifyRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemHuntGroupModifyRequestAsync(this OcipClientBase client, SystemHuntGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the system Integrated IMP service attributes.
        /// The response is either SystemIntegratedIMPGetResponse19 or ErrorResponse.
        /// 
        /// Replaced by: SystemIntegratedIMPGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemIntegratedIMPGetRequest19Async instead.")]
        public static async Task<SystemIntegratedIMPGetResponse19> SystemIntegratedIMPGetRequest19(this OcipClientBase client, SystemIntegratedIMPGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemIntegratedIMPGetResponse19;
        }

        /// <summary>
        /// Get the system Integrated IMP service attributes.
        /// The response is either SystemIntegratedIMPGetResponse19 or ErrorResponse.
        /// 
        /// Replaced by: SystemIntegratedIMPGetRequest21 in AS data mode
        /// </summary>
        public static async Task<SystemIntegratedIMPGetResponse19> SystemIntegratedIMPGetRequest19Async(this OcipClientBase client, SystemIntegratedIMPGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemIntegratedIMPGetResponse19;
        }
        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetSystemLicenseListRequestAsync instead.")]
        public static async Task<SystemLicensingGetSystemLicenseListResponse> SystemLicensingGetSystemLicenseListRequest(this OcipClientBase client, SystemLicensingGetSystemLicenseListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse;
        }

        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest21 in AS data mode
        /// </summary>
        public static async Task<SystemLicensingGetSystemLicenseListResponse> SystemLicensingGetSystemLicenseListRequestAsync(this OcipClientBase client, SystemLicensingGetSystemLicenseListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse;
        }
        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest21sp1.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetSystemLicenseListRequest19sp1Async instead.")]
        public static async Task<SystemLicensingGetSystemLicenseListResponse21> SystemLicensingGetSystemLicenseListRequest19sp1(this OcipClientBase client, SystemLicensingGetSystemLicenseListRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse21;
        }

        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest21sp1.
        /// </summary>
        public static async Task<SystemLicensingGetSystemLicenseListResponse21> SystemLicensingGetSystemLicenseListRequest19sp1Async(this OcipClientBase client, SystemLicensingGetSystemLicenseListRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse21;
        }
        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest21p1.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetSystemLicenseListRequest21Async instead.")]
        public static async Task<SystemLicensingGetSystemLicenseListResponse21> SystemLicensingGetSystemLicenseListRequest21(this OcipClientBase client, SystemLicensingGetSystemLicenseListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse21;
        }

        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest21p1.
        /// </summary>
        public static async Task<SystemLicensingGetSystemLicenseListResponse21> SystemLicensingGetSystemLicenseListRequest21Async(this OcipClientBase client, SystemLicensingGetSystemLicenseListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse21;
        }
        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse21sp1 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest22.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetSystemLicenseListRequest21sp1Async instead.")]
        public static async Task<SystemLicensingGetSystemLicenseListResponse21sp1> SystemLicensingGetSystemLicenseListRequest21sp1(this OcipClientBase client, SystemLicensingGetSystemLicenseListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse21sp1;
        }

        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse21sp1 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest22.
        /// </summary>
        public static async Task<SystemLicensingGetSystemLicenseListResponse21sp1> SystemLicensingGetSystemLicenseListRequest21sp1Async(this OcipClientBase client, SystemLicensingGetSystemLicenseListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse21sp1;
        }
        /// <summary>
        /// Request to get the Number Activation state.
        /// The response is either SystemNumberActivationGetResponse18sp1 or ErrorResponse.
        /// Replaced by: SystemNumberActivationGetRequest21
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberActivationGetRequest18sp1Async instead.")]
        public static async Task<SystemNumberActivationGetResponse18sp1> SystemNumberActivationGetRequest18sp1(this OcipClientBase client, SystemNumberActivationGetRequest18sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberActivationGetResponse18sp1;
        }

        /// <summary>
        /// Request to get the Number Activation state.
        /// The response is either SystemNumberActivationGetResponse18sp1 or ErrorResponse.
        /// Replaced by: SystemNumberActivationGetRequest21
        /// </summary>
        public static async Task<SystemNumberActivationGetResponse18sp1> SystemNumberActivationGetRequest18sp1Async(this OcipClientBase client, SystemNumberActivationGetRequest18sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberActivationGetResponse18sp1;
        }
        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse14sp5 or an ErrorResponse.
        /// 
        /// Replaced by: SystemSMPPGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMPPGetRequest14sp5Async instead.")]
        public static async Task<SystemSMPPGetResponse14sp5> SystemSMPPGetRequest14sp5(this OcipClientBase client, SystemSMPPGetRequest14sp5 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSMPPGetResponse14sp5;
        }

        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse14sp5 or an ErrorResponse.
        /// 
        /// Replaced by: SystemSMPPGetRequest21 in AS data mode
        /// </summary>
        public static async Task<SystemSMPPGetResponse14sp5> SystemSMPPGetRequest14sp5Async(this OcipClientBase client, SystemSMPPGetRequest14sp5 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSMPPGetResponse14sp5;
        }
        /// <summary>
        /// Request the user level data associated with Alternate Numbers.
        /// The response is either a UserAlternateNumbersGetResponse17 or an ErrorResponse.
        /// 
        /// Replaced by: UserAlternateNumbersGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAlternateNumbersGetRequest17Async instead.")]
        public static async Task<UserAlternateNumbersGetResponse17> UserAlternateNumbersGetRequest17(this OcipClientBase client, UserAlternateNumbersGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAlternateNumbersGetResponse17;
        }

        /// <summary>
        /// Request the user level data associated with Alternate Numbers.
        /// The response is either a UserAlternateNumbersGetResponse17 or an ErrorResponse.
        /// 
        /// Replaced by: UserAlternateNumbersGetRequest21 in AS data mode
        /// </summary>
        public static async Task<UserAlternateNumbersGetResponse17> UserAlternateNumbersGetRequest17Async(this OcipClientBase client, UserAlternateNumbersGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAlternateNumbersGetResponse17;
        }
        /// <summary>
        /// Get a criteria for the user's BroadWorks Anywhere phone number.
        /// The response is either a UserBroadWorksAnywhereGetSelectiveCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserBroadWorksAnywhereGetSelectiveCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereGetSelectiveCriteriaRequest16Async instead.")]
        public static async Task<UserBroadWorksAnywhereGetSelectiveCriteriaResponse16> UserBroadWorksAnywhereGetSelectiveCriteriaRequest16(this OcipClientBase client, UserBroadWorksAnywhereGetSelectiveCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksAnywhereGetSelectiveCriteriaResponse16;
        }

        /// <summary>
        /// Get a criteria for the user's BroadWorks Anywhere phone number.
        /// The response is either a UserBroadWorksAnywhereGetSelectiveCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserBroadWorksAnywhereGetSelectiveCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserBroadWorksAnywhereGetSelectiveCriteriaResponse16> UserBroadWorksAnywhereGetSelectiveCriteriaRequest16Async(this OcipClientBase client, UserBroadWorksAnywhereGetSelectiveCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksAnywhereGetSelectiveCriteriaResponse16;
        }
        /// <summary>
        /// Get a criteria for the user's call forwarding selective service.
        /// The response is either a UserCallForwardingSelectiveGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserCallForwardingSelectiveGetCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingSelectiveGetCriteriaRequest16Async instead.")]
        public static async Task<UserCallForwardingSelectiveGetCriteriaResponse16> UserCallForwardingSelectiveGetCriteriaRequest16(this OcipClientBase client, UserCallForwardingSelectiveGetCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallForwardingSelectiveGetCriteriaResponse16;
        }

        /// <summary>
        /// Get a criteria for the user's call forwarding selective service.
        /// The response is either a UserCallForwardingSelectiveGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserCallForwardingSelectiveGetCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserCallForwardingSelectiveGetCriteriaResponse16> UserCallForwardingSelectiveGetCriteriaRequest16Async(this OcipClientBase client, UserCallForwardingSelectiveGetCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallForwardingSelectiveGetCriteriaResponse16;
        }
        /// <summary>
        /// Get a criteria for the user's call notify service.
        /// The response is either a UserCallNotifyGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserCallNotifyGetCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallNotifyGetCriteriaRequest16Async instead.")]
        public static async Task<UserCallNotifyGetCriteriaResponse16> UserCallNotifyGetCriteriaRequest16(this OcipClientBase client, UserCallNotifyGetCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallNotifyGetCriteriaResponse16;
        }

        /// <summary>
        /// Get a criteria for the user's call notify service.
        /// The response is either a UserCallNotifyGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserCallNotifyGetCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserCallNotifyGetCriteriaResponse16> UserCallNotifyGetCriteriaRequest16Async(this OcipClientBase client, UserCallNotifyGetCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallNotifyGetCriteriaResponse16;
        }
        /// <summary>
        /// Modify the user level data associated with Hoteling Guest.
        /// There is no provisioning error will be given when setting hostUserId to not nil value while Hoteling Guest feature is not active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by UserHotelingGuestModifyRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserHotelingGuestModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserHotelingGuestModifyRequest(this OcipClientBase client, UserHotelingGuestModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Hoteling Guest.
        /// There is no provisioning error will be given when setting hostUserId to not nil value while Hoteling Guest feature is not active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by UserHotelingGuestModifyRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> UserHotelingGuestModifyRequestAsync(this OcipClientBase client, UserHotelingGuestModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a criteria for the user's pre-alerting service.
        /// The response is either a UserPreAlertingAnnouncementGetCriteriaResponse or an ErrorResponse.
        /// Replaced by: UserPreAlertingAnnouncementGetCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreAlertingAnnouncementGetCriteriaRequestAsync instead.")]
        public static async Task<UserPreAlertingAnnouncementGetCriteriaResponse> UserPreAlertingAnnouncementGetCriteriaRequest(this OcipClientBase client, UserPreAlertingAnnouncementGetCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPreAlertingAnnouncementGetCriteriaResponse;
        }

        /// <summary>
        /// Get a criteria for the user's pre-alerting service.
        /// The response is either a UserPreAlertingAnnouncementGetCriteriaResponse or an ErrorResponse.
        /// Replaced by: UserPreAlertingAnnouncementGetCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserPreAlertingAnnouncementGetCriteriaResponse> UserPreAlertingAnnouncementGetCriteriaRequestAsync(this OcipClientBase client, UserPreAlertingAnnouncementGetCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPreAlertingAnnouncementGetCriteriaResponse;
        }
        /// <summary>
        /// Get a criteria for the user's priority alert service.
        /// The response is either a UserPriorityAlertGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserPriorityAlertGetCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPriorityAlertGetCriteriaRequest16Async instead.")]
        public static async Task<UserPriorityAlertGetCriteriaResponse16> UserPriorityAlertGetCriteriaRequest16(this OcipClientBase client, UserPriorityAlertGetCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPriorityAlertGetCriteriaResponse16;
        }

        /// <summary>
        /// Get a criteria for the user's priority alert service.
        /// The response is either a UserPriorityAlertGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserPriorityAlertGetCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserPriorityAlertGetCriteriaResponse16> UserPriorityAlertGetCriteriaRequest16Async(this OcipClientBase client, UserPriorityAlertGetCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPriorityAlertGetCriteriaResponse16;
        }
        /// <summary>
        /// Get the route list setting and the list of number ranges assigned to a user.
        /// The response is either UserRouteListGetResponse or ErrorResponse.
        /// 
        /// Replaced by: UserRouteListGetRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use UserRouteListGetRequestAsync instead.")]
        public static async Task<UserRouteListGetResponse> UserRouteListGetRequest(this OcipClientBase client, UserRouteListGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserRouteListGetResponse;
        }

        /// <summary>
        /// Get the route list setting and the list of number ranges assigned to a user.
        /// The response is either UserRouteListGetResponse or ErrorResponse.
        /// 
        /// Replaced by: UserRouteListGetRequest22
        /// </summary>
        public static async Task<UserRouteListGetResponse> UserRouteListGetRequestAsync(this OcipClientBase client, UserRouteListGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserRouteListGetResponse;
        }
        /// <summary>
        /// Get a criteria for the user's selective call acceptance service.
        /// The response is either a UserSelectiveCallAcceptanceGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserSelectiveCallAcceptanceGetCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallAcceptanceGetCriteriaRequest16Async instead.")]
        public static async Task<UserSelectiveCallAcceptanceGetCriteriaResponse16> UserSelectiveCallAcceptanceGetCriteriaRequest16(this OcipClientBase client, UserSelectiveCallAcceptanceGetCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSelectiveCallAcceptanceGetCriteriaResponse16;
        }

        /// <summary>
        /// Get a criteria for the user's selective call acceptance service.
        /// The response is either a UserSelectiveCallAcceptanceGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserSelectiveCallAcceptanceGetCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserSelectiveCallAcceptanceGetCriteriaResponse16> UserSelectiveCallAcceptanceGetCriteriaRequest16Async(this OcipClientBase client, UserSelectiveCallAcceptanceGetCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSelectiveCallAcceptanceGetCriteriaResponse16;
        }
        /// <summary>
        /// Get a criteria for the user's selective call rejection service.
        /// The response is either a UserSelectiveCallRejectionGetCriteriaResponse16sp1 or an ErrorResponse.
        /// Replaced by: UserSelectiveCallRejectionGetCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallRejectionGetCriteriaRequest16sp1Async instead.")]
        public static async Task<UserSelectiveCallRejectionGetCriteriaResponse16sp1> UserSelectiveCallRejectionGetCriteriaRequest16sp1(this OcipClientBase client, UserSelectiveCallRejectionGetCriteriaRequest16sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSelectiveCallRejectionGetCriteriaResponse16sp1;
        }

        /// <summary>
        /// Get a criteria for the user's selective call rejection service.
        /// The response is either a UserSelectiveCallRejectionGetCriteriaResponse16sp1 or an ErrorResponse.
        /// Replaced by: UserSelectiveCallRejectionGetCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserSelectiveCallRejectionGetCriteriaResponse16sp1> UserSelectiveCallRejectionGetCriteriaRequest16sp1Async(this OcipClientBase client, UserSelectiveCallRejectionGetCriteriaRequest16sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSelectiveCallRejectionGetCriteriaResponse16sp1;
        }
        /// <summary>
        /// AuthenticationRequest is 1st stage of the 2 stage OCI login process.
        /// The response is either AuthenticationResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use AuthenticationRequestAsync instead.")]
        public static async Task<AuthenticationResponse> AuthenticationRequest(this OcipClientBase client, AuthenticationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as AuthenticationResponse;
        }

        /// <summary>
        /// AuthenticationRequest is 1st stage of the 2 stage OCI login process.
        /// The response is either AuthenticationResponse or ErrorResponse
        /// </summary>
        public static async Task<AuthenticationResponse> AuthenticationRequestAsync(this OcipClientBase client, AuthenticationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as AuthenticationResponse;
        }
        /// <summary>
        /// Request a table containing the phone directory for an enterprise.
        /// The directory includes all users in the enterprise and all entries in the enterprise common phone list.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either EnterprisePhoneDirectoryGetListResponse18 or ErrorResponse.
        /// 
        /// Replaced By: EnterprisePhoneDirectoryGetPagedSortedListRequest
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterprisePhoneDirectoryGetListRequest18Async instead.")]
        public static async Task<EnterprisePhoneDirectoryGetListResponse18> EnterprisePhoneDirectoryGetListRequest18(this OcipClientBase client, EnterprisePhoneDirectoryGetListRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterprisePhoneDirectoryGetListResponse18;
        }

        /// <summary>
        /// Request a table containing the phone directory for an enterprise.
        /// The directory includes all users in the enterprise and all entries in the enterprise common phone list.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either EnterprisePhoneDirectoryGetListResponse18 or ErrorResponse.
        /// 
        /// Replaced By: EnterprisePhoneDirectoryGetPagedSortedListRequest
        /// </summary>
        public static async Task<EnterprisePhoneDirectoryGetListResponse18> EnterprisePhoneDirectoryGetListRequest18Async(this OcipClientBase client, EnterprisePhoneDirectoryGetListRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterprisePhoneDirectoryGetListResponse18;
        }
        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetUserListResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// 
        /// Replaced by: GroupAccessDeviceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetUserListRequestAsync instead.")]
        public static async Task<GroupAccessDeviceGetUserListResponse> GroupAccessDeviceGetUserListRequest(this OcipClientBase client, GroupAccessDeviceGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetUserListResponse;
        }

        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetUserListResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// 
        /// Replaced by: GroupAccessDeviceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<GroupAccessDeviceGetUserListResponse> GroupAccessDeviceGetUserListRequestAsync(this OcipClientBase client, GroupAccessDeviceGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetUserListResponse;
        }
        /// <summary>
        /// Get a group administrators profile.
        /// The response is either a GroupAdminGetResponse or an ErrorResponse.
        /// Replaced by GroupAdminGetRequest21sp1.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminGetRequestAsync instead.")]
        public static async Task<GroupAdminGetResponse> GroupAdminGetRequest(this OcipClientBase client, GroupAdminGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdminGetResponse;
        }

        /// <summary>
        /// Get a group administrators profile.
        /// The response is either a GroupAdminGetResponse or an ErrorResponse.
        /// Replaced by GroupAdminGetRequest21sp1.
        /// </summary>
        public static async Task<GroupAdminGetResponse> GroupAdminGetRequestAsync(this OcipClientBase client, GroupAdminGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdminGetResponse;
        }
        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse19 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetAnnouncementRequest19Async instead.")]
        public static async Task<GroupCallCenterGetAnnouncementResponse19> GroupCallCenterGetAnnouncementRequest19(this OcipClientBase client, GroupCallCenterGetAnnouncementRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetAnnouncementResponse19;
        }

        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse19 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetAnnouncementResponse19> GroupCallCenterGetAnnouncementRequest19Async(this OcipClientBase client, GroupCallCenterGetAnnouncementRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetAnnouncementResponse19;
        }
        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetAnnouncementRequest20Async instead.")]
        public static async Task<GroupCallCenterGetAnnouncementResponse20> GroupCallCenterGetAnnouncementRequest20(this OcipClientBase client, GroupCallCenterGetAnnouncementRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetAnnouncementResponse20;
        }

        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetAnnouncementResponse20> GroupCallCenterGetAnnouncementRequest20Async(this OcipClientBase client, GroupCallCenterGetAnnouncementRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetAnnouncementResponse20;
        }
        /// <summary>
        /// Modify a call center's announcement settings.
        /// The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyAnnouncementRequest17Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyAnnouncementRequest17(this OcipClientBase client, GroupCallCenterModifyAnnouncementRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's announcement settings.
        /// The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyAnnouncementRequest17Async(this OcipClientBase client, GroupCallCenterModifyAnnouncementRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a call center's overflow settings.
        /// The response is either a GroupCallCenterOverflowGetResponse17 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterOverflowGetRequest17Async instead.")]
        public static async Task<GroupCallCenterOverflowGetResponse17> GroupCallCenterOverflowGetRequest17(this OcipClientBase client, GroupCallCenterOverflowGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterOverflowGetResponse17;
        }

        /// <summary>
        /// Get a call center's overflow settings.
        /// The response is either a GroupCallCenterOverflowGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterOverflowGetResponse17> GroupCallCenterOverflowGetRequest17Async(this OcipClientBase client, GroupCallCenterOverflowGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterOverflowGetResponse17;
        }
        /// <summary>
        /// Modify a call center's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterOverflowModifyRequest17Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterOverflowModifyRequest17(this OcipClientBase client, GroupCallCenterOverflowModifyRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterOverflowModifyRequest17Async(this OcipClientBase client, GroupCallCenterOverflowModifyRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse21sp2 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls, maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing, routeOverrideDomain, routeOverridePrefix)
        /// 
        /// Replaced by: GroupCallProcessingGetPolicyRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallProcessingGetPolicyRequest21sp2Async instead.")]
        public static async Task<GroupCallProcessingGetPolicyResponse21sp2> GroupCallProcessingGetPolicyRequest21sp2(this OcipClientBase client, GroupCallProcessingGetPolicyRequest21sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallProcessingGetPolicyResponse21sp2;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse21sp2 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls, maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing, routeOverrideDomain, routeOverridePrefix)
        /// 
        /// Replaced by: GroupCallProcessingGetPolicyRequest22 in AS data mode
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse21sp2> GroupCallProcessingGetPolicyRequest21sp2Async(this OcipClientBase client, GroupCallProcessingGetPolicyRequest21sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallProcessingGetPolicyResponse21sp2;
        }
        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse22 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes,
        /// useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth,
        /// useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
        /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// Replaced by: GroupCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallProcessingGetPolicyRequest22Async instead.")]
        public static async Task<GroupCallProcessingGetPolicyResponse22> GroupCallProcessingGetPolicyRequest22(this OcipClientBase client, GroupCallProcessingGetPolicyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallProcessingGetPolicyResponse22;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse22 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes,
        /// useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth,
        /// useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
        /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// Replaced by: GroupCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse22> GroupCallProcessingGetPolicyRequest22Async(this OcipClientBase client, GroupCallProcessingGetPolicyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallProcessingGetPolicyResponse22;
        }
        /// <summary>
        /// Add a list of Communication Barring Authorization codes to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupCommunicationBarringAuthorizationCodeAddListRequest21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringAuthorizationCodeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCommunicationBarringAuthorizationCodeAddListRequest(this OcipClientBase client, GroupCommunicationBarringAuthorizationCodeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of Communication Barring Authorization codes to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupCommunicationBarringAuthorizationCodeAddListRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupCommunicationBarringAuthorizationCodeAddListRequestAsync(this OcipClientBase client, GroupCommunicationBarringAuthorizationCodeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Communication Barring Authorization Codes for a group.
        /// The response is either a GroupCommunicationBarringAuthorizationCodeGetListResponse
        /// or an ErrorResponse.
        /// 
        /// Replaced by: GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringAuthorizationCodeGetListRequestAsync instead.")]
        public static async Task<GroupCommunicationBarringAuthorizationCodeGetListResponse> GroupCommunicationBarringAuthorizationCodeGetListRequest(this OcipClientBase client, GroupCommunicationBarringAuthorizationCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCommunicationBarringAuthorizationCodeGetListResponse;
        }

        /// <summary>
        /// Get a list of Communication Barring Authorization Codes for a group.
        /// The response is either a GroupCommunicationBarringAuthorizationCodeGetListResponse
        /// or an ErrorResponse.
        /// 
        /// Replaced by: GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<GroupCommunicationBarringAuthorizationCodeGetListResponse> GroupCommunicationBarringAuthorizationCodeGetListRequestAsync(this OcipClientBase client, GroupCommunicationBarringAuthorizationCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCommunicationBarringAuthorizationCodeGetListResponse;
        }
        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse22 or an ErrorResponse.
        /// 
        /// Replaced by GroupGetRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGetRequest22Async instead.")]
        public static async Task<GroupGetResponse22> GroupGetRequest22(this OcipClientBase client, GroupGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGetResponse22;
        }

        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse22 or an ErrorResponse.
        /// 
        /// Replaced by GroupGetRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<GroupGetResponse22> GroupGetRequest22Async(this OcipClientBase client, GroupGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGetResponse22;
        }
        /// <summary>
        /// Get the Integrated IMP service attributes for the group.
        /// The response is either GroupIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupIntegratedIMPGetRequest21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupIntegratedIMPGetRequestAsync instead.")]
        public static async Task<GroupIntegratedIMPGetResponse> GroupIntegratedIMPGetRequest(this OcipClientBase client, GroupIntegratedIMPGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupIntegratedIMPGetResponse;
        }

        /// <summary>
        /// Get the Integrated IMP service attributes for the group.
        /// The response is either GroupIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupIntegratedIMPGetRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<GroupIntegratedIMPGetResponse> GroupIntegratedIMPGetRequestAsync(this OcipClientBase client, GroupIntegratedIMPGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupIntegratedIMPGetResponse;
        }
        /// <summary>
        /// Get the group's intercept group service settings.
        /// The response is either a GroupInterceptGroupGetResponse16sp1 or an ErrorResponse.
        /// 
        /// Replaced by: GroupInterceptGroupGetRequest21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupInterceptGroupGetRequest16sp1Async instead.")]
        public static async Task<GroupInterceptGroupGetResponse16sp1> GroupInterceptGroupGetRequest16sp1(this OcipClientBase client, GroupInterceptGroupGetRequest16sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupInterceptGroupGetResponse16sp1;
        }

        /// <summary>
        /// Get the group's intercept group service settings.
        /// The response is either a GroupInterceptGroupGetResponse16sp1 or an ErrorResponse.
        /// 
        /// Replaced by: GroupInterceptGroupGetRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<GroupInterceptGroupGetResponse16sp1> GroupInterceptGroupGetRequest16sp1Async(this OcipClientBase client, GroupInterceptGroupGetRequest16sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupInterceptGroupGetResponse16sp1;
        }
        /// <summary>
        /// Modify the group's intercept group service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupInterceptGroupModifyResponse21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupInterceptGroupModifyRequest16Async instead.")]
        public static async Task<SuccessResponse> GroupInterceptGroupModifyRequest16(this OcipClientBase client, GroupInterceptGroupModifyRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's intercept group service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupInterceptGroupModifyResponse21sp1 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupInterceptGroupModifyRequest16Async(this OcipClientBase client, GroupInterceptGroupModifyRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupMusicOnHoldAddInstanceRequest22.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldAddInstanceRequest21Async instead.")]
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest21(this OcipClientBase client, GroupMusicOnHoldAddInstanceRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupMusicOnHoldAddInstanceRequest22.
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest21Async(this OcipClientBase client, GroupMusicOnHoldAddInstanceRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse21 or ErrorResponse.
        /// Replaced by GroupMusicOnHoldGetInstanceRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetInstanceRequest21Async instead.")]
        public static async Task<GroupMusicOnHoldGetInstanceResponse21> GroupMusicOnHoldGetInstanceRequest21(this OcipClientBase client, GroupMusicOnHoldGetInstanceRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse21;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse21 or ErrorResponse.
        /// Replaced by GroupMusicOnHoldGetInstanceRequest22
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse21> GroupMusicOnHoldGetInstanceRequest21Async(this OcipClientBase client, GroupMusicOnHoldGetInstanceRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse21;
        }
        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse22 or ErrorResponse.
        /// 
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest22V2 in AS mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetInstanceRequest22Async instead.")]
        public static async Task<GroupMusicOnHoldGetInstanceResponse22> GroupMusicOnHoldGetInstanceRequest22(this OcipClientBase client, GroupMusicOnHoldGetInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse22;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse22 or ErrorResponse.
        /// 
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest22V2 in AS mode
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse22> GroupMusicOnHoldGetInstanceRequest22Async(this OcipClientBase client, GroupMusicOnHoldGetInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse22;
        }
        /// <summary>
        /// Modify data for a group or department Music On Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldModifyInstanceRequest21Async instead.")]
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest21(this OcipClientBase client, GroupMusicOnHoldModifyInstanceRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify data for a group or department Music On Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest21Async(this OcipClientBase client, GroupMusicOnHoldModifyInstanceRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the group's password rules setting that is applicable to
        /// users within the group.
        /// The response is either GroupPasswordRulesGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: GroupPasswordRulesGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPasswordRulesGetRequest16Async instead.")]
        public static async Task<GroupPasswordRulesGetResponse16> GroupPasswordRulesGetRequest16(this OcipClientBase client, GroupPasswordRulesGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPasswordRulesGetResponse16;
        }

        /// <summary>
        /// Requests the group's password rules setting that is applicable to
        /// users within the group.
        /// The response is either GroupPasswordRulesGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: GroupPasswordRulesGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<GroupPasswordRulesGetResponse16> GroupPasswordRulesGetRequest16Async(this OcipClientBase client, GroupPasswordRulesGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPasswordRulesGetResponse16;
        }
        /// <summary>
        /// Add a Route Point instance to a group.
        /// The Route Point is a Call Center queue that performs the same function but
        /// allows an external system to perform the distribution of calls instead of making
        /// those decisions itself.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replace by GroupRoutePointAddInstanceRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointAddInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointAddInstanceRequest(this OcipClientBase client, GroupRoutePointAddInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Route Point instance to a group.
        /// The Route Point is a Call Center queue that performs the same function but
        /// allows an external system to perform the distribution of calls instead of making
        /// those decisions itself.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replace by GroupRoutePointAddInstanceRequest22
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointAddInstanceRequestAsync(this OcipClientBase client, GroupRoutePointAddInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all the information of a Route Point instance.
        /// The response is either GroupRoutePointGetInstanceResponse19sp1 or ErrorResponse.
        /// Replace by GroupRoutePointGetInstanceRequest22.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetInstanceRequest19sp1Async instead.")]
        public static async Task<GroupRoutePointGetInstanceResponse19sp1> GroupRoutePointGetInstanceRequest19sp1(this OcipClientBase client, GroupRoutePointGetInstanceRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a Route Point instance.
        /// The response is either GroupRoutePointGetInstanceResponse19sp1 or ErrorResponse.
        /// Replace by GroupRoutePointGetInstanceRequest22.
        /// </summary>
        public static async Task<GroupRoutePointGetInstanceResponse19sp1> GroupRoutePointGetInstanceRequest19sp1Async(this OcipClientBase client, GroupRoutePointGetInstanceRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetInstanceResponse19sp1;
        }
        /// <summary>
        /// Request to modify a Route Point instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupRoutePointModifyInstanceRequest22.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyInstanceRequest(this OcipClientBase client, GroupRoutePointModifyInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Route Point instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupRoutePointModifyInstanceRequest22.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyInstanceRequestAsync(this OcipClientBase client, GroupRoutePointModifyInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Returns a list of all Public User Identities and associated data in a group.
        /// The response is either a GroupShInterfaceGetUserListResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupShInterfaceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupShInterfaceGetUserListRequestAsync instead.")]
        public static async Task<GroupShInterfaceGetUserListResponse> GroupShInterfaceGetUserListRequest(this OcipClientBase client, GroupShInterfaceGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupShInterfaceGetUserListResponse;
        }

        /// <summary>
        /// Returns a list of all Public User Identities and associated data in a group.
        /// The response is either a GroupShInterfaceGetUserListResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupShInterfaceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<GroupShInterfaceGetUserListResponse> GroupShInterfaceGetUserListRequestAsync(this OcipClientBase client, GroupShInterfaceGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupShInterfaceGetUserListResponse;
        }
        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupGetVoicePortalRequest19sp1Async instead.")]
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse19sp1> GroupVoiceMessagingGroupGetVoicePortalRequest19sp1(this OcipClientBase client, GroupVoiceMessagingGroupGetVoicePortalRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalResponse19sp1;
        }

        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse19sp1> GroupVoiceMessagingGroupGetVoicePortalRequest19sp1Async(this OcipClientBase client, GroupVoiceMessagingGroupGetVoicePortalRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalResponse19sp1;
        }
        /// <summary>
        /// Request to get all the information of a VoiceXML instance.
        /// The response is either GroupVoiceXmlGetInstanceResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceXmlGetInstanceRequest22 in AS mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceXmlGetInstanceRequest19sp1Async instead.")]
        public static async Task<GroupVoiceXmlGetInstanceResponse19sp1> GroupVoiceXmlGetInstanceRequest19sp1(this OcipClientBase client, GroupVoiceXmlGetInstanceRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceXmlGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a VoiceXML instance.
        /// The response is either GroupVoiceXmlGetInstanceResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceXmlGetInstanceRequest22 in AS mode
        /// </summary>
        public static async Task<GroupVoiceXmlGetInstanceResponse19sp1> GroupVoiceXmlGetInstanceRequest19sp1Async(this OcipClientBase client, GroupVoiceXmlGetInstanceRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceXmlGetInstanceResponse19sp1;
        }
        /// <summary>
        /// LoginRequest14sp4 is 2nd stage of the 2 stage OCI login process.
        /// The signedPassword is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse14sp4 or ErrorResponse
        /// 
        /// Replaced by: LoginRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use LoginRequest14sp4Async instead.")]
        public static async Task<LoginResponse14sp4> LoginRequest14sp4(this OcipClientBase client, LoginRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as LoginResponse14sp4;
        }

        /// <summary>
        /// LoginRequest14sp4 is 2nd stage of the 2 stage OCI login process.
        /// The signedPassword is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse14sp4 or ErrorResponse
        /// 
        /// Replaced by: LoginRequest22 in AS data mode.
        /// </summary>
        public static async Task<LoginResponse14sp4> LoginRequest14sp4Async(this OcipClientBase client, LoginRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as LoginResponse14sp4;
        }
        /// <summary>
        /// LoginRequest21sp1 is 2nd stage of the 2 stage OCI login process.
        /// The signedPassword is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse21sp1 or ErrorResponse
        /// Replaced by LoginRequest22V3 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use LoginRequest21sp1Async instead.")]
        public static async Task<LoginResponse21sp1> LoginRequest21sp1(this OcipClientBase client, LoginRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as LoginResponse21sp1;
        }

        /// <summary>
        /// LoginRequest21sp1 is 2nd stage of the 2 stage OCI login process.
        /// The signedPassword is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse21sp1 or ErrorResponse
        /// Replaced by LoginRequest22V3 in AS data mode.
        /// </summary>
        public static async Task<LoginResponse21sp1> LoginRequest21sp1Async(this OcipClientBase client, LoginRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as LoginResponse21sp1;
        }
        /// <summary>
        /// Request to login to OCI.
        /// password is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse22 or ErrorResponse
        /// 
        /// Replaced by LoginRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use LoginRequest22Async instead.")]
        public static async Task<LoginResponse22> LoginRequest22(this OcipClientBase client, LoginRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as LoginResponse22;
        }

        /// <summary>
        /// Request to login to OCI.
        /// password is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse22 or ErrorResponse
        /// 
        /// Replaced by LoginRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<LoginResponse22> LoginRequest22Async(this OcipClientBase client, LoginRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as LoginResponse22;
        }
        /// <summary>
        /// Request to login to OCI.
        /// password is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse22V2 or ErrorResponse
        /// 
        /// Replaced by LoginRequest22V3 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use LoginRequest22V2Async instead.")]
        public static async Task<LoginResponse22V2> LoginRequest22V2(this OcipClientBase client, LoginRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as LoginResponse22V2;
        }

        /// <summary>
        /// Request to login to OCI.
        /// password is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse22V2 or ErrorResponse
        /// 
        /// Replaced by LoginRequest22V3 in AS data mode.
        /// </summary>
        public static async Task<LoginResponse22V2> LoginRequest22V2Async(this OcipClientBase client, LoginRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as LoginResponse22V2;
        }
        /// <summary>
        /// Get the Integrated IMP service attributes for the reseller.
        /// The response is either ResellerIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by: ResellerIntegratedIMPGetRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerIntegratedIMPGetRequestAsync instead.")]
        public static async Task<ResellerIntegratedIMPGetResponse> ResellerIntegratedIMPGetRequest(this OcipClientBase client, ResellerIntegratedIMPGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerIntegratedIMPGetResponse;
        }

        /// <summary>
        /// Get the Integrated IMP service attributes for the reseller.
        /// The response is either ResellerIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by: ResellerIntegratedIMPGetRequest22 in AS data mode
        /// </summary>
        public static async Task<ResellerIntegratedIMPGetResponse> ResellerIntegratedIMPGetRequestAsync(this OcipClientBase client, ResellerIntegratedIMPGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerIntegratedIMPGetResponse;
        }
        /// <summary>
        /// Requests the list of users on a specified device.
        /// The response is either ServiceProviderAccessDeviceGetUserListResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// 
        /// Replaced by: ServiceProviderAccessDeviceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetUserListRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceGetUserListResponse> ServiceProviderAccessDeviceGetUserListRequest(this OcipClientBase client, ServiceProviderAccessDeviceGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetUserListResponse;
        }

        /// <summary>
        /// Requests the list of users on a specified device.
        /// The response is either ServiceProviderAccessDeviceGetUserListResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// 
        /// Replaced by: ServiceProviderAccessDeviceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetUserListResponse> ServiceProviderAccessDeviceGetUserListRequestAsync(this OcipClientBase client, ServiceProviderAccessDeviceGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetUserListResponse;
        }
        /// <summary>
        /// Get a service provider administrators profile.
        /// The response is either a ServiceProviderAdminGetResponse14 or an ErrorResponse.
        /// Replaced by ServiceProviderAdminGetRequest21sp1.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminGetRequest14Async instead.")]
        public static async Task<ServiceProviderAdminGetResponse14> ServiceProviderAdminGetRequest14(this OcipClientBase client, ServiceProviderAdminGetRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAdminGetResponse14;
        }

        /// <summary>
        /// Get a service provider administrators profile.
        /// The response is either a ServiceProviderAdminGetResponse14 or an ErrorResponse.
        /// Replaced by ServiceProviderAdminGetRequest21sp1.
        /// </summary>
        public static async Task<ServiceProviderAdminGetResponse14> ServiceProviderAdminGetRequest14Async(this OcipClientBase client, ServiceProviderAdminGetRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAdminGetResponse14;
        }
        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse21sp2 or an ErrorResponse.
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCallProcessingGetPolicyRequest21sp2Async instead.")]
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse21sp2> ServiceProviderCallProcessingGetPolicyRequest21sp2(this OcipClientBase client, ServiceProviderCallProcessingGetPolicyRequest21sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCallProcessingGetPolicyResponse21sp2;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse21sp2 or an ErrorResponse.
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest22 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse21sp2> ServiceProviderCallProcessingGetPolicyRequest21sp2Async(this OcipClientBase client, ServiceProviderCallProcessingGetPolicyRequest21sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCallProcessingGetPolicyResponse21sp2;
        }
        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse22 or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCallProcessingGetPolicyRequest22Async instead.")]
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse22> ServiceProviderCallProcessingGetPolicyRequest22(this OcipClientBase client, ServiceProviderCallProcessingGetPolicyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCallProcessingGetPolicyResponse22;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse22 or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse22> ServiceProviderCallProcessingGetPolicyRequest22Async(this OcipClientBase client, ServiceProviderCallProcessingGetPolicyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCallProcessingGetPolicyResponse22;
        }
        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse21 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderIntegratedIMPGetRequest21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderIntegratedIMPGetRequest21Async instead.")]
        public static async Task<ServiceProviderIntegratedIMPGetResponse21> ServiceProviderIntegratedIMPGetRequest21(this OcipClientBase client, ServiceProviderIntegratedIMPGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderIntegratedIMPGetResponse21;
        }

        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse21 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderIntegratedIMPGetRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderIntegratedIMPGetResponse21> ServiceProviderIntegratedIMPGetRequest21Async(this OcipClientBase client, ServiceProviderIntegratedIMPGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderIntegratedIMPGetResponse21;
        }
        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse21sp1 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderIntegratedIMPGetRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderIntegratedIMPGetRequest21sp1Async instead.")]
        public static async Task<ServiceProviderIntegratedIMPGetResponse21sp1> ServiceProviderIntegratedIMPGetRequest21sp1(this OcipClientBase client, ServiceProviderIntegratedIMPGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderIntegratedIMPGetResponse21sp1;
        }

        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse21sp1 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderIntegratedIMPGetRequest22 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderIntegratedIMPGetResponse21sp1> ServiceProviderIntegratedIMPGetRequest21sp1Async(this OcipClientBase client, ServiceProviderIntegratedIMPGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderIntegratedIMPGetResponse21sp1;
        }
        /// <summary>
        /// Requests the service provider's password rules setting applicable to
        /// Administrators (Group and Department) and Users.
        /// The response is either ServiceProviderPasswordRulesGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderPasswordRulesGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPasswordRulesGetRequest16Async instead.")]
        public static async Task<ServiceProviderPasswordRulesGetResponse16> ServiceProviderPasswordRulesGetRequest16(this OcipClientBase client, ServiceProviderPasswordRulesGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderPasswordRulesGetResponse16;
        }

        /// <summary>
        /// Requests the service provider's password rules setting applicable to
        /// Administrators (Group and Department) and Users.
        /// The response is either ServiceProviderPasswordRulesGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderPasswordRulesGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<ServiceProviderPasswordRulesGetResponse16> ServiceProviderPasswordRulesGetRequest16Async(this OcipClientBase client, ServiceProviderPasswordRulesGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderPasswordRulesGetResponse16;
        }
        /// <summary>
        /// Requests the users associated with a specified system access device.
        /// The response is either SystemAccessDeviceGetUserListResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// 
        /// Replaced by: SystemAccessDeviceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetUserListRequestAsync instead.")]
        public static async Task<SystemAccessDeviceGetUserListResponse> SystemAccessDeviceGetUserListRequest(this OcipClientBase client, SystemAccessDeviceGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetUserListResponse;
        }

        /// <summary>
        /// Requests the users associated with a specified system access device.
        /// The response is either SystemAccessDeviceGetUserListResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// 
        /// Replaced by: SystemAccessDeviceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<SystemAccessDeviceGetUserListResponse> SystemAccessDeviceGetUserListRequestAsync(this OcipClientBase client, SystemAccessDeviceGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetUserListResponse;
        }
        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse21sp2 or an
        /// ErrorResponse.
        /// Replaced by: SystemCallProcessingGetPolicyRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingGetPolicyRequest21sp2Async instead.")]
        public static async Task<SystemCallProcessingGetPolicyResponse21sp2> SystemCallProcessingGetPolicyRequest21sp2(this OcipClientBase client, SystemCallProcessingGetPolicyRequest21sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse21sp2;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse21sp2 or an
        /// ErrorResponse.
        /// Replaced by: SystemCallProcessingGetPolicyRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse21sp2> SystemCallProcessingGetPolicyRequest21sp2Async(this OcipClientBase client, SystemCallProcessingGetPolicyRequest21sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse21sp2;
        }
        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse22 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingGetPolicyRequest22Async instead.")]
        public static async Task<SystemCallProcessingGetPolicyResponse22> SystemCallProcessingGetPolicyRequest22(this OcipClientBase client, SystemCallProcessingGetPolicyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse22;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse22 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse22> SystemCallProcessingGetPolicyRequest22Async(this OcipClientBase client, SystemCallProcessingGetPolicyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse22;
        }
        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse22V2 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest23 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingGetPolicyRequest22V2Async instead.")]
        public static async Task<SystemCallProcessingGetPolicyResponse22V2> SystemCallProcessingGetPolicyRequest22V2(this OcipClientBase client, SystemCallProcessingGetPolicyRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse22V2;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse22V2 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest23 in AS data mode.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse22V2> SystemCallProcessingGetPolicyRequest22V2Async(this OcipClientBase client, SystemCallProcessingGetPolicyRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse22V2;
        }
        /// <summary>
        /// Request the system level data associated with Communication Barring.
        /// The response is either a SystemCommunicationBarringGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringGetRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringGetRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringGetResponse> SystemCommunicationBarringGetRequest(this OcipClientBase client, SystemCommunicationBarringGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Communication Barring.
        /// The response is either a SystemCommunicationBarringGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringGetRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<SystemCommunicationBarringGetResponse> SystemCommunicationBarringGetRequestAsync(this OcipClientBase client, SystemCommunicationBarringGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringGetResponse;
        }
        /// <summary>
        /// Request to get the list of custom configuration tag sets managed by the Device Management System.
        /// The response is either SystemDeviceManagementTagSetGetListResponse or ErrorResponse.
        /// 
        /// Replaced by SystemDeviceManagementTagSetGetListRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagSetGetListRequestAsync instead.")]
        public static async Task<SystemDeviceManagementTagSetGetListResponse> SystemDeviceManagementTagSetGetListRequest(this OcipClientBase client, SystemDeviceManagementTagSetGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementTagSetGetListResponse;
        }

        /// <summary>
        /// Request to get the list of custom configuration tag sets managed by the Device Management System.
        /// The response is either SystemDeviceManagementTagSetGetListResponse or ErrorResponse.
        /// 
        /// Replaced by SystemDeviceManagementTagSetGetListRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemDeviceManagementTagSetGetListResponse> SystemDeviceManagementTagSetGetListRequestAsync(this OcipClientBase client, SystemDeviceManagementTagSetGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementTagSetGetListResponse;
        }
        /// <summary>
        /// Requests a list of non-obsolete Identity/device profile types defined in the system. It is possible
        /// to get either all conference device types or all non-conferernce types. This command is similar
        /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
        /// but gets both SIP and MGCP types.
        /// The response is either SystemDeviceTypeGetAvailableListResponse19 or ErrorResponse.
        /// Replaced by SystemDeviceTypeGetAvailableListRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeGetAvailableListRequest19Async instead.")]
        public static async Task<SystemDeviceTypeGetAvailableListResponse19> SystemDeviceTypeGetAvailableListRequest19(this OcipClientBase client, SystemDeviceTypeGetAvailableListRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeGetAvailableListResponse19;
        }

        /// <summary>
        /// Requests a list of non-obsolete Identity/device profile types defined in the system. It is possible
        /// to get either all conference device types or all non-conferernce types. This command is similar
        /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
        /// but gets both SIP and MGCP types.
        /// The response is either SystemDeviceTypeGetAvailableListResponse19 or ErrorResponse.
        /// Replaced by SystemDeviceTypeGetAvailableListRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemDeviceTypeGetAvailableListResponse19> SystemDeviceTypeGetAvailableListRequest19Async(this OcipClientBase client, SystemDeviceTypeGetAvailableListRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeGetAvailableListResponse19;
        }
        /// <summary>
        /// Requests the list of all system-level domain names.
        /// The response is either SystemDomainGetListResponse or ErrorResponse.
        /// 
        /// Replaced by SystemDomainGetListRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainGetListRequestAsync instead.")]
        public static async Task<SystemDomainGetListResponse> SystemDomainGetListRequest(this OcipClientBase client, SystemDomainGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDomainGetListResponse;
        }

        /// <summary>
        /// Requests the list of all system-level domain names.
        /// The response is either SystemDomainGetListResponse or ErrorResponse.
        /// 
        /// Replaced by SystemDomainGetListRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemDomainGetListResponse> SystemDomainGetListRequestAsync(this OcipClientBase client, SystemDomainGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDomainGetListResponse;
        }
        /// <summary>
        /// Add an application to the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemOCICallControlApplicationAddRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationAddRequest17Async instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddRequest17(this OcipClientBase client, SystemOCICallControlApplicationAddRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an application to the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemOCICallControlApplicationAddRequest22
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddRequest17Async(this OcipClientBase client, SystemOCICallControlApplicationAddRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the system's password rules setting applicable to
        /// System administrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
        /// The response is either SystemPasswordRulesGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: SystemPasswordRulesGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPasswordRulesGetRequest16Async instead.")]
        public static async Task<SystemPasswordRulesGetResponse16> SystemPasswordRulesGetRequest16(this OcipClientBase client, SystemPasswordRulesGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPasswordRulesGetResponse16;
        }

        /// <summary>
        /// Requests the system's password rules setting applicable to
        /// System administrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
        /// The response is either SystemPasswordRulesGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: SystemPasswordRulesGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemPasswordRulesGetResponse16> SystemPasswordRulesGetRequest16Async(this OcipClientBase client, SystemPasswordRulesGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPasswordRulesGetResponse16;
        }
        /// <summary>
        /// Request to get the system's provisioning validation attributes.
        /// The response is either a SystemProvisioningValidationGetResponse14sp2 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemProvisioningValidationGetRequest14sp2Async instead.")]
        public static async Task<SystemProvisioningValidationGetResponse14sp2> SystemProvisioningValidationGetRequest14sp2(this OcipClientBase client, SystemProvisioningValidationGetRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemProvisioningValidationGetResponse14sp2;
        }

        /// <summary>
        /// Request to get the system's provisioning validation attributes.
        /// The response is either a SystemProvisioningValidationGetResponse14sp2 or ErrorResponse.
        /// </summary>
        public static async Task<SystemProvisioningValidationGetResponse14sp2> SystemProvisioningValidationGetRequest14sp2Async(this OcipClientBase client, SystemProvisioningValidationGetRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemProvisioningValidationGetResponse14sp2;
        }
        /// <summary>
        /// Request the system level data associated with session audit.
        /// The response is either a SystemSessionAuditGetResponse17sp3 or
        /// an ErrorResponse.
        /// 
        /// Replaced by: SystemSessionAuditGetRequest23 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSessionAuditGetRequest17sp3Async instead.")]
        public static async Task<SystemSessionAuditGetResponse17sp3> SystemSessionAuditGetRequest17sp3(this OcipClientBase client, SystemSessionAuditGetRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSessionAuditGetResponse17sp3;
        }

        /// <summary>
        /// Request the system level data associated with session audit.
        /// The response is either a SystemSessionAuditGetResponse17sp3 or
        /// an ErrorResponse.
        /// 
        /// Replaced by: SystemSessionAuditGetRequest23 in AS data mode.
        /// </summary>
        public static async Task<SystemSessionAuditGetResponse17sp3> SystemSessionAuditGetRequest17sp3Async(this OcipClientBase client, SystemSessionAuditGetRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSessionAuditGetResponse17sp3;
        }
        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMPPGetRequest21Async instead.")]
        public static async Task<SystemSMPPGetResponse21> SystemSMPPGetRequest21(this OcipClientBase client, SystemSMPPGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSMPPGetResponse21;
        }

        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSMPPGetResponse21> SystemSMPPGetRequest21Async(this OcipClientBase client, SystemSMPPGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSMPPGetResponse21;
        }
        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest22 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequestAsync(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest22V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceAddRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest22(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest22V2 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest22Async(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest23 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceAddRequest22V2Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest22V2(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceAddRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest23 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest22V2Async(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceAddRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest22 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequestAsync(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceDeleteRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest22(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceDeleteRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest22Async(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceDeleteRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest23 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest23 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2Async(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse
        /// or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceGetListRequestAsync instead.")]
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse> SystemTreatmentMappingCallBlockingServiceGetListRequest(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse
        /// or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse> SystemTreatmentMappingCallBlockingServiceGetListRequestAsync(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse;
        }
        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse22
        /// or an ErrorResponse.
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest23
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceGetListRequest22Async instead.")]
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse22> SystemTreatmentMappingCallBlockingServiceGetListRequest22(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse22;
        }

        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse22
        /// or an ErrorResponse.
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest23
        /// </summary>
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse22> SystemTreatmentMappingCallBlockingServiceGetListRequest22Async(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse22;
        }
        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest22 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequestAsync(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest22V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest22(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest22V2 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest22Async(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest23 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceModifyRequest22V2Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest22V2(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceModifyRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest23 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest22V2Async(this OcipClientBase client, SystemTreatmentMappingCallBlockingServiceModifyRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVoiceMessagingGroupGetRequest21Async instead.")]
        public static async Task<SystemVoiceMessagingGroupGetResponse21> SystemVoiceMessagingGroupGetRequest21(this OcipClientBase client, SystemVoiceMessagingGroupGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse21;
        }

        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest22 in AS data mode
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetResponse21> SystemVoiceMessagingGroupGetRequest21Async(this OcipClientBase client, SystemVoiceMessagingGroupGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse21;
        }
        /// <summary>
        /// The response is SystemVoiceMessagingGroupGetResponse22.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest22V2.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVoiceMessagingGroupGetRequest22Async instead.")]
        public static async Task<SystemVoiceMessagingGroupGetResponse22> SystemVoiceMessagingGroupGetRequest22(this OcipClientBase client, SystemVoiceMessagingGroupGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse22;
        }

        /// <summary>
        /// The response is SystemVoiceMessagingGroupGetResponse22.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest22V2.
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetResponse22> SystemVoiceMessagingGroupGetRequest22Async(this OcipClientBase client, SystemVoiceMessagingGroupGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse22;
        }
        /// <summary>
        /// Request to add a user.
        /// The domain is required in the userId.
        /// The password is not required if external authentication is enabled.
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// nameDialingName
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements can only be used by a system administrator:.
        /// allowVideo
        /// alternateUserId
        /// The following elements can only be used by a provisioning administrator:.
        /// alternateUserId
        /// 
        /// Replaced by: UserAddRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAddRequest21Async instead.")]
        public static async Task<SuccessResponse> UserAddRequest21(this OcipClientBase client, UserAddRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a user.
        /// The domain is required in the userId.
        /// The password is not required if external authentication is enabled.
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// nameDialingName
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements can only be used by a system administrator:.
        /// allowVideo
        /// alternateUserId
        /// The following elements can only be used by a provisioning administrator:.
        /// alternateUserId
        /// 
        /// Replaced by: UserAddRequest22 in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> UserAddRequest21Async(this OcipClientBase client, UserAddRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of all the available BroadWorks Anywhere portal instances for a specific user
        /// The response is either UserBroadWorksAnywhereGetAvailablePortalListResponse or ErrorResponse.
        /// Replaced by UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereGetAvailablePortalListRequestAsync instead.")]
        public static async Task<UserBroadWorksAnywhereGetAvailablePortalListResponse> UserBroadWorksAnywhereGetAvailablePortalListRequest(this OcipClientBase client, UserBroadWorksAnywhereGetAvailablePortalListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksAnywhereGetAvailablePortalListResponse;
        }

        /// <summary>
        /// Get a list of all the available BroadWorks Anywhere portal instances for a specific user
        /// The response is either UserBroadWorksAnywhereGetAvailablePortalListResponse or ErrorResponse.
        /// Replaced by UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1
        /// </summary>
        public static async Task<UserBroadWorksAnywhereGetAvailablePortalListResponse> UserBroadWorksAnywhereGetAvailablePortalListRequestAsync(this OcipClientBase client, UserBroadWorksAnywhereGetAvailablePortalListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksAnywhereGetAvailablePortalListResponse;
        }
        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse21sp2 or an
        /// ErrorResponse.
        /// Replaced by: UserCallProcessingGetPolicyRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallProcessingGetPolicyRequest21sp2Async instead.")]
        public static async Task<UserCallProcessingGetPolicyResponse21sp2> UserCallProcessingGetPolicyRequest21sp2(this OcipClientBase client, UserCallProcessingGetPolicyRequest21sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallProcessingGetPolicyResponse21sp2;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse21sp2 or an
        /// ErrorResponse.
        /// Replaced by: UserCallProcessingGetPolicyRequest22 in AS data mode
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse21sp2> UserCallProcessingGetPolicyRequest21sp2Async(this OcipClientBase client, UserCallProcessingGetPolicyRequest21sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallProcessingGetPolicyResponse21sp2;
        }
        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse22 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: UserCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallProcessingGetPolicyRequest22Async instead.")]
        public static async Task<UserCallProcessingGetPolicyResponse22> UserCallProcessingGetPolicyRequest22(this OcipClientBase client, UserCallProcessingGetPolicyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallProcessingGetPolicyResponse22;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse22 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: UserCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse22> UserCallProcessingGetPolicyRequest22Async(this OcipClientBase client, UserCallProcessingGetPolicyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallProcessingGetPolicyResponse22;
        }
        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse21 or an ErrorResponse.
        /// The following elements are only used in AS data mode and not returned in XS data mode:
        /// callAuthorizationCodeFilter
        /// 
        /// Replaced by: UserEnhancedCallLogsGetListRequest21Sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserEnhancedCallLogsGetListRequest21Async instead.")]
        public static async Task<UserEnhancedCallLogsGetListResponse21> UserEnhancedCallLogsGetListRequest21(this OcipClientBase client, UserEnhancedCallLogsGetListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse21;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse21 or an ErrorResponse.
        /// The following elements are only used in AS data mode and not returned in XS data mode:
        /// callAuthorizationCodeFilter
        /// 
        /// Replaced by: UserEnhancedCallLogsGetListRequest21Sp1 in AS data mode
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse21> UserEnhancedCallLogsGetListRequest21Async(this OcipClientBase client, UserEnhancedCallLogsGetListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse21;
        }
        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse21sp1 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// 
        /// Replaced by: UserEnhancedCallLogsGetListRequest21Sp1V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserEnhancedCallLogsGetListRequest21sp1Async instead.")]
        public static async Task<UserEnhancedCallLogsGetListResponse21sp1> UserEnhancedCallLogsGetListRequest21sp1(this OcipClientBase client, UserEnhancedCallLogsGetListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse21sp1;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse21sp1 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// 
        /// Replaced by: UserEnhancedCallLogsGetListRequest21Sp1V2 in AS data mode
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse21sp1> UserEnhancedCallLogsGetListRequest21sp1Async(this OcipClientBase client, UserEnhancedCallLogsGetListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse21sp1;
        }
        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse21sp1V2 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// </summary>
        [Obsolete("This method is deprecated. Use UserEnhancedCallLogsGetListRequest21sp1V2Async instead.")]
        public static async Task<UserEnhancedCallLogsGetListResponse21sp1V2> UserEnhancedCallLogsGetListRequest21sp1V2(this OcipClientBase client, UserEnhancedCallLogsGetListRequest21sp1V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse21sp1V2;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse21sp1V2 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse21sp1V2> UserEnhancedCallLogsGetListRequest21sp1V2Async(this OcipClientBase client, UserEnhancedCallLogsGetListRequest21sp1V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse21sp1V2;
        }
        /// <summary>
        /// Request to get the user information.  The response is either UserGetResponse22V4 or ErrorResponse.
        /// 
        /// Replaced by: UserGetResponse22V5 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetRequest22V4Async instead.")]
        public static async Task<UserGetResponse22V4> UserGetRequest22V4(this OcipClientBase client, UserGetRequest22V4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetResponse22V4;
        }

        /// <summary>
        /// Request to get the user information.  The response is either UserGetResponse22V4 or ErrorResponse.
        /// 
        /// Replaced by: UserGetResponse22V5 in AS data mode
        /// </summary>
        public static async Task<UserGetResponse22V4> UserGetRequest22V4Async(this OcipClientBase client, UserGetRequest22V4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetResponse22V4;
        }
        /// <summary>
        /// Get the Integrated IMP specific service attribute for the user.
        /// The response is either UserIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by: UserIntegratedIMPGetRequest21sp1
        /// </summary>
        [Obsolete("This method is deprecated. Use UserIntegratedIMPGetRequestAsync instead.")]
        public static async Task<UserIntegratedIMPGetResponse> UserIntegratedIMPGetRequest(this OcipClientBase client, UserIntegratedIMPGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserIntegratedIMPGetResponse;
        }

        /// <summary>
        /// Get the Integrated IMP specific service attribute for the user.
        /// The response is either UserIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by: UserIntegratedIMPGetRequest21sp1
        /// </summary>
        public static async Task<UserIntegratedIMPGetResponse> UserIntegratedIMPGetRequestAsync(this OcipClientBase client, UserIntegratedIMPGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserIntegratedIMPGetResponse;
        }
        /// <summary>
        /// Get the user's intercept user service settings.
        /// The response is either a UserInterceptUserGetResponse16sp1 or an ErrorResponse.
        /// 
        /// Replaced by: UserInterceptUserGetRequest21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserInterceptUserGetRequest16sp1Async instead.")]
        public static async Task<UserInterceptUserGetResponse16sp1> UserInterceptUserGetRequest16sp1(this OcipClientBase client, UserInterceptUserGetRequest16sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserInterceptUserGetResponse16sp1;
        }

        /// <summary>
        /// Get the user's intercept user service settings.
        /// The response is either a UserInterceptUserGetResponse16sp1 or an ErrorResponse.
        /// 
        /// Replaced by: UserInterceptUserGetRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<UserInterceptUserGetResponse16sp1> UserInterceptUserGetRequest16sp1Async(this OcipClientBase client, UserInterceptUserGetRequest16sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserInterceptUserGetResponse16sp1;
        }
        /// <summary>
        /// Modify the user's intercept user service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserInterceptUserModifyResponse21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserInterceptUserModifyRequest16Async instead.")]
        public static async Task<SuccessResponse> UserInterceptUserModifyRequest16(this OcipClientBase client, UserInterceptUserModifyRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's intercept user service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserInterceptUserModifyResponse21sp1 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> UserInterceptUserModifyRequest16Async(this OcipClientBase client, UserInterceptUserModifyRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a user.
        /// When oldPassword is specified, all password rule applies. If oldPassword in not specified,
        /// any password rule related to old password does not apply.
        /// The request will fail if officeZoneName or primaryZoneName is present but the Location-Based Calling Restrictions service is not assigned to the user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following data elements are only used in AS data mode:
        /// contact[2]-contact[5]
        /// nameDialingName
        /// alternateUserIdList
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The allowVideo element can only be used by a system administrator.
        /// The impId and impPassword are accepted when the Third-Party IMP service is assigned to the user;
        /// when Integrated IMP service is assigned to the user and active, only the impPassword is accepted;
        /// all other cases, the request fails if either field is changed.
        /// 
        /// Replaced by : UserAddRequest22 in AS mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserModifyRequest21Async instead.")]
        public static async Task<SuccessResponse> UserModifyRequest21(this OcipClientBase client, UserModifyRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a user.
        /// When oldPassword is specified, all password rule applies. If oldPassword in not specified,
        /// any password rule related to old password does not apply.
        /// The request will fail if officeZoneName or primaryZoneName is present but the Location-Based Calling Restrictions service is not assigned to the user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following data elements are only used in AS data mode:
        /// contact[2]-contact[5]
        /// nameDialingName
        /// alternateUserIdList
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The allowVideo element can only be used by a system administrator.
        /// The impId and impPassword are accepted when the Third-Party IMP service is assigned to the user;
        /// when Integrated IMP service is assigned to the user and active, only the impPassword is accepted;
        /// all other cases, the request fails if either field is changed.
        /// 
        /// Replaced by : UserAddRequest22 in AS mode
        /// </summary>
        public static async Task<SuccessResponse> UserModifyRequest21Async(this OcipClientBase client, UserModifyRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user's Shared Call Appearance service setting.
        /// The response is either a UserSharedCallAppearanceGetResponse16sp2 or an ErrorResponse.
        /// Replaced by: UserSharedCallAppearanceGetRequest21sp1.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSharedCallAppearanceGetRequest16sp2Async instead.")]
        public static async Task<UserSharedCallAppearanceGetResponse16sp2> UserSharedCallAppearanceGetRequest16sp2(this OcipClientBase client, UserSharedCallAppearanceGetRequest16sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSharedCallAppearanceGetResponse16sp2;
        }

        /// <summary>
        /// Get the user's Shared Call Appearance service setting.
        /// The response is either a UserSharedCallAppearanceGetResponse16sp2 or an ErrorResponse.
        /// Replaced by: UserSharedCallAppearanceGetRequest21sp1.
        /// </summary>
        public static async Task<UserSharedCallAppearanceGetResponse16sp2> UserSharedCallAppearanceGetRequest16sp2Async(this OcipClientBase client, UserSharedCallAppearanceGetRequest16sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSharedCallAppearanceGetResponse16sp2;
        }
        /// <summary>
        /// Returns the Sh non-transparent data stored against a Public User Identity (a SIP URI
        /// or TEL URI).
        /// The response is either a UserShInterfaceGetPublicIdDataResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserShInterfaceGetPublicIdDataRequest21sp1.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserShInterfaceGetPublicIdDataRequestAsync instead.")]
        public static async Task<UserShInterfaceGetPublicIdDataResponse> UserShInterfaceGetPublicIdDataRequest(this OcipClientBase client, UserShInterfaceGetPublicIdDataRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserShInterfaceGetPublicIdDataResponse;
        }

        /// <summary>
        /// Returns the Sh non-transparent data stored against a Public User Identity (a SIP URI
        /// or TEL URI).
        /// The response is either a UserShInterfaceGetPublicIdDataResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserShInterfaceGetPublicIdDataRequest21sp1.
        /// </summary>
        public static async Task<UserShInterfaceGetPublicIdDataResponse> UserShInterfaceGetPublicIdDataRequestAsync(this OcipClientBase client, UserShInterfaceGetPublicIdDataRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserShInterfaceGetPublicIdDataResponse;
        }
        /// <summary>
        /// Returns the Sh non-transparent data stored against a userId.
        /// The response is either a UserShInterfaceGetUserIdDataResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserShInterfaceGetUserIdDataRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserShInterfaceGetUserIdDataRequestAsync instead.")]
        public static async Task<UserShInterfaceGetUserIdDataResponse> UserShInterfaceGetUserIdDataRequest(this OcipClientBase client, UserShInterfaceGetUserIdDataRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserShInterfaceGetUserIdDataResponse;
        }

        /// <summary>
        /// Returns the Sh non-transparent data stored against a userId.
        /// The response is either a UserShInterfaceGetUserIdDataResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserShInterfaceGetUserIdDataRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<UserShInterfaceGetUserIdDataResponse> UserShInterfaceGetUserIdDataRequestAsync(this OcipClientBase client, UserShInterfaceGetUserIdDataRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserShInterfaceGetUserIdDataResponse;
        }

    }
}
