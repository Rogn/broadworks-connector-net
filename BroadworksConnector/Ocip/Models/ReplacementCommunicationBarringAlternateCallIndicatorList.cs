using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCommunicationBarringAlternateCallIndicatorList 
{
    [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false)]
    public List<string> AlternateCallIndicator { get; set; }
 }
}