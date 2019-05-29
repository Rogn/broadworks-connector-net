using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserGetVoicePortalResponse16 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "usePersonalizedName", IsNullable = false)]
    public bool UsePersonalizedName { get; set; }
    [XmlElement(ElementName = "voicePortalAutoLogin", IsNullable = false)]
    public bool VoicePortalAutoLogin { get; set; }
    [XmlElement(ElementName = "personalizedNameAudioFileDescription", IsNullable = false)]
    public string PersonalizedNameAudioFileDescription { get; set; }
    [XmlElement(ElementName = "personalizedNameMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType PersonalizedNameMediaType { get; set; }
 }
}