using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The system-level collaborate supportOutdial setting is returned in the response when the system-level collaborate supportOutdial setting is disabled.
    /// Response to UserCollaborateBridgeGetRequest20sp1.
    /// <see cref="UserCollaborateBridgeGetRequest20sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:591""}]")]
    public class UserCollaborateBridgeGetResponse20sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _bridgeId;

        [XmlElement(ElementName = "bridgeId", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:591")]
        [MinLength(1)]
        [MaxLength(161)]
        public string BridgeId
        {
            get => _bridgeId;
            set
            {
                BridgeIdSpecified = true;
                _bridgeId = value;
            }
        }

        [XmlIgnore]
        public bool BridgeIdSpecified { get; set; }

        private string _bridgeName;

        [XmlElement(ElementName = "bridgeName", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:591")]
        [MinLength(1)]
        [MaxLength(40)]
        public string BridgeName
        {
            get => _bridgeName;
            set
            {
                BridgeNameSpecified = true;
                _bridgeName = value;
            }
        }

        [XmlIgnore]
        public bool BridgeNameSpecified { get; set; }

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:591")]
        [MinLength(1)]
        [MaxLength(23)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }

        private string _extension;

        [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:591")]
        [MinLength(2)]
        [MaxLength(20)]
        public string Extension
        {
            get => _extension;
            set
            {
                ExtensionSpecified = true;
                _extension = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.AlternateNumberEntry21> _alternateNumberEntry = new List<BroadWorksConnector.Ocip.Models.AlternateNumberEntry21>();

        [XmlElement(ElementName = "alternateNumberEntry", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:591")]
        public List<BroadWorksConnector.Ocip.Models.AlternateNumberEntry21> AlternateNumberEntry
        {
            get => _alternateNumberEntry;
            set
            {
                AlternateNumberEntrySpecified = true;
                _alternateNumberEntry = value;
            }
        }

        [XmlIgnore]
        public bool AlternateNumberEntrySpecified { get; set; }

        private bool _supportOutDial;

        [XmlElement(ElementName = "supportOutDial", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:591")]
        public bool SupportOutDial
        {
            get => _supportOutDial;
            set
            {
                SupportOutDialSpecified = true;
                _supportOutDial = value;
            }
        }

        [XmlIgnore]
        public bool SupportOutDialSpecified { get; set; }

        private int _maxCollaborateRoomParticipants;

        [XmlElement(ElementName = "maxCollaborateRoomParticipants", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:591")]
        [MinInclusive(3)]
        [MaxInclusive(145)]
        public int MaxCollaborateRoomParticipants
        {
            get => _maxCollaborateRoomParticipants;
            set
            {
                MaxCollaborateRoomParticipantsSpecified = true;
                _maxCollaborateRoomParticipants = value;
            }
        }

        [XmlIgnore]
        public bool MaxCollaborateRoomParticipantsSpecified { get; set; }

    }
}
