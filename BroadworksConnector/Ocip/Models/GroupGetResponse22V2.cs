using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGetResponse22V2 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "defaultDomain", IsNullable = false)]
    public string DefaultDomain { get; set; }
    [XmlElement(ElementName = "userLimit", IsNullable = false)]
    public int UserLimit { get; set; }
    [XmlElement(ElementName = "userCount", IsNullable = false)]
    public int UserCount { get; set; }
    [XmlElement(ElementName = "groupName", IsNullable = false)]
    public string GroupName { get; set; }
    [XmlElement(ElementName = "callingLineIdName", IsNullable = false)]
    public string CallingLineIdName { get; set; }
    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false)]
    public string CallingLineIdPhoneNumber { get; set; }
    [XmlElement(ElementName = "callingLineIdDisplayPhoneNumber", IsNullable = false)]
    public string CallingLineIdDisplayPhoneNumber { get; set; }
    [XmlElement(ElementName = "timeZone", IsNullable = false)]
    public string TimeZone { get; set; }
    [XmlElement(ElementName = "timeZoneDisplayName", IsNullable = false)]
    public string TimeZoneDisplayName { get; set; }
    [XmlElement(ElementName = "locationDialingCode", IsNullable = false)]
    public string LocationDialingCode { get; set; }
    [XmlElement(ElementName = "contact", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.Contact Contact { get; set; }
    [XmlElement(ElementName = "address", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.StreetAddress Address { get; set; }
    [XmlElement(ElementName = "servicePolicy", IsNullable = false)]
    public string ServicePolicy { get; set; }
    [XmlElement(ElementName = "callProcessingSliceId", IsNullable = false)]
    public string CallProcessingSliceId { get; set; }
    [XmlElement(ElementName = "provisioningSliceId", IsNullable = false)]
    public string ProvisioningSliceId { get; set; }
    [XmlElement(ElementName = "subscriberPartition", IsNullable = false)]
    public string SubscriberPartition { get; set; }
    [XmlElement(ElementName = "preferredDataCenter", IsNullable = false)]
    public string PreferredDataCenter { get; set; }
    [XmlElement(ElementName = "resellerId", IsNullable = false)]
    public string ResellerId { get; set; }
 }
}