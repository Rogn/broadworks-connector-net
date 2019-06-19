using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a sip device type.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// The following elements are not changeable:
    /// numberOfPorts
    /// SignalingAddressType
    /// isConferenceDevice
    /// isMusicOnHoldDevice
    /// isMobilityManagerDevice
    /// deviceTypeConfigurationOption
    /// staticLineOrdering
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// supportClientSessionInfo
    /// supportCallInfoConferenceSubscriptionURI
    /// supportRemotePartyInfo
    /// supportVisualDeviceManagement
    /// bypassMediaTreatment
    /// supportCauseParameter
    /// 
    /// The following elements are only used in XS data mode and ignored in AS mode:
    /// enhancedForICS
    /// supports3G4GContinuity
    /// publishesOwnPresence
    /// locationNetwork
    /// allowTerminationBasedOnICSI
    /// roamingMode
    /// 
    /// The following logic applies to these elements:
    /// macInCert
    /// macInNonRequestURI
    /// The two elements are mutually exclusive.
    /// When both are set to true, the command fails.
    /// When macInCert is set to true, macInNonRequestURI will be reset to false.
    /// When macInNonRequestURI is set to true, macInCert will be reset to false.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="macInNonRequest"/>
    /// <see cref="macInNonRequest"/>
    /// <see cref="macInNonRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16384""}]")]
    public class SystemSIPDeviceTypeModifyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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

        private bool _isObsolete;

        [XmlElement(ElementName = "isObsolete", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool IsObsolete
        {
            get => _isObsolete;
            set
            {
                IsObsoleteSpecified = true;
                _isObsolete = value;
            }
        }

        [XmlIgnore]
        public bool IsObsoleteSpecified { get; set; }

        private bool _registrationCapable;

        [XmlElement(ElementName = "registrationCapable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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

        private BroadWorksConnector.Ocip.Models.HoldNormalizationMode _holdNormalization;

        [XmlElement(ElementName = "holdNormalization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public BroadWorksConnector.Ocip.Models.HoldNormalizationMode HoldNormalization
        {
            get => _holdNormalization;
            set
            {
                HoldNormalizationSpecified = true;
                _holdNormalization = value;
            }
        }

        [XmlIgnore]
        public bool HoldNormalizationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HoldAnnouncementMethodMode _holdAnnouncementMethod;

        [XmlElement(ElementName = "holdAnnouncementMethod", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public BroadWorksConnector.Ocip.Models.HoldAnnouncementMethodMode HoldAnnouncementMethod
        {
            get => _holdAnnouncementMethod;
            set
            {
                HoldAnnouncementMethodSpecified = true;
                _holdAnnouncementMethod = value;
            }
        }

        [XmlIgnore]
        public bool HoldAnnouncementMethodSpecified { get; set; }

        private bool _isTrusted;

        [XmlElement(ElementName = "isTrusted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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

        [XmlElement(ElementName = "webBasedConfigURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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

        private BroadWorksConnector.Ocip.Models.CPEDeviceModifyOptions16sp1 _cpeDeviceOptions;

        [XmlElement(ElementName = "cpeDeviceOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public BroadWorksConnector.Ocip.Models.CPEDeviceModifyOptions16sp1 CpeDeviceOptions
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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

        private BroadWorksConnector.Ocip.Models.AuthenticationMode22 _authenticationMode;

        [XmlElement(ElementName = "authenticationMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public BroadWorksConnector.Ocip.Models.AuthenticationMode22 AuthenticationMode
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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

        private BroadWorksConnector.Ocip.Models.AccessDeviceResetEvent? _resetEvent;

        [XmlElement(ElementName = "resetEvent", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceResetEvent? ResetEvent
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
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

        private bool _enhancedForICS;

        [XmlElement(ElementName = "enhancedForICS", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool EnhancedForICS
        {
            get => _enhancedForICS;
            set
            {
                EnhancedForICSSpecified = true;
                _enhancedForICS = value;
            }
        }

        [XmlIgnore]
        public bool EnhancedForICSSpecified { get; set; }

        private bool _supportEmergencyDisconnectControl;

        [XmlElement(ElementName = "supportEmergencyDisconnectControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool SupportEmergencyDisconnectControl
        {
            get => _supportEmergencyDisconnectControl;
            set
            {
                SupportEmergencyDisconnectControlSpecified = true;
                _supportEmergencyDisconnectControl = value;
            }
        }

        [XmlIgnore]
        public bool SupportEmergencyDisconnectControlSpecified { get; set; }

        private bool _supportRFC3398;

        [XmlElement(ElementName = "supportRFC3398", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool SupportRFC3398
        {
            get => _supportRFC3398;
            set
            {
                SupportRFC3398Specified = true;
                _supportRFC3398 = value;
            }
        }

        [XmlIgnore]
        public bool SupportRFC3398Specified { get; set; }

        private bool _supportClientSessionInfo;

        [XmlElement(ElementName = "supportClientSessionInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool SupportClientSessionInfo
        {
            get => _supportClientSessionInfo;
            set
            {
                SupportClientSessionInfoSpecified = true;
                _supportClientSessionInfo = value;
            }
        }

        [XmlIgnore]
        public bool SupportClientSessionInfoSpecified { get; set; }

        private bool _supportCallInfoConferenceSubscriptionURI;

        [XmlElement(ElementName = "supportCallInfoConferenceSubscriptionURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool SupportCallInfoConferenceSubscriptionURI
        {
            get => _supportCallInfoConferenceSubscriptionURI;
            set
            {
                SupportCallInfoConferenceSubscriptionURISpecified = true;
                _supportCallInfoConferenceSubscriptionURI = value;
            }
        }

        [XmlIgnore]
        public bool SupportCallInfoConferenceSubscriptionURISpecified { get; set; }

        private bool _supportRemotePartyInfo;

        [XmlElement(ElementName = "supportRemotePartyInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool SupportRemotePartyInfo
        {
            get => _supportRemotePartyInfo;
            set
            {
                SupportRemotePartyInfoSpecified = true;
                _supportRemotePartyInfo = value;
            }
        }

        [XmlIgnore]
        public bool SupportRemotePartyInfoSpecified { get; set; }

        private bool _supportVisualDeviceManagement;

        [XmlElement(ElementName = "supportVisualDeviceManagement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool SupportVisualDeviceManagement
        {
            get => _supportVisualDeviceManagement;
            set
            {
                SupportVisualDeviceManagementSpecified = true;
                _supportVisualDeviceManagement = value;
            }
        }

        [XmlIgnore]
        public bool SupportVisualDeviceManagementSpecified { get; set; }

        private bool _bypassMediaTreatment;

        [XmlElement(ElementName = "bypassMediaTreatment", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool BypassMediaTreatment
        {
            get => _bypassMediaTreatment;
            set
            {
                BypassMediaTreatmentSpecified = true;
                _bypassMediaTreatment = value;
            }
        }

        [XmlIgnore]
        public bool BypassMediaTreatmentSpecified { get; set; }

        private bool _supports3G4GContinuity;

        [XmlElement(ElementName = "supports3G4GContinuity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool Supports3G4GContinuity
        {
            get => _supports3G4GContinuity;
            set
            {
                Supports3G4GContinuitySpecified = true;
                _supports3G4GContinuity = value;
            }
        }

        [XmlIgnore]
        public bool Supports3G4GContinuitySpecified { get; set; }

        private bool _publishesOwnPresence;

        [XmlElement(ElementName = "publishesOwnPresence", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool PublishesOwnPresence
        {
            get => _publishesOwnPresence;
            set
            {
                PublishesOwnPresenceSpecified = true;
                _publishesOwnPresence = value;
            }
        }

        [XmlIgnore]
        public bool PublishesOwnPresenceSpecified { get; set; }

        private bool _supportCauseParameter;

        [XmlElement(ElementName = "supportCauseParameter", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool SupportCauseParameter
        {
            get => _supportCauseParameter;
            set
            {
                SupportCauseParameterSpecified = true;
                _supportCauseParameter = value;
            }
        }

        [XmlIgnore]
        public bool SupportCauseParameterSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LocationNetworkType _locationNetwork;

        [XmlElement(ElementName = "locationNetwork", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public BroadWorksConnector.Ocip.Models.LocationNetworkType LocationNetwork
        {
            get => _locationNetwork;
            set
            {
                LocationNetworkSpecified = true;
                _locationNetwork = value;
            }
        }

        [XmlIgnore]
        public bool LocationNetworkSpecified { get; set; }

        private bool _allowTerminationBasedOnICSI;

        [XmlElement(ElementName = "allowTerminationBasedOnICSI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public bool AllowTerminationBasedOnICSI
        {
            get => _allowTerminationBasedOnICSI;
            set
            {
                AllowTerminationBasedOnICSISpecified = true;
                _allowTerminationBasedOnICSI = value;
            }
        }

        [XmlIgnore]
        public bool AllowTerminationBasedOnICSISpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RoamingMode _roamingMode;

        [XmlElement(ElementName = "roamingMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16384")]
        public BroadWorksConnector.Ocip.Models.RoamingMode RoamingMode
        {
            get => _roamingMode;
            set
            {
                RoamingModeSpecified = true;
                _roamingMode = value;
            }
        }

        [XmlIgnore]
        public bool RoamingModeSpecified { get; set; }

    }
}
