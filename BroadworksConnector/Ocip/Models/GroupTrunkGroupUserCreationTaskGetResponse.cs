using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a GroupTrunkGroupUserCreationTaskGetRequest.
    /// <see cref="GroupTrunkGroupUserCreationTaskGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:3172""}]")]
    public class GroupTrunkGroupUserCreationTaskGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationUserIdFormat _userIdFormat;

        [XmlElement(ElementName = "userIdFormat", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationUserIdFormat UserIdFormat
        {
            get => _userIdFormat;
            set
            {
                UserIdFormatSpecified = true;
                _userIdFormat = value;
            }
        }

        [XmlIgnore]
        public bool UserIdFormatSpecified { get; set; }

        private string _userIdDomain;

        [XmlElement(ElementName = "userIdDomain", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        [MinLength(1)]
        [MaxLength(80)]
        public string UserIdDomain
        {
            get => _userIdDomain;
            set
            {
                UserIdDomainSpecified = true;
                _userIdDomain = value;
            }
        }

        [XmlIgnore]
        public bool UserIdDomainSpecified { get; set; }

        private bool _populateExtension;

        [XmlElement(ElementName = "populateExtension", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        public bool PopulateExtension
        {
            get => _populateExtension;
            set
            {
                PopulateExtensionSpecified = true;
                _populateExtension = value;
            }
        }

        [XmlIgnore]
        public bool PopulateExtensionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat _linePortFormat;

        [XmlElement(ElementName = "linePortFormat", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat LinePortFormat
        {
            get => _linePortFormat;
            set
            {
                LinePortFormatSpecified = true;
                _linePortFormat = value;
            }
        }

        [XmlIgnore]
        public bool LinePortFormatSpecified { get; set; }

        private string _linePortDomain;

        [XmlElement(ElementName = "linePortDomain", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        [MinLength(1)]
        [MaxLength(80)]
        public string LinePortDomain
        {
            get => _linePortDomain;
            set
            {
                LinePortDomainSpecified = true;
                _linePortDomain = value;
            }
        }

        [XmlIgnore]
        public bool LinePortDomainSpecified { get; set; }

        private bool _populateContact;

        [XmlElement(ElementName = "populateContact", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        public bool PopulateContact
        {
            get => _populateContact;
            set
            {
                PopulateContactSpecified = true;
                _populateContact = value;
            }
        }

        [XmlIgnore]
        public bool PopulateContactSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat _contactFormat;

        [XmlElement(ElementName = "contactFormat", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat ContactFormat
        {
            get => _contactFormat;
            set
            {
                ContactFormatSpecified = true;
                _contactFormat = value;
            }
        }

        [XmlIgnore]
        public bool ContactFormatSpecified { get; set; }

        private string _contactDomain;

        [XmlElement(ElementName = "contactDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ContactDomain
        {
            get => _contactDomain;
            set
            {
                ContactDomainSpecified = true;
                _contactDomain = value;
            }
        }

        [XmlIgnore]
        public bool ContactDomainSpecified { get; set; }

        private int _usersCreated;

        [XmlElement(ElementName = "usersCreated", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        public int UsersCreated
        {
            get => _usersCreated;
            set
            {
                UsersCreatedSpecified = true;
                _usersCreated = value;
            }
        }

        [XmlIgnore]
        public bool UsersCreatedSpecified { get; set; }

        private int _totalUsersToCreate;

        [XmlElement(ElementName = "totalUsersToCreate", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        public int TotalUsersToCreate
        {
            get => _totalUsersToCreate;
            set
            {
                TotalUsersToCreateSpecified = true;
                _totalUsersToCreate = value;
            }
        }

        [XmlIgnore]
        public bool TotalUsersToCreateSpecified { get; set; }

        private int _errorCount;

        [XmlElement(ElementName = "errorCount", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        public int ErrorCount
        {
            get => _errorCount;
            set
            {
                ErrorCountSpecified = true;
                _errorCount = value;
            }
        }

        [XmlIgnore]
        public bool ErrorCountSpecified { get; set; }

        private List<string> _servicePackName = new List<string>();

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> ServicePackName
        {
            get => _servicePackName;
            set
            {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.UserService> _userServiceName = new List<BroadWorksConnector.Ocip.Models.UserService>();

        [XmlElement(ElementName = "userServiceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        public List<BroadWorksConnector.Ocip.Models.UserService> UserServiceName
        {
            get => _userServiceName;
            set
            {
                UserServiceNameSpecified = true;
                _userServiceName = value;
            }
        }

        [XmlIgnore]
        public bool UserServiceNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationTaskStatus _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationTaskStatus Status
        {
            get => _status;
            set
            {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        public bool StatusSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationMode _userCreationMode;

        [XmlElement(ElementName = "userCreationMode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationMode UserCreationMode
        {
            get => _userCreationMode;
            set
            {
                UserCreationModeSpecified = true;
                _userCreationMode = value;
            }
        }

        [XmlIgnore]
        public bool UserCreationModeSpecified { get; set; }

        private string _taskSummary;

        [XmlElement(ElementName = "taskSummary", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:3172")]
        public string TaskSummary
        {
            get => _taskSummary;
            set
            {
                TaskSummarySpecified = true;
                _taskSummary = value;
            }
        }

        [XmlIgnore]
        public bool TaskSummarySpecified { get; set; }

    }
}
