using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPolicyGetDefaultResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupCallingPlanAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupCallingPlanAccess GroupCallingPlanAccess { get; set; }
    [XmlElement(ElementName = "groupExtensionAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupExtensionAccess GroupExtensionAccess { get; set; }
    [XmlElement(ElementName = "groupLDAPIntegrationAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupLDAPIntegrationAccess GroupLDAPIntegrationAccess { get; set; }
    [XmlElement(ElementName = "groupVoiceMessagingAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupVoiceMessagingAccess GroupVoiceMessagingAccess { get; set; }
    [XmlElement(ElementName = "groupDepartmentAdminUserAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminUserAccess GroupDepartmentAdminUserAccess { get; set; }
    [XmlElement(ElementName = "groupUserAuthenticationAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserAuthenticationAccess GroupUserAuthenticationAccess { get; set; }
    [XmlElement(ElementName = "groupUserGroupDirectoryAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserGroupDirectoryAccess GroupUserGroupDirectoryAccess { get; set; }
    [XmlElement(ElementName = "groupUserProfileAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserProfileAccess GroupUserProfileAccess { get; set; }
    [XmlElement(ElementName = "groupAdminProfileAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminProfileAccess GroupAdminProfileAccess { get; set; }
    [XmlElement(ElementName = "groupAdminUserAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminUserAccess GroupAdminUserAccess { get; set; }
    [XmlElement(ElementName = "groupAdminAdminAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminAdminAccess GroupAdminAdminAccess { get; set; }
    [XmlElement(ElementName = "groupAdminDepartmentAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminDepartmentAccess GroupAdminDepartmentAccess { get; set; }
    [XmlElement(ElementName = "groupAdminAccessDeviceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminAccessDeviceAccess GroupAdminAccessDeviceAccess { get; set; }
    [XmlElement(ElementName = "groupAdminEnhancedServiceInstanceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess GroupAdminEnhancedServiceInstanceAccess { get; set; }
    [XmlElement(ElementName = "groupAdminFeatureAccessCodeAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess GroupAdminFeatureAccessCodeAccess { get; set; }
    [XmlElement(ElementName = "groupAdminPhoneNumberExtensionAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess GroupAdminPhoneNumberExtensionAccess { get; set; }
    [XmlElement(ElementName = "groupAdminServiceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminServiceAccess GroupAdminServiceAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminProfileAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminProfileAccess ServiceProviderAdminProfileAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminGroupAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminGroupAccess ServiceProviderAdminGroupAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminUserAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminUserAccess ServiceProviderAdminUserAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminAdminAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminAdminAccess ServiceProviderAdminAdminAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminDepartmentAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess ServiceProviderAdminDepartmentAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminAccessDeviceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess ServiceProviderAdminAccessDeviceAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminPhoneNumberExtensionAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess ServiceProviderAdminPhoneNumberExtensionAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminServiceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminServiceAccess ServiceProviderAdminServiceAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminServicePackAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess ServiceProviderAdminServicePackAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminWebBrandingAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess ServiceProviderAdminWebBrandingAccess { get; set; }
    [XmlElement(ElementName = "enterpriseAdminNetworkPolicyAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess EnterpriseAdminNetworkPolicyAccess { get; set; }
 }
}