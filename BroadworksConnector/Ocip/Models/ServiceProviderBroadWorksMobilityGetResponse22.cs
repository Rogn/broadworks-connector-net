using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderBroadWorksMobilityGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useSettingLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityServiceProviderSettingLevel UseSettingLevel { get; set; }
    [XmlElement(ElementName = "enableLocationServices", IsNullable = false)]
    public bool EnableLocationServices { get; set; }
    [XmlElement(ElementName = "enableMSRNLookup", IsNullable = false)]
    public bool EnableMSRNLookup { get; set; }
    [XmlElement(ElementName = "enableMobileStateChecking", IsNullable = false)]
    public bool EnableMobileStateChecking { get; set; }
    [XmlElement(ElementName = "denyCallOriginations", IsNullable = false)]
    public bool DenyCallOriginations { get; set; }
    [XmlElement(ElementName = "denyCallTerminations", IsNullable = false)]
    public bool DenyCallTerminations { get; set; }
    [XmlElement(ElementName = "enableAnnouncementSuppression", IsNullable = false)]
    public bool EnableAnnouncementSuppression { get; set; }
    [XmlElement(ElementName = "enableInternalCLIDDelivery", IsNullable = false)]
    public bool EnableInternalCLIDDelivery { get; set; }
 }
}