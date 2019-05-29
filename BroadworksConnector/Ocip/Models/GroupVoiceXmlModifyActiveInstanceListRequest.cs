using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceXmlModifyActiveInstanceListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceActivation", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ServiceActivation> ServiceActivation { get; set; }
 }
}