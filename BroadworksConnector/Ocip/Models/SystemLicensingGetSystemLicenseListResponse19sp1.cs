using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLicensingGetSystemLicenseListResponse19sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "license", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SystemLicenseType19sp1> License { get; set; }
 }
}