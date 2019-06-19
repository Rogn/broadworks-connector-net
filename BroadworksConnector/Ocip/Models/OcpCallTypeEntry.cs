using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The outgoing call plan call type entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18582""}]")]
    public class OcpCallTypeEntry
    {

        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18582")]
        [MaxLength(3)]
        [RegularExpression(@"[0-9]|[1-9][0-9]{1,2}")]
        public string CountryCode
        {
            get => _countryCode;
            set
            {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        public bool CountryCodeSpecified { get; set; }

        private string _digitMap;

        [XmlElement(ElementName = "digitMap", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18582")]
        [MinLength(1)]
        [MaxLength(30)]
        public string DigitMap
        {
            get => _digitMap;
            set
            {
                DigitMapSpecified = true;
                _digitMap = value;
            }
        }

        [XmlIgnore]
        public bool DigitMapSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallType _callType;

        [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18582")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallType CallType
        {
            get => _callType;
            set
            {
                CallTypeSpecified = true;
                _callType = value;
            }
        }

        [XmlIgnore]
        public bool CallTypeSpecified { get; set; }

    }
}
