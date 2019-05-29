using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantGetInstancePagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "autoAttendantTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AutoAttendantTable { get; set; }
 }
}