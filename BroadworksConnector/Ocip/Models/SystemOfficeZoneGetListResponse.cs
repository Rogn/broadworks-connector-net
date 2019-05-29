using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOfficeZoneGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "officeZoneTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable OfficeZoneTable { get; set; }
 }
}