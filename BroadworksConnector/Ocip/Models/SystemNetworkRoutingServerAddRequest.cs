using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkRoutingServerAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "port", IsNullable = false)]
    public int Port { get; set; }
    [XmlElement(ElementName = "transportProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TransportProtocol TransportProtocol { get; set; }
    [XmlElement(ElementName = "poll", IsNullable = false)]
    public bool Poll { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
 }
}