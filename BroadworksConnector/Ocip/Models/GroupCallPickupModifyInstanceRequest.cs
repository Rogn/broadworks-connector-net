using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies a Call Pickup group. Replaces the entire list of users in the group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""045ce951b3e25dec090606af4ad50c63:355""}]")]
    public class GroupCallPickupModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"045ce951b3e25dec090606af4ad50c63:355")]
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
        [Group(@"045ce951b3e25dec090606af4ad50c63:355")]
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

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"045ce951b3e25dec090606af4ad50c63:355")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private string _newName;

        [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"045ce951b3e25dec090606af4ad50c63:355")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NewName
        {
            get => _newName;
            set
            {
                NewNameSpecified = true;
                _newName = value;
            }
        }

        [XmlIgnore]
        protected bool NewNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _userIdList;

        [XmlElement(ElementName = "userIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"045ce951b3e25dec090606af4ad50c63:355")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList UserIdList
        {
            get => _userIdList;
            set
            {
                UserIdListSpecified = true;
                _userIdList = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdListSpecified { get; set; }

    }
}
