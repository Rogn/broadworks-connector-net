using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderCallProcessingGetPolicyRequest22V2.
    /// The following elements are only used in AS data mode:
    /// useServiceProviderDCLIDSetting
    /// enableDialableCallerID
    /// allowConfigurableCLIDForRedirectingIdentity
    /// enterpriseCallsCLIDPolicy, value "Use Location Code plus Extension" is returned in XS data mode.
    /// groupCallsCLIDPolicy, value "Use Extension" is returned in XS data mode.
    /// enablePhoneListLookup, value "false" is returned in XS data mode.
    /// useMaxConcurrentTerminatingAlertingRequests, value "false" is returned in XS data mode.
    /// maxConcurrentTerminatingAlertingRequests, value "10" is returned in XS data mode.
    /// includeRedirectionsInMaximumNumberOfConcurrentCalls, value "false" is returned in XS data mode.
    /// useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable, value "false" is returned in XS data mode.
    /// useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable, value "false" is returned in XS data mode.
    /// allowMobileDNForRedirectingIdentity, value "false" is returned in XS data mode.
    /// The following elements are only used in XS data mode and not returned in AS data mode:
    /// routeOverrideDomain
    /// routeOverridePrefix
    /// <see cref="ServiceProviderCallProcessingGetPolicyRequest22V2"/>
    /// <see cref="useMaxConcurrentTerminatingAlertingRequests"/>
    /// <see cref="maxConcurrentTerminatingAlertingRequests"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:1333""}]")]
    public class ServiceProviderCallProcessingGetPolicyResponse22V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useServiceProviderDCLIDSetting;

        [XmlElement(ElementName = "useServiceProviderDCLIDSetting", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool UseServiceProviderDCLIDSetting
        {
            get => _useServiceProviderDCLIDSetting;
            set
            {
                UseServiceProviderDCLIDSettingSpecified = true;
                _useServiceProviderDCLIDSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseServiceProviderDCLIDSettingSpecified { get; set; }

        private bool _useMaxSimultaneousCalls;

        [XmlElement(ElementName = "useMaxSimultaneousCalls", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool UseMaxSimultaneousCalls
        {
            get => _useMaxSimultaneousCalls;
            set
            {
                UseMaxSimultaneousCallsSpecified = true;
                _useMaxSimultaneousCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseMaxSimultaneousCallsSpecified { get; set; }

        private int _maxSimultaneousCalls;

        [XmlElement(ElementName = "maxSimultaneousCalls", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int MaxSimultaneousCalls
        {
            get => _maxSimultaneousCalls;
            set
            {
                MaxSimultaneousCallsSpecified = true;
                _maxSimultaneousCalls = value;
            }
        }

        [XmlIgnore]
        public bool MaxSimultaneousCallsSpecified { get; set; }

        private bool _useMaxSimultaneousVideoCalls;

        [XmlElement(ElementName = "useMaxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool UseMaxSimultaneousVideoCalls
        {
            get => _useMaxSimultaneousVideoCalls;
            set
            {
                UseMaxSimultaneousVideoCallsSpecified = true;
                _useMaxSimultaneousVideoCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseMaxSimultaneousVideoCallsSpecified { get; set; }

        private int _maxSimultaneousVideoCalls;

        [XmlElement(ElementName = "maxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int MaxSimultaneousVideoCalls
        {
            get => _maxSimultaneousVideoCalls;
            set
            {
                MaxSimultaneousVideoCallsSpecified = true;
                _maxSimultaneousVideoCalls = value;
            }
        }

        [XmlIgnore]
        public bool MaxSimultaneousVideoCallsSpecified { get; set; }

        private bool _useMaxCallTimeForAnsweredCalls;

        [XmlElement(ElementName = "useMaxCallTimeForAnsweredCalls", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool UseMaxCallTimeForAnsweredCalls
        {
            get => _useMaxCallTimeForAnsweredCalls;
            set
            {
                UseMaxCallTimeForAnsweredCallsSpecified = true;
                _useMaxCallTimeForAnsweredCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseMaxCallTimeForAnsweredCallsSpecified { get; set; }

        private int _maxCallTimeForAnsweredCallsMinutes;

        [XmlElement(ElementName = "maxCallTimeForAnsweredCallsMinutes", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinInclusive(3)]
        [MaxInclusive(2880)]
        public int MaxCallTimeForAnsweredCallsMinutes
        {
            get => _maxCallTimeForAnsweredCallsMinutes;
            set
            {
                MaxCallTimeForAnsweredCallsMinutesSpecified = true;
                _maxCallTimeForAnsweredCallsMinutes = value;
            }
        }

        [XmlIgnore]
        public bool MaxCallTimeForAnsweredCallsMinutesSpecified { get; set; }

        private bool _useMaxCallTimeForUnansweredCalls;

        [XmlElement(ElementName = "useMaxCallTimeForUnansweredCalls", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool UseMaxCallTimeForUnansweredCalls
        {
            get => _useMaxCallTimeForUnansweredCalls;
            set
            {
                UseMaxCallTimeForUnansweredCallsSpecified = true;
                _useMaxCallTimeForUnansweredCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseMaxCallTimeForUnansweredCallsSpecified { get; set; }

        private int _maxCallTimeForUnansweredCallsMinutes;

        [XmlElement(ElementName = "maxCallTimeForUnansweredCallsMinutes", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinInclusive(1)]
        [MaxInclusive(2880)]
        public int MaxCallTimeForUnansweredCallsMinutes
        {
            get => _maxCallTimeForUnansweredCallsMinutes;
            set
            {
                MaxCallTimeForUnansweredCallsMinutesSpecified = true;
                _maxCallTimeForUnansweredCallsMinutes = value;
            }
        }

        [XmlIgnore]
        public bool MaxCallTimeForUnansweredCallsMinutesSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaPolicySelection _mediaPolicySelection;

        [XmlElement(ElementName = "mediaPolicySelection", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public BroadWorksConnector.Ocip.Models.MediaPolicySelection MediaPolicySelection
        {
            get => _mediaPolicySelection;
            set
            {
                MediaPolicySelectionSpecified = true;
                _mediaPolicySelection = value;
            }
        }

        [XmlIgnore]
        public bool MediaPolicySelectionSpecified { get; set; }

        private string _supportedMediaSetName;

        [XmlElement(ElementName = "supportedMediaSetName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SupportedMediaSetName
        {
            get => _supportedMediaSetName;
            set
            {
                SupportedMediaSetNameSpecified = true;
                _supportedMediaSetName = value;
            }
        }

        [XmlIgnore]
        public bool SupportedMediaSetNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.NetworkUsageSelection _networkUsageSelection;

        [XmlElement(ElementName = "networkUsageSelection", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public BroadWorksConnector.Ocip.Models.NetworkUsageSelection NetworkUsageSelection
        {
            get => _networkUsageSelection;
            set
            {
                NetworkUsageSelectionSpecified = true;
                _networkUsageSelection = value;
            }
        }

        [XmlIgnore]
        public bool NetworkUsageSelectionSpecified { get; set; }

        private bool _enforceGroupCallingLineIdentityRestriction;

        [XmlElement(ElementName = "enforceGroupCallingLineIdentityRestriction", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool EnforceGroupCallingLineIdentityRestriction
        {
            get => _enforceGroupCallingLineIdentityRestriction;
            set
            {
                EnforceGroupCallingLineIdentityRestrictionSpecified = true;
                _enforceGroupCallingLineIdentityRestriction = value;
            }
        }

        [XmlIgnore]
        public bool EnforceGroupCallingLineIdentityRestrictionSpecified { get; set; }

        private bool _allowEnterpriseGroupCallTypingForPrivateDialingPlan;

        [XmlElement(ElementName = "allowEnterpriseGroupCallTypingForPrivateDialingPlan", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool AllowEnterpriseGroupCallTypingForPrivateDialingPlan
        {
            get => _allowEnterpriseGroupCallTypingForPrivateDialingPlan;
            set
            {
                AllowEnterpriseGroupCallTypingForPrivateDialingPlanSpecified = true;
                _allowEnterpriseGroupCallTypingForPrivateDialingPlan = value;
            }
        }

        [XmlIgnore]
        public bool AllowEnterpriseGroupCallTypingForPrivateDialingPlanSpecified { get; set; }

        private bool _allowEnterpriseGroupCallTypingForPublicDialingPlan;

        [XmlElement(ElementName = "allowEnterpriseGroupCallTypingForPublicDialingPlan", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool AllowEnterpriseGroupCallTypingForPublicDialingPlan
        {
            get => _allowEnterpriseGroupCallTypingForPublicDialingPlan;
            set
            {
                AllowEnterpriseGroupCallTypingForPublicDialingPlanSpecified = true;
                _allowEnterpriseGroupCallTypingForPublicDialingPlan = value;
            }
        }

        [XmlIgnore]
        public bool AllowEnterpriseGroupCallTypingForPublicDialingPlanSpecified { get; set; }

        private bool _overrideCLIDRestrictionForPrivateCallCategory;

        [XmlElement(ElementName = "overrideCLIDRestrictionForPrivateCallCategory", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool OverrideCLIDRestrictionForPrivateCallCategory
        {
            get => _overrideCLIDRestrictionForPrivateCallCategory;
            set
            {
                OverrideCLIDRestrictionForPrivateCallCategorySpecified = true;
                _overrideCLIDRestrictionForPrivateCallCategory = value;
            }
        }

        [XmlIgnore]
        public bool OverrideCLIDRestrictionForPrivateCallCategorySpecified { get; set; }

        private bool _useEnterpriseCLIDForPrivateCallCategory;

        [XmlElement(ElementName = "useEnterpriseCLIDForPrivateCallCategory", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool UseEnterpriseCLIDForPrivateCallCategory
        {
            get => _useEnterpriseCLIDForPrivateCallCategory;
            set
            {
                UseEnterpriseCLIDForPrivateCallCategorySpecified = true;
                _useEnterpriseCLIDForPrivateCallCategory = value;
            }
        }

        [XmlIgnore]
        public bool UseEnterpriseCLIDForPrivateCallCategorySpecified { get; set; }

        private bool _enableEnterpriseExtensionDialing;

        [XmlElement(ElementName = "enableEnterpriseExtensionDialing", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool EnableEnterpriseExtensionDialing
        {
            get => _enableEnterpriseExtensionDialing;
            set
            {
                EnableEnterpriseExtensionDialingSpecified = true;
                _enableEnterpriseExtensionDialing = value;
            }
        }

        [XmlIgnore]
        public bool EnableEnterpriseExtensionDialingSpecified { get; set; }

        private bool _enforceEnterpriseCallingLineIdentityRestriction;

        [XmlElement(ElementName = "enforceEnterpriseCallingLineIdentityRestriction", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool EnforceEnterpriseCallingLineIdentityRestriction
        {
            get => _enforceEnterpriseCallingLineIdentityRestriction;
            set
            {
                EnforceEnterpriseCallingLineIdentityRestrictionSpecified = true;
                _enforceEnterpriseCallingLineIdentityRestriction = value;
            }
        }

        [XmlIgnore]
        public bool EnforceEnterpriseCallingLineIdentityRestrictionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceProviderConferenceURISettingLevel _useSettingLevel;

        [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderConferenceURISettingLevel UseSettingLevel
        {
            get => _useSettingLevel;
            set
            {
                UseSettingLevelSpecified = true;
                _useSettingLevel = value;
            }
        }

        [XmlIgnore]
        public bool UseSettingLevelSpecified { get; set; }

        private string _conferenceURI;

        [XmlElement(ElementName = "conferenceURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ConferenceURI
        {
            get => _conferenceURI;
            set
            {
                ConferenceURISpecified = true;
                _conferenceURI = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceURISpecified { get; set; }

        private bool _useMaxConcurrentRedirectedCalls;

        [XmlElement(ElementName = "useMaxConcurrentRedirectedCalls", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool UseMaxConcurrentRedirectedCalls
        {
            get => _useMaxConcurrentRedirectedCalls;
            set
            {
                UseMaxConcurrentRedirectedCallsSpecified = true;
                _useMaxConcurrentRedirectedCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseMaxConcurrentRedirectedCallsSpecified { get; set; }

        private int _maxConcurrentRedirectedCalls;

        [XmlElement(ElementName = "maxConcurrentRedirectedCalls", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int MaxConcurrentRedirectedCalls
        {
            get => _maxConcurrentRedirectedCalls;
            set
            {
                MaxConcurrentRedirectedCallsSpecified = true;
                _maxConcurrentRedirectedCalls = value;
            }
        }

        [XmlIgnore]
        public bool MaxConcurrentRedirectedCallsSpecified { get; set; }

        private bool _useMaxFindMeFollowMeDepth;

        [XmlElement(ElementName = "useMaxFindMeFollowMeDepth", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool UseMaxFindMeFollowMeDepth
        {
            get => _useMaxFindMeFollowMeDepth;
            set
            {
                UseMaxFindMeFollowMeDepthSpecified = true;
                _useMaxFindMeFollowMeDepth = value;
            }
        }

        [XmlIgnore]
        public bool UseMaxFindMeFollowMeDepthSpecified { get; set; }

        private int _maxFindMeFollowMeDepth;

        [XmlElement(ElementName = "maxFindMeFollowMeDepth", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int MaxFindMeFollowMeDepth
        {
            get => _maxFindMeFollowMeDepth;
            set
            {
                MaxFindMeFollowMeDepthSpecified = true;
                _maxFindMeFollowMeDepth = value;
            }
        }

        [XmlIgnore]
        public bool MaxFindMeFollowMeDepthSpecified { get; set; }

        private int _maxRedirectionDepth;

        [XmlElement(ElementName = "maxRedirectionDepth", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int MaxRedirectionDepth
        {
            get => _maxRedirectionDepth;
            set
            {
                MaxRedirectionDepthSpecified = true;
                _maxRedirectionDepth = value;
            }
        }

        [XmlIgnore]
        public bool MaxRedirectionDepthSpecified { get; set; }

        private bool _useMaxConcurrentFindMeFollowMeInvocations;

        [XmlElement(ElementName = "useMaxConcurrentFindMeFollowMeInvocations", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool UseMaxConcurrentFindMeFollowMeInvocations
        {
            get => _useMaxConcurrentFindMeFollowMeInvocations;
            set
            {
                UseMaxConcurrentFindMeFollowMeInvocationsSpecified = true;
                _useMaxConcurrentFindMeFollowMeInvocations = value;
            }
        }

        [XmlIgnore]
        public bool UseMaxConcurrentFindMeFollowMeInvocationsSpecified { get; set; }

        private int _maxConcurrentFindMeFollowMeInvocations;

        [XmlElement(ElementName = "maxConcurrentFindMeFollowMeInvocations", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int MaxConcurrentFindMeFollowMeInvocations
        {
            get => _maxConcurrentFindMeFollowMeInvocations;
            set
            {
                MaxConcurrentFindMeFollowMeInvocationsSpecified = true;
                _maxConcurrentFindMeFollowMeInvocations = value;
            }
        }

        [XmlIgnore]
        public bool MaxConcurrentFindMeFollowMeInvocationsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CLIDPolicy _clidPolicy;

        [XmlElement(ElementName = "clidPolicy", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public BroadWorksConnector.Ocip.Models.CLIDPolicy ClidPolicy
        {
            get => _clidPolicy;
            set
            {
                ClidPolicySpecified = true;
                _clidPolicy = value;
            }
        }

        [XmlIgnore]
        public bool ClidPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CLIDPolicy _emergencyClidPolicy;

        [XmlElement(ElementName = "emergencyClidPolicy", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public BroadWorksConnector.Ocip.Models.CLIDPolicy EmergencyClidPolicy
        {
            get => _emergencyClidPolicy;
            set
            {
                EmergencyClidPolicySpecified = true;
                _emergencyClidPolicy = value;
            }
        }

        [XmlIgnore]
        public bool EmergencyClidPolicySpecified { get; set; }

        private bool _allowAlternateNumbersForRedirectingIdentity;

        [XmlElement(ElementName = "allowAlternateNumbersForRedirectingIdentity", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool AllowAlternateNumbersForRedirectingIdentity
        {
            get => _allowAlternateNumbersForRedirectingIdentity;
            set
            {
                AllowAlternateNumbersForRedirectingIdentitySpecified = true;
                _allowAlternateNumbersForRedirectingIdentity = value;
            }
        }

        [XmlIgnore]
        public bool AllowAlternateNumbersForRedirectingIdentitySpecified { get; set; }

        private bool _blockCallingNameForExternalCalls;

        [XmlElement(ElementName = "blockCallingNameForExternalCalls", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool BlockCallingNameForExternalCalls
        {
            get => _blockCallingNameForExternalCalls;
            set
            {
                BlockCallingNameForExternalCallsSpecified = true;
                _blockCallingNameForExternalCalls = value;
            }
        }

        [XmlIgnore]
        public bool BlockCallingNameForExternalCallsSpecified { get; set; }

        private bool _enableDialableCallerID;

        [XmlElement(ElementName = "enableDialableCallerID", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool EnableDialableCallerID
        {
            get => _enableDialableCallerID;
            set
            {
                EnableDialableCallerIDSpecified = true;
                _enableDialableCallerID = value;
            }
        }

        [XmlIgnore]
        public bool EnableDialableCallerIDSpecified { get; set; }

        private bool _allowConfigurableCLIDForRedirectingIdentity;

        [XmlElement(ElementName = "allowConfigurableCLIDForRedirectingIdentity", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool AllowConfigurableCLIDForRedirectingIdentity
        {
            get => _allowConfigurableCLIDForRedirectingIdentity;
            set
            {
                AllowConfigurableCLIDForRedirectingIdentitySpecified = true;
                _allowConfigurableCLIDForRedirectingIdentity = value;
            }
        }

        [XmlIgnore]
        public bool AllowConfigurableCLIDForRedirectingIdentitySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy _enterpriseCallsCLIDPolicy;

        [XmlElement(ElementName = "enterpriseCallsCLIDPolicy", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public BroadWorksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy EnterpriseCallsCLIDPolicy
        {
            get => _enterpriseCallsCLIDPolicy;
            set
            {
                EnterpriseCallsCLIDPolicySpecified = true;
                _enterpriseCallsCLIDPolicy = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseCallsCLIDPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy _groupCallsCLIDPolicy;

        [XmlElement(ElementName = "groupCallsCLIDPolicy", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public BroadWorksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy GroupCallsCLIDPolicy
        {
            get => _groupCallsCLIDPolicy;
            set
            {
                GroupCallsCLIDPolicySpecified = true;
                _groupCallsCLIDPolicy = value;
            }
        }

        [XmlIgnore]
        public bool GroupCallsCLIDPolicySpecified { get; set; }

        private bool _enablePhoneListLookup;

        [XmlElement(ElementName = "enablePhoneListLookup", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool EnablePhoneListLookup
        {
            get => _enablePhoneListLookup;
            set
            {
                EnablePhoneListLookupSpecified = true;
                _enablePhoneListLookup = value;
            }
        }

        [XmlIgnore]
        public bool EnablePhoneListLookupSpecified { get; set; }

        private bool _useMaxConcurrentTerminatingAlertingRequests;

        [XmlElement(ElementName = "useMaxConcurrentTerminatingAlertingRequests", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool UseMaxConcurrentTerminatingAlertingRequests
        {
            get => _useMaxConcurrentTerminatingAlertingRequests;
            set
            {
                UseMaxConcurrentTerminatingAlertingRequestsSpecified = true;
                _useMaxConcurrentTerminatingAlertingRequests = value;
            }
        }

        [XmlIgnore]
        public bool UseMaxConcurrentTerminatingAlertingRequestsSpecified { get; set; }

        private int _maxConcurrentTerminatingAlertingRequests;

        [XmlElement(ElementName = "maxConcurrentTerminatingAlertingRequests", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinInclusive(1)]
        [MaxInclusive(50)]
        public int MaxConcurrentTerminatingAlertingRequests
        {
            get => _maxConcurrentTerminatingAlertingRequests;
            set
            {
                MaxConcurrentTerminatingAlertingRequestsSpecified = true;
                _maxConcurrentTerminatingAlertingRequests = value;
            }
        }

        [XmlIgnore]
        public bool MaxConcurrentTerminatingAlertingRequestsSpecified { get; set; }

        private bool _includeRedirectionsInMaximumNumberOfConcurrentCalls;

        [XmlElement(ElementName = "includeRedirectionsInMaximumNumberOfConcurrentCalls", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool IncludeRedirectionsInMaximumNumberOfConcurrentCalls
        {
            get => _includeRedirectionsInMaximumNumberOfConcurrentCalls;
            set
            {
                IncludeRedirectionsInMaximumNumberOfConcurrentCallsSpecified = true;
                _includeRedirectionsInMaximumNumberOfConcurrentCalls = value;
            }
        }

        [XmlIgnore]
        public bool IncludeRedirectionsInMaximumNumberOfConcurrentCallsSpecified { get; set; }

        private bool _useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable;

        [XmlElement(ElementName = "useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool UseUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable
        {
            get => _useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable;
            set
            {
                UseUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailableSpecified = true;
                _useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable = value;
            }
        }

        [XmlIgnore]
        public bool UseUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailableSpecified { get; set; }

        private bool _useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable;

        [XmlElement(ElementName = "useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool UseUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable
        {
            get => _useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable;
            set
            {
                UseUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailableSpecified = true;
                _useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable = value;
            }
        }

        [XmlIgnore]
        public bool UseUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailableSpecified { get; set; }

        private string _routeOverrideDomain;

        [XmlElement(ElementName = "routeOverrideDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinLength(1)]
        [MaxLength(80)]
        public string RouteOverrideDomain
        {
            get => _routeOverrideDomain;
            set
            {
                RouteOverrideDomainSpecified = true;
                _routeOverrideDomain = value;
            }
        }

        [XmlIgnore]
        public bool RouteOverrideDomainSpecified { get; set; }

        private string _routeOverridePrefix;

        [XmlElement(ElementName = "routeOverridePrefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        [MinLength(1)]
        [MaxLength(10)]
        public string RouteOverridePrefix
        {
            get => _routeOverridePrefix;
            set
            {
                RouteOverridePrefixSpecified = true;
                _routeOverridePrefix = value;
            }
        }

        [XmlIgnore]
        public bool RouteOverridePrefixSpecified { get; set; }

        private bool _allowMobileDNForRedirectingIdentity;

        [XmlElement(ElementName = "allowMobileDNForRedirectingIdentity", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1333")]
        public bool AllowMobileDNForRedirectingIdentity
        {
            get => _allowMobileDNForRedirectingIdentity;
            set
            {
                AllowMobileDNForRedirectingIdentitySpecified = true;
                _allowMobileDNForRedirectingIdentity = value;
            }
        }

        [XmlIgnore]
        public bool AllowMobileDNForRedirectingIdentitySpecified { get; set; }

    }
}
