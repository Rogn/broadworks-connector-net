using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingPinholeDigitPlanDigitPatternOriginatingDepartmentPermissions 
{
    [XmlElement(ElementName = "departmentKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DepartmentKey DepartmentKey { get; set; }
    [XmlElement(ElementName = "departmentName", IsNullable = false)]
    public string DepartmentName { get; set; }
    [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingPermissions DigitPatternPermissions { get; set; }
 }
}