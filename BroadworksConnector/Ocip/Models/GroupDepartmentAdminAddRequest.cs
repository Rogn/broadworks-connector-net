using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentAdminAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "departmentKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupDepartmentKey DepartmentKey { get; set; }
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "firstName", IsNullable = false)]
    public string FirstName { get; set; }
    [XmlElement(ElementName = "lastName", IsNullable = false)]
    public string LastName { get; set; }
    [XmlElement(ElementName = "password", IsNullable = false)]
    public string Password { get; set; }
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
 }
}