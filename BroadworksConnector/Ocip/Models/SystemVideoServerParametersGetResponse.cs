using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVideoServerParametersGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "videoServerResponseTimerMilliseconds", IsNullable = false)]
    public int VideoServerResponseTimerMilliseconds { get; set; }
    [XmlElement(ElementName = "videoServerSelectionRouteTimerMilliseconds", IsNullable = false)]
    public int VideoServerSelectionRouteTimerMilliseconds { get; set; }
    [XmlElement(ElementName = "useStaticVideoServerDevice", IsNullable = false)]
    public bool UseStaticVideoServerDevice { get; set; }
 }
}