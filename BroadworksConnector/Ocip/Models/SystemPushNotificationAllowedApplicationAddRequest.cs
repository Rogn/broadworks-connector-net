using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPushNotificationAllowedApplicationAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "applicationId", IsNullable = false)]
    public string ApplicationId { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
 }
}