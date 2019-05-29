using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "availableNumberPrefixTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AvailableNumberPrefixTable { get; set; }
 }
}