using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSharedCallAppearanceDeleteEndpointListRequest14 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AccessDeviceEndpointKey> AccessDeviceEndpoint { get; set; }
 }
}