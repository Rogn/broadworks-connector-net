using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20ChangeCurrentIntroductionOrMessageOrReplyMenuKeys 
{
    [XmlElement(ElementName = "endRecording", IsNullable = false)]
    public string EndRecording { get; set; }
 }
}