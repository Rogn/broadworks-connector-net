using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingNameRetrievalGetResponse17sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "triggerCNAMQueriesForAllNetworkCalls", IsNullable = false)]
    public bool TriggerCNAMQueriesForAllNetworkCalls { get; set; }
    [XmlElement(ElementName = "triggerCNAMQueriesForGroupAndEnterpriseCalls", IsNullable = false)]
    public bool TriggerCNAMQueriesForGroupAndEnterpriseCalls { get; set; }
    [XmlElement(ElementName = "queryProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallingNameRetrievalQueryProtocol QueryProtocol { get; set; }
    [XmlElement(ElementName = "queryTimeoutMilliseconds", IsNullable = false)]
    public int QueryTimeoutMilliseconds { get; set; }
    [XmlElement(ElementName = "sipExternalDatabaseNetAddress", IsNullable = false)]
    public string SipExternalDatabaseNetAddress { get; set; }
    [XmlElement(ElementName = "sipExternalDatabasePort", IsNullable = false)]
    public int SipExternalDatabasePort { get; set; }
    [XmlElement(ElementName = "sipExternalDatabaseTransport", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TransportProtocol SipExternalDatabaseTransport { get; set; }
    [XmlElement(ElementName = "soapExternalDatabaseNetAddress", IsNullable = false)]
    public string SoapExternalDatabaseNetAddress { get; set; }
    [XmlElement(ElementName = "soapSupportsDNSSRV", IsNullable = false)]
    public bool SoapSupportsDNSSRV { get; set; }
    [XmlElement(ElementName = "callingNameSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallingNameRetrievalSourceIdentity CallingNameSource { get; set; }
 }
}