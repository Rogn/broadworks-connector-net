using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system level SIP authentication password rule settings
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15509""}]")]
    public class SystemSIPAuthenticationPasswordRulesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _disallowAuthenticationName;

        [XmlElement(ElementName = "disallowAuthenticationName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public bool DisallowAuthenticationName
        {
            get => _disallowAuthenticationName;
            set
            {
                DisallowAuthenticationNameSpecified = true;
                _disallowAuthenticationName = value;
            }
        }

        [XmlIgnore]
        public bool DisallowAuthenticationNameSpecified { get; set; }

        private bool _disallowOldPassword;

        [XmlElement(ElementName = "disallowOldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public bool DisallowOldPassword
        {
            get => _disallowOldPassword;
            set
            {
                DisallowOldPasswordSpecified = true;
                _disallowOldPassword = value;
            }
        }

        [XmlIgnore]
        public bool DisallowOldPasswordSpecified { get; set; }

        private bool _disallowReversedOldPassword;

        [XmlElement(ElementName = "disallowReversedOldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public bool DisallowReversedOldPassword
        {
            get => _disallowReversedOldPassword;
            set
            {
                DisallowReversedOldPasswordSpecified = true;
                _disallowReversedOldPassword = value;
            }
        }

        [XmlIgnore]
        public bool DisallowReversedOldPasswordSpecified { get; set; }

        private bool _restrictMinDigits;

        [XmlElement(ElementName = "restrictMinDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public bool RestrictMinDigits
        {
            get => _restrictMinDigits;
            set
            {
                RestrictMinDigitsSpecified = true;
                _restrictMinDigits = value;
            }
        }

        [XmlIgnore]
        public bool RestrictMinDigitsSpecified { get; set; }

        private int _minDigits;

        [XmlElement(ElementName = "minDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MinDigits
        {
            get => _minDigits;
            set
            {
                MinDigitsSpecified = true;
                _minDigits = value;
            }
        }

        [XmlIgnore]
        public bool MinDigitsSpecified { get; set; }

        private bool _restrictMinUpperCaseLetters;

        [XmlElement(ElementName = "restrictMinUpperCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public bool RestrictMinUpperCaseLetters
        {
            get => _restrictMinUpperCaseLetters;
            set
            {
                RestrictMinUpperCaseLettersSpecified = true;
                _restrictMinUpperCaseLetters = value;
            }
        }

        [XmlIgnore]
        public bool RestrictMinUpperCaseLettersSpecified { get; set; }

        private int _minUpperCaseLetters;

        [XmlElement(ElementName = "minUpperCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MinUpperCaseLetters
        {
            get => _minUpperCaseLetters;
            set
            {
                MinUpperCaseLettersSpecified = true;
                _minUpperCaseLetters = value;
            }
        }

        [XmlIgnore]
        public bool MinUpperCaseLettersSpecified { get; set; }

        private bool _restrictMinLowerCaseLetters;

        [XmlElement(ElementName = "restrictMinLowerCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public bool RestrictMinLowerCaseLetters
        {
            get => _restrictMinLowerCaseLetters;
            set
            {
                RestrictMinLowerCaseLettersSpecified = true;
                _restrictMinLowerCaseLetters = value;
            }
        }

        [XmlIgnore]
        public bool RestrictMinLowerCaseLettersSpecified { get; set; }

        private int _minLowerCaseLetters;

        [XmlElement(ElementName = "minLowerCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MinLowerCaseLetters
        {
            get => _minLowerCaseLetters;
            set
            {
                MinLowerCaseLettersSpecified = true;
                _minLowerCaseLetters = value;
            }
        }

        [XmlIgnore]
        public bool MinLowerCaseLettersSpecified { get; set; }

        private bool _restrictMinNonAlphanumericCharacters;

        [XmlElement(ElementName = "restrictMinNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public bool RestrictMinNonAlphanumericCharacters
        {
            get => _restrictMinNonAlphanumericCharacters;
            set
            {
                RestrictMinNonAlphanumericCharactersSpecified = true;
                _restrictMinNonAlphanumericCharacters = value;
            }
        }

        [XmlIgnore]
        public bool RestrictMinNonAlphanumericCharactersSpecified { get; set; }

        private int _minNonAlphanumericCharacters;

        [XmlElement(ElementName = "minNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MinNonAlphanumericCharacters
        {
            get => _minNonAlphanumericCharacters;
            set
            {
                MinNonAlphanumericCharactersSpecified = true;
                _minNonAlphanumericCharacters = value;
            }
        }

        [XmlIgnore]
        public bool MinNonAlphanumericCharactersSpecified { get; set; }

        private int _minLength;

        [XmlElement(ElementName = "minLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        [MinInclusive(3)]
        [MaxInclusive(40)]
        public int MinLength
        {
            get => _minLength;
            set
            {
                MinLengthSpecified = true;
                _minLength = value;
            }
        }

        [XmlIgnore]
        public bool MinLengthSpecified { get; set; }

        private bool _sendPermanentLockoutNotification;

        [XmlElement(ElementName = "sendPermanentLockoutNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public bool SendPermanentLockoutNotification
        {
            get => _sendPermanentLockoutNotification;
            set
            {
                SendPermanentLockoutNotificationSpecified = true;
                _sendPermanentLockoutNotification = value;
            }
        }

        [XmlIgnore]
        public bool SendPermanentLockoutNotificationSpecified { get; set; }

        private string _permanentLockoutNotifyEmailAddress;

        [XmlElement(ElementName = "permanentLockoutNotifyEmailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PermanentLockoutNotifyEmailAddress
        {
            get => _permanentLockoutNotifyEmailAddress;
            set
            {
                PermanentLockoutNotifyEmailAddressSpecified = true;
                _permanentLockoutNotifyEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool PermanentLockoutNotifyEmailAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AuthenticationLockoutType _endpointAuthenticationLockoutType;

        [XmlElement(ElementName = "endpointAuthenticationLockoutType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutType EndpointAuthenticationLockoutType
        {
            get => _endpointAuthenticationLockoutType;
            set
            {
                EndpointAuthenticationLockoutTypeSpecified = true;
                _endpointAuthenticationLockoutType = value;
            }
        }

        [XmlIgnore]
        public bool EndpointAuthenticationLockoutTypeSpecified { get; set; }

        private int _endpointTemporaryLockoutThreshold;

        [XmlElement(ElementName = "endpointTemporaryLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int EndpointTemporaryLockoutThreshold
        {
            get => _endpointTemporaryLockoutThreshold;
            set
            {
                EndpointTemporaryLockoutThresholdSpecified = true;
                _endpointTemporaryLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        public bool EndpointTemporaryLockoutThresholdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType _endpointWaitAlgorithm;

        [XmlElement(ElementName = "endpointWaitAlgorithm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType EndpointWaitAlgorithm
        {
            get => _endpointWaitAlgorithm;
            set
            {
                EndpointWaitAlgorithmSpecified = true;
                _endpointWaitAlgorithm = value;
            }
        }

        [XmlIgnore]
        public bool EndpointWaitAlgorithmSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes _endpointLockoutFixedMinutes;

        [XmlElement(ElementName = "endpointLockoutFixedMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes EndpointLockoutFixedMinutes
        {
            get => _endpointLockoutFixedMinutes;
            set
            {
                EndpointLockoutFixedMinutesSpecified = true;
                _endpointLockoutFixedMinutes = value;
            }
        }

        [XmlIgnore]
        public bool EndpointLockoutFixedMinutesSpecified { get; set; }

        private int _endpointPermanentLockoutThreshold;

        [XmlElement(ElementName = "endpointPermanentLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        [MinInclusive(2)]
        [MaxInclusive(10)]
        public int EndpointPermanentLockoutThreshold
        {
            get => _endpointPermanentLockoutThreshold;
            set
            {
                EndpointPermanentLockoutThresholdSpecified = true;
                _endpointPermanentLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        public bool EndpointPermanentLockoutThresholdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AuthenticationLockoutType _trunkGroupAuthenticationLockoutType;

        [XmlElement(ElementName = "trunkGroupAuthenticationLockoutType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutType TrunkGroupAuthenticationLockoutType
        {
            get => _trunkGroupAuthenticationLockoutType;
            set
            {
                TrunkGroupAuthenticationLockoutTypeSpecified = true;
                _trunkGroupAuthenticationLockoutType = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupAuthenticationLockoutTypeSpecified { get; set; }

        private int _trunkGroupTemporaryLockoutThreshold;

        [XmlElement(ElementName = "trunkGroupTemporaryLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int TrunkGroupTemporaryLockoutThreshold
        {
            get => _trunkGroupTemporaryLockoutThreshold;
            set
            {
                TrunkGroupTemporaryLockoutThresholdSpecified = true;
                _trunkGroupTemporaryLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupTemporaryLockoutThresholdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType _trunkGroupWaitAlgorithm;

        [XmlElement(ElementName = "trunkGroupWaitAlgorithm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType TrunkGroupWaitAlgorithm
        {
            get => _trunkGroupWaitAlgorithm;
            set
            {
                TrunkGroupWaitAlgorithmSpecified = true;
                _trunkGroupWaitAlgorithm = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupWaitAlgorithmSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes _trunkGroupLockoutFixedMinutes;

        [XmlElement(ElementName = "trunkGroupLockoutFixedMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes TrunkGroupLockoutFixedMinutes
        {
            get => _trunkGroupLockoutFixedMinutes;
            set
            {
                TrunkGroupLockoutFixedMinutesSpecified = true;
                _trunkGroupLockoutFixedMinutes = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupLockoutFixedMinutesSpecified { get; set; }

        private int _trunkGroupPermanentLockoutThreshold;

        [XmlElement(ElementName = "trunkGroupPermanentLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15509")]
        [MinInclusive(2)]
        [MaxInclusive(10)]
        public int TrunkGroupPermanentLockoutThreshold
        {
            get => _trunkGroupPermanentLockoutThreshold;
            set
            {
                TrunkGroupPermanentLockoutThresholdSpecified = true;
                _trunkGroupPermanentLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupPermanentLockoutThresholdSpecified { get; set; }

    }
}
