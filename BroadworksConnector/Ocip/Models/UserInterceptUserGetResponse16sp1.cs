using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserInterceptUserGetResponse16sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "announcementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection { get; set; }
    [XmlElement(ElementName = "audioFileDescription", IsNullable = false)]
    public string AudioFileDescription { get; set; }
    [XmlElement(ElementName = "audioMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType AudioMediaType { get; set; }
    [XmlElement(ElementName = "videoFileDescription", IsNullable = false)]
    public string VideoFileDescription { get; set; }
    [XmlElement(ElementName = "videoMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType VideoMediaType { get; set; }
    [XmlElement(ElementName = "playNewPhoneNumber", IsNullable = false)]
    public bool PlayNewPhoneNumber { get; set; }
    [XmlElement(ElementName = "newPhoneNumber", IsNullable = false)]
    public string NewPhoneNumber { get; set; }
    [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false)]
    public bool TransferOnZeroToPhoneNumber { get; set; }
    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false)]
    public string TransferPhoneNumber { get; set; }
    [XmlElement(ElementName = "rerouteOutboundCalls", IsNullable = false)]
    public bool RerouteOutboundCalls { get; set; }
    [XmlElement(ElementName = "outboundReroutePhoneNumber", IsNullable = false)]
    public string OutboundReroutePhoneNumber { get; set; }
    [XmlElement(ElementName = "allowOutboundLocalCalls", IsNullable = false)]
    public bool AllowOutboundLocalCalls { get; set; }
    [XmlElement(ElementName = "inboundCallMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.InterceptInboundCall InboundCallMode { get; set; }
    [XmlElement(ElementName = "alternateBlockingAnnouncement", IsNullable = false)]
    public bool AlternateBlockingAnnouncement { get; set; }
    [XmlElement(ElementName = "routeToVoiceMail", IsNullable = false)]
    public bool RouteToVoiceMail { get; set; }
 }
}