using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a criteria from the Find-me/Follow-me alerting group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""79f226053ee345f2ff4c37c37c8e9114:185""}]")]
    public class GroupFindMeFollowMeDeleteAlertingGroupSelectiveCriteriaRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:185")]
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
        protected bool ServiceUserIdSpecified { get; set; }

        private string _alertingGroupName;

        [XmlElement(ElementName = "alertingGroupName", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:185")]
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
        protected bool AlertingGroupNameSpecified { get; set; }

        private string _criteriaName;

        [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:185")]
        [MinLength(1)]
        [MaxLength(50)]
        public string CriteriaName
        {
            get => _criteriaName;
            set
            {
                CriteriaNameSpecified = true;
                _criteriaName = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaNameSpecified { get; set; }

    }
}
