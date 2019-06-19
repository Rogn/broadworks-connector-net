using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest.
    /// Contains a list of Peer SIP Connection Monitoring system parameters.
    /// <see cref="SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9548""}]")]
    public class SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9548")]
        public bool Enabled
        {
            get => _enabled;
            set
            {
                EnabledSpecified = true;
                _enabled = value;
            }
        }

        [XmlIgnore]
        public bool EnabledSpecified { get; set; }

        private int _heartbeatInterval;

        [XmlElement(ElementName = "heartbeatInterval", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9548")]
        [MinInclusive(10)]
        [MaxInclusive(3600000)]
        public int HeartbeatInterval
        {
            get => _heartbeatInterval;
            set
            {
                HeartbeatIntervalSpecified = true;
                _heartbeatInterval = value;
            }
        }

        [XmlIgnore]
        public bool HeartbeatIntervalSpecified { get; set; }

        private int _heartbeatTimeout;

        [XmlElement(ElementName = "heartbeatTimeout", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9548")]
        [MinInclusive(10)]
        [MaxInclusive(18000000)]
        public int HeartbeatTimeout
        {
            get => _heartbeatTimeout;
            set
            {
                HeartbeatTimeoutSpecified = true;
                _heartbeatTimeout = value;
            }
        }

        [XmlIgnore]
        public bool HeartbeatTimeoutSpecified { get; set; }

    }
}
