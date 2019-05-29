using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse17sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false)]
    public int TotalNumberOfRows { get; set; }
    [XmlElement(ElementName = "legacyEntry", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse17sp4LegacyEntry LegacyEntry { get; set; }
    [XmlElement(ElementName = "extendedEntry", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse17sp4ExtendedEntry ExtendedEntry { get; set; }
 }
}