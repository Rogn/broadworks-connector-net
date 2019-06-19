using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Cr Interface.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6931""}]")]
    public class SystemCrInterfaceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _crAuditEnabled;

        [XmlElement(ElementName = "crAuditEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6931")]
        public bool CrAuditEnabled
        {
            get => _crAuditEnabled;
            set
            {
                CrAuditEnabledSpecified = true;
                _crAuditEnabled = value;
            }
        }

        [XmlIgnore]
        public bool CrAuditEnabledSpecified { get; set; }

        private int _crAuditIntervalMilliseconds;

        [XmlElement(ElementName = "crAuditIntervalMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6931")]
        [MinInclusive(500)]
        [MaxInclusive(60000)]
        public int CrAuditIntervalMilliseconds
        {
            get => _crAuditIntervalMilliseconds;
            set
            {
                CrAuditIntervalMillisecondsSpecified = true;
                _crAuditIntervalMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool CrAuditIntervalMillisecondsSpecified { get; set; }

        private int _crAuditTimeoutMilliseconds;

        [XmlElement(ElementName = "crAuditTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6931")]
        [MinInclusive(500)]
        [MaxInclusive(10000)]
        public int CrAuditTimeoutMilliseconds
        {
            get => _crAuditTimeoutMilliseconds;
            set
            {
                CrAuditTimeoutMillisecondsSpecified = true;
                _crAuditTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool CrAuditTimeoutMillisecondsSpecified { get; set; }

        private bool _crConnectionEnabled;

        [XmlElement(ElementName = "crConnectionEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6931")]
        public bool CrConnectionEnabled
        {
            get => _crConnectionEnabled;
            set
            {
                CrConnectionEnabledSpecified = true;
                _crConnectionEnabled = value;
            }
        }

        [XmlIgnore]
        public bool CrConnectionEnabledSpecified { get; set; }

        private int _crConnectionTimeoutMilliseconds;

        [XmlElement(ElementName = "crConnectionTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6931")]
        [MinInclusive(1000)]
        [MaxInclusive(32000)]
        public int CrConnectionTimeoutMilliseconds
        {
            get => _crConnectionTimeoutMilliseconds;
            set
            {
                CrConnectionTimeoutMillisecondsSpecified = true;
                _crConnectionTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool CrConnectionTimeoutMillisecondsSpecified { get; set; }

        private int _crTcpConnectionTimeoutSeconds;

        [XmlElement(ElementName = "crTcpConnectionTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6931")]
        [MinInclusive(1)]
        [MaxInclusive(120)]
        public int CrTcpConnectionTimeoutSeconds
        {
            get => _crTcpConnectionTimeoutSeconds;
            set
            {
                CrTcpConnectionTimeoutSecondsSpecified = true;
                _crTcpConnectionTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool CrTcpConnectionTimeoutSecondsSpecified { get; set; }

        private int _crNumberOfReconnectionAttempts;

        [XmlElement(ElementName = "crNumberOfReconnectionAttempts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6931")]
        [MinInclusive(0)]
        [MaxInclusive(100)]
        public int CrNumberOfReconnectionAttempts
        {
            get => _crNumberOfReconnectionAttempts;
            set
            {
                CrNumberOfReconnectionAttemptsSpecified = true;
                _crNumberOfReconnectionAttempts = value;
            }
        }

        [XmlIgnore]
        public bool CrNumberOfReconnectionAttemptsSpecified { get; set; }

    }
}
