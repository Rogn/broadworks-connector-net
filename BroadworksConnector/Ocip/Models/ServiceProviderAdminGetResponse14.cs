using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAdminGetResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "firstName", IsNullable = false)]
    public string FirstName { get; set; }
    [XmlElement(ElementName = "lastName", IsNullable = false)]
    public string LastName { get; set; }
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
    [XmlElement(ElementName = "administratorType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminType AdministratorType { get; set; }
 }
}