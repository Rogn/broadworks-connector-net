using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceCustomTagGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "deviceName", IsNullable = false)]
    public string DeviceName { get; set; }
 }
}