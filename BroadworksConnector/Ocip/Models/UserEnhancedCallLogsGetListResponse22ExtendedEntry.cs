using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse22ExtendedEntry 
{
    [XmlElement(ElementName = "extendedCallLog", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ExtendedMixedCallLogsEntry22> ExtendedCallLog { get; set; }
 }
}