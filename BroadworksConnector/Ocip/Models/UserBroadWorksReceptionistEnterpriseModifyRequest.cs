using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksReceptionistEnterpriseModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "monitoredUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList MonitoredUserIdList { get; set; }
 }
}