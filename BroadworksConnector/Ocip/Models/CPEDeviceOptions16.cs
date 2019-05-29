using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CPEDeviceOptions16 
{
    [XmlElement(ElementName = "enableMonitoring", IsNullable = false)]
    public bool EnableMonitoring { get; set; }
    [XmlElement(ElementName = "resetEvent", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CPEDeviceResetEventType ResetEvent { get; set; }
    [XmlElement(ElementName = "configType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 ConfigType { get; set; }
    [XmlElement(ElementName = "systemFileName", IsNullable = false)]
    public string SystemFileName { get; set; }
    [XmlElement(ElementName = "deviceFileFormat", IsNullable = false)]
    public string DeviceFileFormat { get; set; }
    [XmlElement(ElementName = "deviceManagementDeviceTypeOptions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementDeviceTypeOptions16 DeviceManagementDeviceTypeOptions { get; set; }
 }
}