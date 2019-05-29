using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AnnouncementFileLevelKey 
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "mediaFileType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType MediaFileType { get; set; }
    [XmlElement(ElementName = "level", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementRepositoryType Level { get; set; }
 }
}