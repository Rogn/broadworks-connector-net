using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceAdd21 
{
    [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AudioFileCodecExtended AudioFilePreferredCodec { get; set; }
    [XmlElement(ElementName = "messageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldMessageSelection MessageSourceSelection { get; set; }
    [XmlElement(ElementName = "labeledCustomSourceMediaFiles", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceAdd21LabeledCustomSourceMediaFiles LabeledCustomSourceMediaFiles { get; set; }
    [XmlElement(ElementName = "announcementCustomSourceMediaFiles", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceAdd21AnnouncementCustomSourceMediaFiles AnnouncementCustomSourceMediaFiles { get; set; }
    [XmlElement(ElementName = "externalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceAdd21ExternalSource ExternalSource { get; set; }
 }
}