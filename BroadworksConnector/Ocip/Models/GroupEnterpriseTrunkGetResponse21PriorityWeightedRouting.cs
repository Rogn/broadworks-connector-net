using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:733""}]")]
    public class GroupEnterpriseTrunkGetResponse21PriorityWeightedRouting
    {

        private List<BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup> _priorityWeightedTrunkGroup = new List<BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup>();

        [XmlElement(ElementName = "priorityWeightedTrunkGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:733")]
        public List<BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup> PriorityWeightedTrunkGroup
        {
            get => _priorityWeightedTrunkGroup;
            set
            {
                PriorityWeightedTrunkGroupSpecified = true;
                _priorityWeightedTrunkGroup = value;
            }
        }

        [XmlIgnore]
        public bool PriorityWeightedTrunkGroupSpecified { get; set; }

        private int _maximumRerouteAttemptsWithinPriority;

        [XmlElement(ElementName = "maximumRerouteAttemptsWithinPriority", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:733")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MaximumRerouteAttemptsWithinPriority
        {
            get => _maximumRerouteAttemptsWithinPriority;
            set
            {
                MaximumRerouteAttemptsWithinPrioritySpecified = true;
                _maximumRerouteAttemptsWithinPriority = value;
            }
        }

        [XmlIgnore]
        public bool MaximumRerouteAttemptsWithinPrioritySpecified { get; set; }

    }
}
