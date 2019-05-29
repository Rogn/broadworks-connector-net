using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "code", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeConfiguration> Code { get; set; }
 }
}