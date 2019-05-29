using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLicensingGetResponse14sp3 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "licenseStrictness", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LicenseStrictness LicenseStrictness { get; set; }
    [XmlElement(ElementName = "groupUserlimit", IsNullable = false)]
    public int GroupUserlimit { get; set; }
    [XmlElement(ElementName = "expirationDate", IsNullable = false)]
    public string ExpirationDate { get; set; }
    [XmlElement(ElementName = "hostId", IsNullable = false)]
    public List<string> HostId { get; set; }
    [XmlElement(ElementName = "licenseName", IsNullable = false)]
    public List<string> LicenseName { get; set; }
    [XmlElement(ElementName = "numberOfTrunkUsers", IsNullable = false)]
    public int NumberOfTrunkUsers { get; set; }
    [XmlElement(ElementName = "subscriberLicenseTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SubscriberLicenseTable { get; set; }
    [XmlElement(ElementName = "groupServiceLicenseTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupServiceLicenseTable { get; set; }
    [XmlElement(ElementName = "virtualServiceLicenseTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable VirtualServiceLicenseTable { get; set; }
    [XmlElement(ElementName = "userServiceLicenseTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserServiceLicenseTable { get; set; }
    [XmlElement(ElementName = "systemParamLicenseTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SystemParamLicenseTable { get; set; }
 }
}