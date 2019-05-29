using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterCallDispositionCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "dispositionCodesTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DispositionCodesTable { get; set; }
 }
}