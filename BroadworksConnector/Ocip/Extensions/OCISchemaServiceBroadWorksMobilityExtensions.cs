using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceBroadWorksMobilityExtensions
    {

        /// <summary>
        /// Request a summary table of all Mobile Subscriber Directory Numbers in an enterprise.
        /// The response is either EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse> EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListRequest(this OcipClient client, EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListRequest request)
        {
            return await client.Call(request) as EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse;
        }

        /// <summary>
        /// Request a summary table of all Mobile Subscriber Directory Numbers in an enterprise.
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the  responsePageSize will be set to  the maximum ResponsePageSize by default.
        /// If no sortOrder is included the response is sorted by Mobile Number ascending by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// The department in both the search criteria and sort by fields refer to the department of the user.
        /// The response is either EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListResponse> EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListRequest(this OcipClient client, EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListRequest request)
        {
            return await client.Call(request) as EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListResponse;
        }

        /// <summary>
        /// Request a list of available Mobile Subscriber Directory Numbers not yet assigned to any user.
        /// The response is either EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse> EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest(this OcipClient client, EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest request)
        {
            return await client.Call(request) as EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse;
        }

        /// <summary>
        /// Request a list of available Mobile Subscriber Directory Numbers not yet assigned to any user.
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// If no sortOrder is included the response is sorted by Mobile Number ascending by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// The response is either EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListResponse> EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListRequest(this OcipClient client, EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListRequest request)
        {
            return await client.Call(request) as EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListResponse;
        }

        /// <summary>
        /// Get the group's BroadWorks Mobility settings.
        /// The response is either a GroupBroadWorksMobilityGetResponse22V3 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupBroadWorksMobilityGetResponse22V3> GroupBroadWorksMobilityGetRequest22V3(this OcipClient client, GroupBroadWorksMobilityGetRequest22V3 request)
        {
            return await client.Call(request) as GroupBroadWorksMobilityGetResponse22V3;
        }

        /// <summary>
        /// Assign Mobile Subscriber Directory Numbers to a group. It is possible to
        /// add a single DN,or a list of DNs.
        /// .       This command is applicable only for group in a service provider and will fail for a group in an enterprise.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksMobilityMobileSubscriberDirectoryNumberAssignListRequest(this OcipClient client, GroupBroadWorksMobilityMobileSubscriberDirectoryNumberAssignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of assigned and unassigned Mobile Subscriber Directory Numbers in a group. Each DN can be assigned to a user.
        /// .       This command is applicable only for group in a service provider and will fail for a group in an enterprise.
        /// The response is either a GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse> GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListRequest(this OcipClient client, GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListRequest request)
        {
            return await client.Call(request) as GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse;
        }

        /// <summary>
        /// Request a list of available Mobile Subscriber Directory Numbers not yet assigned to any user.
        /// .       This command is applicable only for group in a service provider and will fail for a group in an enterprise.
        /// The response is either GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse> GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest(this OcipClient client, GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest request)
        {
            return await client.Call(request) as GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse;
        }

        /// <summary>
        /// Unassign Mobile Subscriber Directory Numbers from a group. It is possible to unassign either: a single DN, or a list of DNs.
        /// .       This command is applicable only for group in a service provider and will fail for a group in an enterprise.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksMobilityMobileSubscriberDirectoryNumberUnassignListRequest(this OcipClient client, GroupBroadWorksMobilityMobileSubscriberDirectoryNumberUnassignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level broadworks mobility service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupBroadWorksMobilityModifyRequest(this OcipClient client, GroupBroadWorksMobilityModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the service provider BroadWorks Mobility service settings.
        /// The response is either a ServiceProviderBroadWorksMobilityGetResponse22V3 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderBroadWorksMobilityGetResponse22V3> ServiceProviderBroadWorksMobilityGetRequest22V3(this OcipClient client, ServiceProviderBroadWorksMobilityGetRequest22V3 request)
        {
            return await client.Call(request) as ServiceProviderBroadWorksMobilityGetResponse22V3;
        }

        /// <summary>
        /// Adds Mobile Subscriber Directory Numbers to a service provider-mobile network combination. It is possible to add a single DN,
        /// or a list of DNs.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberAddListRequest21(this OcipClient client, ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberAddListRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Deletes Mobile Subscriber Directory Numbers from a service provider. It is possible to delete either: a single number,
        /// or a list of numbers.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberDeleteListRequest(this OcipClient client, ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberDeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a list of available Mobile Subscriber Directory Numbers not yet assigned to any group. This command is applicable only for service providers and will fail for enterprises.
        /// The response is either ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse> ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest(this OcipClient client, ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest request)
        {
            return await client.Call(request) as ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse;
        }

        /// <summary>
        /// Request a summary table of all Mobile Subscriber Directory Numbers in a service provider. This command is applicable only for service providers and will fail for enterprises.
        /// The response is either ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse> ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest(this OcipClient client, ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest request)
        {
            return await client.Call(request) as ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse;
        }

        /// <summary>
        /// Modify the service provider level BroadWorks Mobility service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderBroadWorksMobilityModifyRequest(this OcipClient client, ServiceProviderBroadWorksMobilityModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Adds BroadWorks Mobility IMRN numbers to the system. It is possible to add either:
        /// a single number, a list of numbers, or a range of numbers, or any combination thereof.
        /// The response is either a SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityAddIMRNListRequest(this OcipClient client, SystemBroadWorksMobilityAddIMRNListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Adds BroadWorks Mobility IMRN numbers to a Mobile Network. It is possible to add either:
        /// a single number, a list of numbers, or a range of numbers, or any combination thereof.
        /// The response is either a SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityAddMobileNetworkIMRNListRequest(this OcipClient client, SystemBroadWorksMobilityAddMobileNetworkIMRNListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Removes a BroadWorks Mobility IMRN number from the system.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityDeleteIMRNListRequest(this OcipClient client, SystemBroadWorksMobilityDeleteIMRNListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Remove BroadWorks Mobility IMRN numbers from a Mobile Network.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityDeleteMobileNetworkIMRNListRequest(this OcipClient client, SystemBroadWorksMobilityDeleteMobileNetworkIMRNListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of BroadWorks Mobility IMRN numbers defined in the system.
        /// The response is either a SystemBroadWorksMobilityGetIMRNListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityGetIMRNListResponse> SystemBroadWorksMobilityGetIMRNListRequest(this OcipClient client, SystemBroadWorksMobilityGetIMRNListRequest request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityGetIMRNListResponse;
        }

        /// <summary>
        /// Get a list of BroadWorks Mobility IMRN numbers from a Mobile Network.
        /// The response is either a SystemBroadWorksMobilityGetMobileNetworkIMRNListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityGetMobileNetworkIMRNListResponse> SystemBroadWorksMobilityGetMobileNetworkIMRNListRequest(this OcipClient client, SystemBroadWorksMobilityGetMobileNetworkIMRNListRequest request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityGetMobileNetworkIMRNListResponse;
        }

        /// <summary>
        /// Get the broadworks mobility system parameters.
        /// The response is either a SystemBroadWorksMobilityGetResponse22V3 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityGetResponse22V3> SystemBroadWorksMobilityGetRequest22V3(this OcipClient client, SystemBroadWorksMobilityGetRequest22V3 request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityGetResponse22V3;
        }

        /// <summary>
        /// Add a Mobile Network.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityMobileNetworkAddRequest(this OcipClient client, SystemBroadWorksMobilityMobileNetworkAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Mobile Network.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityMobileNetworkDeleteRequest(this OcipClient client, SystemBroadWorksMobilityMobileNetworkDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of Mobile Networks.
        /// The response is either SystemBroadWorksMobilityMobileNetworkGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityMobileNetworkGetListResponse> SystemBroadWorksMobilityMobileNetworkGetListRequest(this OcipClient client, SystemBroadWorksMobilityMobileNetworkGetListRequest request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityMobileNetworkGetListResponse;
        }

        /// <summary>
        /// Get a Mobile Network.
        /// The response is either SystemBroadWorksMobilityMobileNetworkGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityMobileNetworkGetResponse> SystemBroadWorksMobilityMobileNetworkGetRequest(this OcipClient client, SystemBroadWorksMobilityMobileNetworkGetRequest request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityMobileNetworkGetResponse;
        }

        /// <summary>
        /// Modify a Mobile Network.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityMobileNetworkModifyRequest(this OcipClient client, SystemBroadWorksMobilityMobileNetworkModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a summary table of all Mobile Subscriber Directory Numbers in a system.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the mobile subscriber
        /// directory numbers in the administrator's reseller meeting the search criteria are returned.
        /// The response is either SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse or ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        public static async Task<SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse> SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest(this OcipClient client, SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse;
        }

        /// <summary>
        /// Modify the BroadWorks Mobility system parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityModifyRequest21(this OcipClient client, SystemBroadWorksMobilityModifyRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a service access code to a list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityServiceAccessCodeAddRequest21(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeAddRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a service access code from a list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityServiceAccessCodeDeleteRequest21(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeDeleteRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of system service access codes.
        /// The response is either SystemBroadWorksMobilityServiceAccessCodeGetListResponse21 or ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityServiceAccessCodeGetListResponse21> SystemBroadWorksMobilityServiceAccessCodeGetListRequest21(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeGetListRequest21 request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityServiceAccessCodeGetListResponse21;
        }

        /// <summary>
        /// Add a Service Access Code list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityServiceAccessCodeListAddRequest(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeListAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Service Access Code list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityServiceAccessCodeListDeleteRequest(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeListDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of Service Access Code lists.
        /// The response is either SystemBroadWorksMobilityServiceAccessCodeListGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityServiceAccessCodeListGetListResponse> SystemBroadWorksMobilityServiceAccessCodeListGetListRequest(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeListGetListRequest request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityServiceAccessCodeListGetListResponse;
        }

        /// <summary>
        /// Modify a Service Access Code list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityServiceAccessCodeListModifyRequest(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeListModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get all the Mobile Networks using a given Service Access Code list.
        /// The response is either SystemBroadWorksMobilityServiceAccessCodeListUsageGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityServiceAccessCodeListUsageGetResponse> SystemBroadWorksMobilityServiceAccessCodeListUsageGetRequest(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeListUsageGetRequest request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityServiceAccessCodeListUsageGetResponse;
        }

        /// <summary>
        /// Modify a service access code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityServiceAccessCodeModifyRequest21(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeModifyRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Adding a new mobile identity using the Share Call Appearance.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The request fails when the devicesToRing is set to Mobile and the mobileNumberAlerted list is empty.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadworksMobilityAddMobileIdentityUsingSharedCallAppearanceRequest(this OcipClient client, UserBroadworksMobilityAddMobileIdentityUsingSharedCallAppearanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the user's BroadWorks Mobility service settings with details for DNs.
        /// The response is either a UserBroadWorksMobilityGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksMobilityGetResponse21sp1> UserBroadWorksMobilityGetRequest21sp1(this OcipClient client, UserBroadWorksMobilityGetRequest21sp1 request)
        {
            return await client.Call(request) as UserBroadWorksMobilityGetResponse21sp1;
        }

        /// <summary>
        /// Add a mobile identity to the user's list of mobile identities.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The request fails when the devicesToRing is set to Mobile and the mobileNumberAlerted list is empty.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksMobilityMobileIdentityAddRequest21sp1(this OcipClient client, UserBroadWorksMobilityMobileIdentityAddRequest21sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a mobile identity to the user's list of mobile identities.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The request fails when the devicesToRing is set to Mobile and the mobileNumberAlerted list is empty.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksMobilityMobileIdentityAddRequest22(this OcipClient client, UserBroadWorksMobilityMobileIdentityAddRequest22 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a mobile identity to the user's list of mobile identities.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The request fails when the devicesToRing is set to Mobile and the mobileNumberAlerted list is empty.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksMobilityMobileIdentityConsolidatedAddRequest(this OcipClient client, UserBroadWorksMobilityMobileIdentityConsolidatedAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a mobile identity from the user's list of mobile identities.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// An ErrorResponse will be returned if any device cannot be deleted because of insufficient privilege.
        /// When a delete request is attempted on the primary mobile identity, the delete will fail unless it is the last mobile identity in the user's list.
        /// 
        /// If deleteExistingDevices is set to true, after the mobile identity is deleted, any device that is only used by the deleted mobile identity prior to the deletion will be deleted if the command is executed with the correct priviledge.
        /// Group administrator or above running this command can delete any group level devices. Service provider administrator or above can delete any service provider and group devices. Provisioning administrator or above can delete any devices.
        /// An ErrorResponse with the type warning will be returned if any device cannot be deleted because of insufficient privilege.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksMobilityMobileIdentityConsolidatedDeleteRequest(this OcipClient client, UserBroadWorksMobilityMobileIdentityConsolidatedDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the settings for one of the user's BroadWorks Mobility mobile Identities.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// If deleteExistingDevices is set to true, when the devices for the endpoint are changed, devices with no more endpoint will be deleted if the command is executed with the correct privilege.
        /// 
        /// The request fails when enableAlerting or timeSchedule or holidaySchedule are included in the request when the use mobile identity call anchoring controls for the user  is disabled.
        /// 
        /// The description, enableAlerting, alertAgentCalls, alertClickToDialCalls, alertGroupPagingCalls, useMobilityCallingLineID, enableDiversionInhibitor, requireAnswerConfirmation, broadworksCallControl, devicesToRing, includeSharedCallAppearance, includeBroadworksAnywhere, includeExecutiveAssistance, mobileNumberAlerted, enableCallAnchoring, timeSchedule and holidaySchedule  parameters require an authorization level of User for modification when the BroadWorks Mobility service is on.
        /// The isPrimary, useSettingLevel, denyCallOrigination, denyCallTerminations, accessDeviceEndpoint, outboundAlternateNumber, enableDirectRouting, markCDRAsEnterpriseGroupCalls and networkTranslationIndex parameters require an authorization level of Group for modification.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksMobilityMobileIdentityConsolidatedModifyRequest(this OcipClient client, UserBroadWorksMobilityMobileIdentityConsolidatedModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a mobile identity from the user's list of mobile identities.
        /// The response is either a SuccessResponse or an ErrorResponse. If another Mobile Identity is set to ring mobile only and only has this mobile identity
        /// in the alerting list, the identity is deleted and ErrorResponse is returned. The ErrorResponse is info type and  contains the affected mobile numbers
        /// in the summary.
        /// When a delete request is attempted on the primary mobile identity, the delete will fail unless it is the last mobile identity in the user's list.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksMobilityMobileIdentityDeleteRequest(this OcipClient client, UserBroadWorksMobilityMobileIdentityDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the settings for a user's specified mobile identity.
        /// The response is either a UserBroadWorksMobilityMobileIdentityGetResponse21sp1V2 or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksMobilityMobileIdentityGetResponse21sp1V2> UserBroadWorksMobilityMobileIdentityGetRequest21sp1V2(this OcipClient client, UserBroadWorksMobilityMobileIdentityGetRequest21sp1V2 request)
        {
            return await client.Call(request) as UserBroadWorksMobilityMobileIdentityGetResponse21sp1V2;
        }

        /// <summary>
        /// Get the settings for a user's specified mobile identity.
        /// The response is either a UserBroadWorksMobilityMobileIdentityGetResponse22V2 or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksMobilityMobileIdentityGetResponse22V2> UserBroadWorksMobilityMobileIdentityGetRequest22V2(this OcipClient client, UserBroadWorksMobilityMobileIdentityGetRequest22V2 request)
        {
            return await client.Call(request) as UserBroadWorksMobilityMobileIdentityGetResponse22V2;
        }

        /// <summary>
        /// Modify the settings for one of the user's BroadWorks Mobility mobile Identities.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The request fails when enableAlerting or timeSchedule or holidaySchedule are included in the request when the user's use mobile identity call anchoring controls is disabled.
        /// 
        /// The description, enableAlerting, alertAgentCalls, alertClickToDialCalls, alertGroupPagingCalls, useMobilityCallingLineID, enableDiversionInhibitor, requireAnswerConfirmation, broadworksCallControl, devicesToRing, includeSharedCallAppearance, includeBroadworksAnywhere, includeExecutiveAssistance, mobileNumberAlerted, enableCallAnchoring, timeSchedule, holidaySchedule and useMobilityConnectedIdentity parameters require an authorization level of User for modification when the BroadWorks Mobility service is on.
        /// The isPrimary, useSettingLevel, denyCallOrigination, denyCallTerminations, accessDeviceEndpoint, outboundAlternateNumber, enableDirectRouting, markCDRAsEnterpriseGroupCalls and networkTranslationIndex  parameters require an authorization level of Group for modification.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksMobilityMobileIdentityModifyRequest(this OcipClient client, UserBroadWorksMobilityMobileIdentityModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's BroadWorks Mobility service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The isActive, useMobileIdentityCallAnchoring, and preventCallsToOwnMobiles parameters can be modified by users with Group Authorization Level and above.
        /// The mobileIdentity, profileIdentityDevicesToRing, rofileIdentityIncludeSharedCallAppearance, profileIdentityIncludeBroadworksAnywhere mobileIdentity and profileIdentityMobilityNumbersAlerted parameters can be modified by users with User Authorization Level and above when the BroadWorks Mobility service is turned on.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksMobilityModifyRequest21(this OcipClient client, UserBroadWorksMobilityModifyRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
