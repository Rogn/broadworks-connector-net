using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClassmarkModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "classmark", IsNullable = false)]
    public string Classmark { get; set; }
    [XmlElement(ElementName = "value", IsNullable = false)]
    public string Value { get; set; }
    [XmlElement(ElementName = "webDisplayKey", IsNullable = true)]
    public string WebDisplayKey { get; set; }
 }
}