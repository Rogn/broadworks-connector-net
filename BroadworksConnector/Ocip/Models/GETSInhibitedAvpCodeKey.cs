using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GETSInhibitedAvpCodeKey 
{
    [XmlElement(ElementName = "avpCode", IsNullable = false)]
    public int AvpCode { get; set; }
    [XmlElement(ElementName = "vendorId", IsNullable = false)]
    public int VendorId { get; set; }
 }
}