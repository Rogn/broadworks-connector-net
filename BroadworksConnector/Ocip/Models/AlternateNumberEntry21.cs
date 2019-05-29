using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AlternateNumberEntry21 
{
    [XmlElement(ElementName = "phoneNumber", IsNullable = true)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "extension", IsNullable = true)]
    public string Extension { get; set; }
    [XmlElement(ElementName = "ringPattern", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.RingPattern? RingPattern { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
 }
}