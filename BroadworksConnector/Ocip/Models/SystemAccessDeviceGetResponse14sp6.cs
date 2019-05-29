using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceGetResponse14sp6 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "protocol", IsNullable = false)]
    public string Protocol { get; set; }
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "port", IsNullable = false)]
    public int Port { get; set; }
    [XmlElement(ElementName = "outboundProxyServerNetAddress", IsNullable = false)]
    public string OutboundProxyServerNetAddress { get; set; }
    [XmlElement(ElementName = "stunServerNetAddress", IsNullable = false)]
    public string StunServerNetAddress { get; set; }
    [XmlElement(ElementName = "macAddress", IsNullable = false)]
    public string MacAddress { get; set; }
    [XmlElement(ElementName = "serialNumber", IsNullable = false)]
    public string SerialNumber { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "numberOfPorts", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedPositiveInt NumberOfPorts { get; set; }
    [XmlElement(ElementName = "numberOfAssignedPorts", IsNullable = false)]
    public int NumberOfAssignedPorts { get; set; }
    [XmlElement(ElementName = "status", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceStatus Status { get; set; }
    [XmlElement(ElementName = "physicalLocation", IsNullable = false)]
    public string PhysicalLocation { get; set; }
    [XmlElement(ElementName = "transportProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TransportProtocol TransportProtocol { get; set; }
    [XmlElement(ElementName = "mobilityManagerProvisioningURL", IsNullable = false)]
    public string MobilityManagerProvisioningURL { get; set; }
    [XmlElement(ElementName = "mobilityManagerProvisioningUserName", IsNullable = false)]
    public string MobilityManagerProvisioningUserName { get; set; }
    [XmlElement(ElementName = "mobilityManagerDefaultOriginatingServiceKey", IsNullable = false)]
    public int MobilityManagerDefaultOriginatingServiceKey { get; set; }
    [XmlElement(ElementName = "mobilityManagerDefaultTerminatingServiceKey", IsNullable = false)]
    public int MobilityManagerDefaultTerminatingServiceKey { get; set; }
    [XmlElement(ElementName = "useCustomUserNamePassword", IsNullable = false)]
    public bool UseCustomUserNamePassword { get; set; }
    [XmlElement(ElementName = "userName", IsNullable = false)]
    public string UserName { get; set; }
 }
}