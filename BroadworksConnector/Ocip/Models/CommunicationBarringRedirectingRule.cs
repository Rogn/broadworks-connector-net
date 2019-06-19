using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Communication Barring Redirecting Rule
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1426""}]")]
    public class CommunicationBarringRedirectingRule
    {

        private string _criteria;

        [XmlElement(ElementName = "criteria", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1426")]
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
        public bool CriteriaSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1426")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringRedirectingAction Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        public bool ActionSpecified { get; set; }

        private int? _callTimeoutSeconds;

        [XmlElement(ElementName = "callTimeoutSeconds", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1426")]
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
        public bool CallTimeoutSecondsSpecified { get; set; }

    }
}
