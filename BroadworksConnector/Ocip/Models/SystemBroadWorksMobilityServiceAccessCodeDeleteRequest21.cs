using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityServiceAccessCodeDeleteRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceAccessCodeListName", IsNullable = false)]
    public string ServiceAccessCodeListName { get; set; }
    [XmlElement(ElementName = "countryCode", IsNullable = false)]
    public string CountryCode { get; set; }
    [XmlElement(ElementName = "serviceAccessCode", IsNullable = false)]
    public string ServiceAccessCode { get; set; }
 }
}