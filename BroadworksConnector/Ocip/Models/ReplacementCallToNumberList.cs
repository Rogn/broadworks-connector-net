using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCallToNumberList 
{
    [XmlElement(ElementName = "callToNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallToNumber> CallToNumber { get; set; }
 }
}