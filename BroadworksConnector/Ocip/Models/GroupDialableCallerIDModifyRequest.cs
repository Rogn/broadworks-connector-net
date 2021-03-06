using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the group's Dialable Caller ID settings and criteria list.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:3797""}]")]
    public class GroupDialableCallerIDModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3797")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3797")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private bool _useGroupCriteria;

        [XmlElement(ElementName = "useGroupCriteria", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3797")]
        public bool UseGroupCriteria
        {
            get => _useGroupCriteria;
            set
            {
                UseGroupCriteriaSpecified = true;
                _useGroupCriteria = value;
            }
        }

        [XmlIgnore]
        protected bool UseGroupCriteriaSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.NsScreeningFailurePolicy _nsScreeningFailurePolicy;

        [XmlElement(ElementName = "nsScreeningFailurePolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3797")]
        public BroadWorksConnector.Ocip.Models.NsScreeningFailurePolicy NsScreeningFailurePolicy
        {
            get => _nsScreeningFailurePolicy;
            set
            {
                NsScreeningFailurePolicySpecified = true;
                _nsScreeningFailurePolicy = value;
            }
        }

        [XmlIgnore]
        protected bool NsScreeningFailurePolicySpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder> _criteriaPriorityOrder = new List<BroadWorksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder>();

        [XmlElement(ElementName = "criteriaPriorityOrder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3797")]
        public List<BroadWorksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder> CriteriaPriorityOrder
        {
            get => _criteriaPriorityOrder;
            set
            {
                CriteriaPriorityOrderSpecified = true;
                _criteriaPriorityOrder = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaPriorityOrderSpecified { get; set; }

    }
}
