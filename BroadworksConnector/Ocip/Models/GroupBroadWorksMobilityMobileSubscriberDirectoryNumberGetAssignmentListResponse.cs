using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "mobileSubscriberDirectoryNumberTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumberTable { get; set; }
 }
}