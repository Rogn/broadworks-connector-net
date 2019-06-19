using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the service provider level device profile authentication password rule settings. The useServiceProviderSettings element can only be modified by a system administrator or a provisioning administrator.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2425""}]")]
    public class ServiceProviderDeviceProfileAuthenticationPasswordRulesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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

        private bool _useServiceProviderSettings;

        [XmlElement(ElementName = "useServiceProviderSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
        public bool UseServiceProviderSettings
        {
            get => _useServiceProviderSettings;
            set
            {
                UseServiceProviderSettingsSpecified = true;
                _useServiceProviderSettings = value;
            }
        }

        [XmlIgnore]
        public bool UseServiceProviderSettingsSpecified { get; set; }

        private bool _disallowAuthenticationName;

        [XmlElement(ElementName = "disallowAuthenticationName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
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

        private BroadWorksConnector.Ocip.Models.AuthenticationLockoutType _deviceProfileAuthenticationLockoutType;

        [XmlElement(ElementName = "deviceProfileAuthenticationLockoutType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutType DeviceProfileAuthenticationLockoutType
        {
            get => _deviceProfileAuthenticationLockoutType;
            set
            {
                DeviceProfileAuthenticationLockoutTypeSpecified = true;
                _deviceProfileAuthenticationLockoutType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceProfileAuthenticationLockoutTypeSpecified { get; set; }

        private int _deviceProfileTemporaryLockoutThreshold;

        [XmlElement(ElementName = "deviceProfileTemporaryLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int DeviceProfileTemporaryLockoutThreshold
        {
            get => _deviceProfileTemporaryLockoutThreshold;
            set
            {
                DeviceProfileTemporaryLockoutThresholdSpecified = true;
                _deviceProfileTemporaryLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        public bool DeviceProfileTemporaryLockoutThresholdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType _deviceProfileWaitAlgorithm;

        [XmlElement(ElementName = "deviceProfileWaitAlgorithm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType DeviceProfileWaitAlgorithm
        {
            get => _deviceProfileWaitAlgorithm;
            set
            {
                DeviceProfileWaitAlgorithmSpecified = true;
                _deviceProfileWaitAlgorithm = value;
            }
        }

        [XmlIgnore]
        public bool DeviceProfileWaitAlgorithmSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes _deviceProfileLockoutFixedMinutes;

        [XmlElement(ElementName = "deviceProfileLockoutFixedMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
        public BroadWorksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes DeviceProfileLockoutFixedMinutes
        {
            get => _deviceProfileLockoutFixedMinutes;
            set
            {
                DeviceProfileLockoutFixedMinutesSpecified = true;
                _deviceProfileLockoutFixedMinutes = value;
            }
        }

        [XmlIgnore]
        public bool DeviceProfileLockoutFixedMinutesSpecified { get; set; }

        private int _deviceProfilePermanentLockoutThreshold;

        [XmlElement(ElementName = "deviceProfilePermanentLockoutThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2425")]
        [MinInclusive(2)]
        [MaxInclusive(10)]
        public int DeviceProfilePermanentLockoutThreshold
        {
            get => _deviceProfilePermanentLockoutThreshold;
            set
            {
                DeviceProfilePermanentLockoutThresholdSpecified = true;
                _deviceProfilePermanentLockoutThreshold = value;
            }
        }

        [XmlIgnore]
        public bool DeviceProfilePermanentLockoutThresholdSpecified { get; set; }

    }
}
