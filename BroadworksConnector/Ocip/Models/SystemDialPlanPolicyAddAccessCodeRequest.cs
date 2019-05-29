using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDialPlanPolicyAddAccessCodeRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "accessCode", IsNullable = false)]
    public string AccessCode { get; set; }
    [XmlElement(ElementName = "includeCodeForNetworkTranslationsAndRouting", IsNullable = false)]
    public bool IncludeCodeForNetworkTranslationsAndRouting { get; set; }
    [XmlElement(ElementName = "includeCodeForScreeningServices", IsNullable = false)]
    public bool IncludeCodeForScreeningServices { get; set; }
    [XmlElement(ElementName = "enableSecondaryDialTone", IsNullable = false)]
    public bool EnableSecondaryDialTone { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
 }
}