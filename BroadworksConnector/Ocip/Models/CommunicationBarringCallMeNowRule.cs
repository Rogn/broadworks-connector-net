using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Communication Barring Call Me Now Rule
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1351""}]")]
    public class CommunicationBarringCallMeNowRule
    {

        private string _criteria;

        [XmlElement(ElementName = "criteria", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1351")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Criteria
        {
            get => _criteria;
            set
            {
                CriteriaSpecified = true;
                _criteria = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1351")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowAction Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        protected bool ActionSpecified { get; set; }

        private int? _callTimeoutSeconds;

        [XmlElement(ElementName = "callTimeoutSeconds", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1351")]
        [MinInclusive(60)]
        [MaxInclusive(86400)]
        public int? CallTimeoutSeconds
        {
            get => _callTimeoutSeconds;
            set
            {
                CallTimeoutSecondsSpecified = true;
                _callTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool CallTimeoutSecondsSpecified { get; set; }

    }
}
