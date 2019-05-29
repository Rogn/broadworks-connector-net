using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSystemVoicePortalGetRequest21sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "systemVoicePortalId", IsNullable = false)]
    public string SystemVoicePortalId { get; set; }
 }
}