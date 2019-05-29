using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemShInterfaceParametersGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "hssRealm", IsNullable = false)]
    public string HssRealm { get; set; }
    [XmlElement(ElementName = "requestTimeoutSeconds", IsNullable = false)]
    public int RequestTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "publicIdentityRefreshDelaySeconds", IsNullable = false)]
    public int PublicIdentityRefreshDelaySeconds { get; set; }
 }
}