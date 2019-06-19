using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Find-me/Follow-me alerting group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""79f226053ee345f2ff4c37c37c8e9114:444""}]")]
    public class GroupFindMeFollowMeModifyAlertingGroupRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:444")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }

        private string _alertingGroupName;

        [XmlElement(ElementName = "alertingGroupName", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:444")]
        [MinLength(1)]
        [MaxLength(40)]
        public string AlertingGroupName
        {
            get => _alertingGroupName;
            set
            {
                AlertingGroupNameSpecified = true;
                _alertingGroupName = value;
            }
        }

        [XmlIgnore]
        public bool AlertingGroupNameSpecified { get; set; }

        private string _newAlertingGroupName;

        [XmlElement(ElementName = "newAlertingGroupName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:444")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewAlertingGroupName
        {
            get => _newAlertingGroupName;
            set
            {
                NewAlertingGroupNameSpecified = true;
                _newAlertingGroupName = value;
            }
        }

        [XmlIgnore]
        public bool NewAlertingGroupNameSpecified { get; set; }

        private string _alertingGroupDescription;

        [XmlElement(ElementName = "alertingGroupDescription", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:444")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AlertingGroupDescription
        {
            get => _alertingGroupDescription;
            set
            {
                AlertingGroupDescriptionSpecified = true;
                _alertingGroupDescription = value;
            }
        }

        [XmlIgnore]
        public bool AlertingGroupDescriptionSpecified { get; set; }

        private bool _useDiversionInhibitor;

        [XmlElement(ElementName = "useDiversionInhibitor", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:444")]
        public bool UseDiversionInhibitor
        {
            get => _useDiversionInhibitor;
            set
            {
                UseDiversionInhibitorSpecified = true;
                _useDiversionInhibitor = value;
            }
        }

        [XmlIgnore]
        public bool UseDiversionInhibitorSpecified { get; set; }

        private bool _answerConfirmationRequired;

        [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:444")]
        public bool AnswerConfirmationRequired
        {
            get => _answerConfirmationRequired;
            set
            {
                AnswerConfirmationRequiredSpecified = true;
                _answerConfirmationRequired = value;
            }
        }

        [XmlIgnore]
        public bool AnswerConfirmationRequiredSpecified { get; set; }

        private int _numberOfRings;

        [XmlElement(ElementName = "numberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:444")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int NumberOfRings
        {
            get => _numberOfRings;
            set
            {
                NumberOfRingsSpecified = true;
                _numberOfRings = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfRingsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.FindMeFollowMeAlertingGroupReplacementOutgoingDNSIPURIorUserIdList _phoneNumberOrUserList;

        [XmlElement(ElementName = "phoneNumberOrUserList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:444")]
        public BroadWorksConnector.Ocip.Models.FindMeFollowMeAlertingGroupReplacementOutgoingDNSIPURIorUserIdList PhoneNumberOrUserList
        {
            get => _phoneNumberOrUserList;
            set
            {
                PhoneNumberOrUserListSpecified = true;
                _phoneNumberOrUserList = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberOrUserListSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation = new List<BroadWorksConnector.Ocip.Models.CriteriaActivation>();

        [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:444")]
        public List<BroadWorksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation
        {
            get => _criteriaActivation;
            set
            {
                CriteriaActivationSpecified = true;
                _criteriaActivation = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaActivationSpecified { get; set; }

    }
}
