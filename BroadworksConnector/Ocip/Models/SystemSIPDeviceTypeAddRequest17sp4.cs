using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a sip device type.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Replaced by: SystemSIPDeviceTypeAddRequest18
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSIPDeviceTypeAddRequest18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:22272""}]")]
    public class SystemSIPDeviceTypeAddRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceType
        {
            get => _deviceType;
            set
            {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _numberOfPorts;

        [XmlElement(ElementName = "numberOfPorts", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt NumberOfPorts
        {
            get => _numberOfPorts;
            set
            {
                NumberOfPortsSpecified = true;
                _numberOfPorts = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfPortsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SignalingAddressType _profile;

        [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public BroadWorksConnector.Ocip.Models.SignalingAddressType Profile
        {
            get => _profile;
            set
            {
                ProfileSpecified = true;
                _profile = value;
            }
        }

        [XmlIgnore]
        public bool ProfileSpecified { get; set; }

        private bool _registrationCapable;

        [XmlElement(ElementName = "registrationCapable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool RegistrationCapable
        {
            get => _registrationCapable;
            set
            {
                RegistrationCapableSpecified = true;
                _registrationCapable = value;
            }
        }

        [XmlIgnore]
        public bool RegistrationCapableSpecified { get; set; }

        private bool _isConferenceDevice;

        [XmlElement(ElementName = "isConferenceDevice", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool IsConferenceDevice
        {
            get => _isConferenceDevice;
            set
            {
                IsConferenceDeviceSpecified = true;
                _isConferenceDevice = value;
            }
        }

        [XmlIgnore]
        public bool IsConferenceDeviceSpecified { get; set; }

        private bool _isMobilityManagerDevice;

        [XmlElement(ElementName = "isMobilityManagerDevice", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool IsMobilityManagerDevice
        {
            get => _isMobilityManagerDevice;
            set
            {
                IsMobilityManagerDeviceSpecified = true;
                _isMobilityManagerDevice = value;
            }
        }

        [XmlIgnore]
        public bool IsMobilityManagerDeviceSpecified { get; set; }

        private bool _isMusicOnHoldDevice;

        [XmlElement(ElementName = "isMusicOnHoldDevice", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool IsMusicOnHoldDevice
        {
            get => _isMusicOnHoldDevice;
            set
            {
                IsMusicOnHoldDeviceSpecified = true;
                _isMusicOnHoldDevice = value;
            }
        }

        [XmlIgnore]
        public bool IsMusicOnHoldDeviceSpecified { get; set; }

        private bool _rFC3264Hold;

        [XmlElement(ElementName = "RFC3264Hold", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool RFC3264Hold
        {
            get => _rFC3264Hold;
            set
            {
                RFC3264HoldSpecified = true;
                _rFC3264Hold = value;
            }
        }

        [XmlIgnore]
        public bool RFC3264HoldSpecified { get; set; }

        private bool _isTrusted;

        [XmlElement(ElementName = "isTrusted", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool IsTrusted
        {
            get => _isTrusted;
            set
            {
                IsTrustedSpecified = true;
                _isTrusted = value;
            }
        }

        [XmlIgnore]
        public bool IsTrustedSpecified { get; set; }

        private bool _e164Capable;

        [XmlElement(ElementName = "E164Capable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool E164Capable
        {
            get => _e164Capable;
            set
            {
                E164CapableSpecified = true;
                _e164Capable = value;
            }
        }

        [XmlIgnore]
        public bool E164CapableSpecified { get; set; }

        private bool _routeAdvance;

        [XmlElement(ElementName = "routeAdvance", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool RouteAdvance
        {
            get => _routeAdvance;
            set
            {
                RouteAdvanceSpecified = true;
                _routeAdvance = value;
            }
        }

        [XmlIgnore]
        public bool RouteAdvanceSpecified { get; set; }

        private bool _forwardingOverride;

        [XmlElement(ElementName = "forwardingOverride", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool ForwardingOverride
        {
            get => _forwardingOverride;
            set
            {
                ForwardingOverrideSpecified = true;
                _forwardingOverride = value;
            }
        }

        [XmlIgnore]
        public bool ForwardingOverrideSpecified { get; set; }

        private bool _wirelessIntegration;

        [XmlElement(ElementName = "wirelessIntegration", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool WirelessIntegration
        {
            get => _wirelessIntegration;
            set
            {
                WirelessIntegrationSpecified = true;
                _wirelessIntegration = value;
            }
        }

        [XmlIgnore]
        public bool WirelessIntegrationSpecified { get; set; }

        private string _webBasedConfigURL;

        [XmlElement(ElementName = "webBasedConfigURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        [MinLength(1)]
        [MaxLength(80)]
        public string WebBasedConfigURL
        {
            get => _webBasedConfigURL;
            set
            {
                WebBasedConfigURLSpecified = true;
                _webBasedConfigURL = value;
            }
        }

        [XmlIgnore]
        public bool WebBasedConfigURLSpecified { get; set; }

        private bool _isVideoCapable;

        [XmlElement(ElementName = "isVideoCapable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool IsVideoCapable
        {
            get => _isVideoCapable;
            set
            {
                IsVideoCapableSpecified = true;
                _isVideoCapable = value;
            }
        }

        [XmlIgnore]
        public bool IsVideoCapableSpecified { get; set; }

        private bool _pBXIntegration;

        [XmlElement(ElementName = "PBXIntegration", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool PBXIntegration
        {
            get => _pBXIntegration;
            set
            {
                PBXIntegrationSpecified = true;
                _pBXIntegration = value;
            }
        }

        [XmlIgnore]
        public bool PBXIntegrationSpecified { get; set; }

        private bool _staticRegistrationCapable;

        [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool StaticRegistrationCapable
        {
            get => _staticRegistrationCapable;
            set
            {
                StaticRegistrationCapableSpecified = true;
                _staticRegistrationCapable = value;
            }
        }

        [XmlIgnore]
        public bool StaticRegistrationCapableSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CPEDeviceOptions16sp1 _cpeDeviceOptions;

        [XmlElement(ElementName = "cpeDeviceOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public BroadWorksConnector.Ocip.Models.CPEDeviceOptions16sp1 CpeDeviceOptions
        {
            get => _cpeDeviceOptions;
            set
            {
                CpeDeviceOptionsSpecified = true;
                _cpeDeviceOptions = value;
            }
        }

        [XmlIgnore]
        public bool CpeDeviceOptionsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EarlyMediaSupportType _earlyMediaSupport;

        [XmlElement(ElementName = "earlyMediaSupport", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public BroadWorksConnector.Ocip.Models.EarlyMediaSupportType EarlyMediaSupport
        {
            get => _earlyMediaSupport;
            set
            {
                EarlyMediaSupportSpecified = true;
                _earlyMediaSupport = value;
            }
        }

        [XmlIgnore]
        public bool EarlyMediaSupportSpecified { get; set; }

        private bool _authenticateRefer;

        [XmlElement(ElementName = "authenticateRefer", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool AuthenticateRefer
        {
            get => _authenticateRefer;
            set
            {
                AuthenticateReferSpecified = true;
                _authenticateRefer = value;
            }
        }

        [XmlIgnore]
        public bool AuthenticateReferSpecified { get; set; }

        private bool _autoConfigSoftClient;

        [XmlElement(ElementName = "autoConfigSoftClient", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool AutoConfigSoftClient
        {
            get => _autoConfigSoftClient;
            set
            {
                AutoConfigSoftClientSpecified = true;
                _autoConfigSoftClient = value;
            }
        }

        [XmlIgnore]
        public bool AutoConfigSoftClientSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AuthenticationMode _authenticationMode;

        [XmlElement(ElementName = "authenticationMode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public BroadWorksConnector.Ocip.Models.AuthenticationMode AuthenticationMode
        {
            get => _authenticationMode;
            set
            {
                AuthenticationModeSpecified = true;
                _authenticationMode = value;
            }
        }

        [XmlIgnore]
        public bool AuthenticationModeSpecified { get; set; }

        private bool _requiresBroadWorksDigitCollection;

        [XmlElement(ElementName = "requiresBroadWorksDigitCollection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool RequiresBroadWorksDigitCollection
        {
            get => _requiresBroadWorksDigitCollection;
            set
            {
                RequiresBroadWorksDigitCollectionSpecified = true;
                _requiresBroadWorksDigitCollection = value;
            }
        }

        [XmlIgnore]
        public bool RequiresBroadWorksDigitCollectionSpecified { get; set; }

        private bool _requiresBroadWorksCallWaitingTone;

        [XmlElement(ElementName = "requiresBroadWorksCallWaitingTone", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool RequiresBroadWorksCallWaitingTone
        {
            get => _requiresBroadWorksCallWaitingTone;
            set
            {
                RequiresBroadWorksCallWaitingToneSpecified = true;
                _requiresBroadWorksCallWaitingTone = value;
            }
        }

        [XmlIgnore]
        public bool RequiresBroadWorksCallWaitingToneSpecified { get; set; }

        private bool _requiresMWISubscription;

        [XmlElement(ElementName = "requiresMWISubscription", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool RequiresMWISubscription
        {
            get => _requiresMWISubscription;
            set
            {
                RequiresMWISubscriptionSpecified = true;
                _requiresMWISubscription = value;
            }
        }

        [XmlIgnore]
        public bool RequiresMWISubscriptionSpecified { get; set; }

        private bool _useHistoryInfoHeaderOnAccessSide;

        [XmlElement(ElementName = "useHistoryInfoHeaderOnAccessSide", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool UseHistoryInfoHeaderOnAccessSide
        {
            get => _useHistoryInfoHeaderOnAccessSide;
            set
            {
                UseHistoryInfoHeaderOnAccessSideSpecified = true;
                _useHistoryInfoHeaderOnAccessSide = value;
            }
        }

        [XmlIgnore]
        public bool UseHistoryInfoHeaderOnAccessSideSpecified { get; set; }

        private bool _adviceOfChargeCapable;

        [XmlElement(ElementName = "adviceOfChargeCapable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool AdviceOfChargeCapable
        {
            get => _adviceOfChargeCapable;
            set
            {
                AdviceOfChargeCapableSpecified = true;
                _adviceOfChargeCapable = value;
            }
        }

        [XmlIgnore]
        public bool AdviceOfChargeCapableSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceResetEvent _resetEvent;

        [XmlElement(ElementName = "resetEvent", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceResetEvent ResetEvent
        {
            get => _resetEvent;
            set
            {
                ResetEventSpecified = true;
                _resetEvent = value;
            }
        }

        [XmlIgnore]
        public bool ResetEventSpecified { get; set; }

        private bool _supportCallCenterMIMEType;

        [XmlElement(ElementName = "supportCallCenterMIMEType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool SupportCallCenterMIMEType
        {
            get => _supportCallCenterMIMEType;
            set
            {
                SupportCallCenterMIMETypeSpecified = true;
                _supportCallCenterMIMEType = value;
            }
        }

        [XmlIgnore]
        public bool SupportCallCenterMIMETypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkMode _trunkMode;

        [XmlElement(ElementName = "trunkMode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public BroadWorksConnector.Ocip.Models.TrunkMode TrunkMode
        {
            get => _trunkMode;
            set
            {
                TrunkModeSpecified = true;
                _trunkMode = value;
            }
        }

        [XmlIgnore]
        public bool TrunkModeSpecified { get; set; }

        private bool _addPCalledPartyId;

        [XmlElement(ElementName = "addPCalledPartyId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool AddPCalledPartyId
        {
            get => _addPCalledPartyId;
            set
            {
                AddPCalledPartyIdSpecified = true;
                _addPCalledPartyId = value;
            }
        }

        [XmlIgnore]
        public bool AddPCalledPartyIdSpecified { get; set; }

        private bool _supportIdentityInUpdateAndReInvite;

        [XmlElement(ElementName = "supportIdentityInUpdateAndReInvite", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public bool SupportIdentityInUpdateAndReInvite
        {
            get => _supportIdentityInUpdateAndReInvite;
            set
            {
                SupportIdentityInUpdateAndReInviteSpecified = true;
                _supportIdentityInUpdateAndReInvite = value;
            }
        }

        [XmlIgnore]
        public bool SupportIdentityInUpdateAndReInviteSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnscreenedPresentationIdentityPolicy _unscreenedPresentationIdentityPolicy;

        [XmlElement(ElementName = "unscreenedPresentationIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:22272")]
        public BroadWorksConnector.Ocip.Models.UnscreenedPresentationIdentityPolicy UnscreenedPresentationIdentityPolicy
        {
            get => _unscreenedPresentationIdentityPolicy;
            set
            {
                UnscreenedPresentationIdentityPolicySpecified = true;
                _unscreenedPresentationIdentityPolicy = value;
            }
        }

        [XmlIgnore]
        public bool UnscreenedPresentationIdentityPolicySpecified { get; set; }

    }
}
