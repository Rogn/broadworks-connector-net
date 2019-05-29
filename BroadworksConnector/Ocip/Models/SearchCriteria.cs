using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaAccessDeviceEndpointPrivateIdentity))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaAccessDeviceVersion))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaAdminFirstName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaAdminId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaAdminLastName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaAgentThresholdProfile))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaAlternateTrunkIdentity))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaAlternateTrunkIdentityDomain))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaAlternateUserId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaAnnouncementFileName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterReportTemplateName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterScheduledReportName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaCallParkName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaCallPickupName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCode))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCodeDescription))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaDepartmentName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaDeviceMACAddress))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventAdditionalInfo))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventLoginId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaDeviceName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaDeviceNetAddress))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaDeviceSerialNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaDeviceType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaDigitPattern))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaDn))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaDomainName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaEmailAddress))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonMultiPartPhoneListName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseTrunkName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactAnnouncementFileType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactAutoAttendantType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterReportTemplateKey))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportGroup))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportServiceProvider))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactCustomContactDirectory))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceLevel))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventAction))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventLevel))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusCompleted))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceServiceProvider))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactDnActivation))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactDnAvailability))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactDnDepartment))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactEndpointType21sp1))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactGroupAdminType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactHuntPolicy))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactLocationEnabled))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactMediaFileType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactMobileDnAvailability))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactMobileNetwork))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactOrganizationType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactPolicySelection))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactPortNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactScheduleLevel))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactScheduleType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactServiceProvider))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactServiceProviderAdminType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactServiceType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactSignalingAddressType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactSkillLevel))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactUserDepartment))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactUserGroup))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactUserInTrunkGroup))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactUserNetworkClassOfService))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactUserRouteListAssigned))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactUserRouteListAssignment))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactUserType))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactVirtualOnNetCallTypeName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExtension))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaForwardedToNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaGroupCommonMultiPartPhoneListName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaGroupId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaGroupLocationCode))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaGroupName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaHomeMscAddress))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaImpId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaIMRN))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaLanguage))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaLinePortDomain))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaLinePortUserPart))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaLocation))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaLoginId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaMultiPartUserName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaNetworkClassOfServiceName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaNumberPortabilityQueryDigitPattern))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaNumberPortabilityStatus))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumberDescription))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaPhysicalLocation))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaProfileServiceCode))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaProfileServiceCodeDescription))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaReceptionistNote))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaRegistrationURI))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaResellerId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaResellerName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaRoamingMscAddress))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaRoutePointName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaScheduleName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaServiceCode))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaServiceCodeDescription))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaServiceInstanceName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderNumberPortabilityQueryDigitPattern))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaServiceStatus))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaSIPContact))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaSystemServiceDn))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaTitle))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaTrunkGroupName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaUserId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaUserName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaUserPersonalMultiPartPhoneListName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaYahooId))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaZoneIPAddress))]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SearchCriteriaExactEndpointType))]
public abstract class SearchCriteria 
{
 }
}