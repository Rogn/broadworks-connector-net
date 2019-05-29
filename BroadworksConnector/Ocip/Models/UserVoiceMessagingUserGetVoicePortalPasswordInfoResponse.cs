using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserGetVoicePortalPasswordInfoResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isLoginDisabled", IsNullable = false)]
    public bool IsLoginDisabled { get; set; }
    [XmlElement(ElementName = "expirationDays", IsNullable = false)]
    public int ExpirationDays { get; set; }
    [XmlElement(ElementName = "doesNotExpire", IsNullable = false)]
    public bool DoesNotExpire { get; set; }
    [XmlElement(ElementName = "password", IsNullable = false)]
    public string Password { get; set; }
 }
}