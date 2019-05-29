using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceTypeGetAvailableListRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "allowConference", IsNullable = false)]
    public bool AllowConference { get; set; }
    [XmlElement(ElementName = "allowMusicOnHold", IsNullable = false)]
    public bool AllowMusicOnHold { get; set; }
    [XmlElement(ElementName = "onlyConference", IsNullable = false)]
    public bool OnlyConference { get; set; }
    [XmlElement(ElementName = "onlyVideoCapable", IsNullable = false)]
    public bool OnlyVideoCapable { get; set; }
    [XmlElement(ElementName = "onlyOptionalIpAddress", IsNullable = false)]
    public bool OnlyOptionalIpAddress { get; set; }
    [XmlElement(ElementName = "excludeReseller", IsNullable = false)]
    public bool ExcludeReseller { get; set; }
    [XmlElement(ElementName = "resellerId", IsNullable = false)]
    public string ResellerId { get; set; }
 }
}