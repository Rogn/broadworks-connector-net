using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replace the list of services and packs used to select which users will be migrated.
    /// Modification is only allowed prior to task execution.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5713""}]")]
    public class ServiceProviderServicePackMigrationTaskModifyUserSelectionRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5713")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _taskName;

        [XmlElement(ElementName = "taskName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5713")]
        [MinLength(1)]
        [MaxLength(80)]
        public string TaskName
        {
            get => _taskName;
            set
            {
                TaskNameSpecified = true;
                _taskName = value;
            }
        }

        [XmlIgnore]
        public bool TaskNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServicePackMigrationTaskUserSelectionType _userSelectionType;

        [XmlElement(ElementName = "userSelectionType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5713")]
        public BroadWorksConnector.Ocip.Models.ServicePackMigrationTaskUserSelectionType UserSelectionType
        {
            get => _userSelectionType;
            set
            {
                UserSelectionTypeSpecified = true;
                _userSelectionType = value;
            }
        }

        [XmlIgnore]
        public bool UserSelectionTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementUserServiceList _userServiceNameList;

        [XmlElement(ElementName = "userServiceNameList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5713")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserServiceList UserServiceNameList
        {
            get => _userServiceNameList;
            set
            {
                UserServiceNameListSpecified = true;
                _userServiceNameList = value;
            }
        }

        [XmlIgnore]
        public bool UserServiceNameListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementServicePackNameList _servicePackNameList;

        [XmlElement(ElementName = "servicePackNameList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5713")]
        public BroadWorksConnector.Ocip.Models.ReplacementServicePackNameList ServicePackNameList
        {
            get => _servicePackNameList;
            set
            {
                ServicePackNameListSpecified = true;
                _servicePackNameList = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackNameListSpecified { get; set; }

    }
}
