using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ChangeCallForwardingDestinationMenuKeys 
{
    [XmlElement(ElementName = "finishEnteringNewDestinationNumber", IsNullable = false)]
    public string FinishEnteringNewDestinationNumber { get; set; }
 }
}