using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either SuccessResponse or ErrorResponse
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:4701""}]")]
    public class SystemCallProcessingPolicyProfileVoicePortalProfileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _callProcessingPolicyProfileName;

        [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
        [MinLength(1)]
        [MaxLength(40)]
        public string CallProcessingPolicyProfileName
        {
            get => _callProcessingPolicyProfileName;
            set
            {
                CallProcessingPolicyProfileNameSpecified = true;
                _callProcessingPolicyProfileName = value;
            }
        }

        [XmlIgnore]
        public bool CallProcessingPolicyProfileNameSpecified { get; set; }

        private bool _useCLIDPolicy;

        [XmlElement(ElementName = "useCLIDPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
        public bool UseCLIDPolicy
        {
            get => _useCLIDPolicy;
            set
            {
                UseCLIDPolicySpecified = true;
                _useCLIDPolicy = value;
            }
        }

        [XmlIgnore]
        public bool UseCLIDPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupCLIDPolicy _clidPolicy;

        [XmlElement(ElementName = "clidPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
        public BroadWorksConnector.Ocip.Models.GroupCLIDPolicy ClidPolicy
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

        private bool _useGroupName;

        [XmlElement(ElementName = "useGroupName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
        public bool UseGroupName
        {
            get => _useGroupName;
            set
            {
                UseGroupNameSpecified = true;
                _useGroupName = value;
            }
        }

        [XmlIgnore]
        public bool UseGroupNameSpecified { get; set; }

        private bool _blockCallingNameForExternalCalls;

        [XmlElement(ElementName = "blockCallingNameForExternalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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

        private bool _allowConfigurableCLIDForRedirectingIdentity;

        [XmlElement(ElementName = "allowConfigurableCLIDForRedirectingIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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

        private bool _allowDepartmentCLIDNameOverride;

        [XmlElement(ElementName = "allowDepartmentCLIDNameOverride", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
        public bool AllowDepartmentCLIDNameOverride
        {
            get => _allowDepartmentCLIDNameOverride;
            set
            {
                AllowDepartmentCLIDNameOverrideSpecified = true;
                _allowDepartmentCLIDNameOverride = value;
            }
        }

        [XmlIgnore]
        public bool AllowDepartmentCLIDNameOverrideSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy _enterpriseCallsCLIDPolicy;

        [XmlElement(ElementName = "enterpriseCallsCLIDPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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

        private BroadWorksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy _enterpriseGroupCallsCLIDPolicy;

        [XmlElement(ElementName = "enterpriseGroupCallsCLIDPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
        public BroadWorksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy EnterpriseGroupCallsCLIDPolicy
        {
            get => _enterpriseGroupCallsCLIDPolicy;
            set
            {
                EnterpriseGroupCallsCLIDPolicySpecified = true;
                _enterpriseGroupCallsCLIDPolicy = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseGroupCallsCLIDPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceProviderInternalCallsCLIDPolicy _serviceProviderGroupCallsCLIDPolicy;

        [XmlElement(ElementName = "serviceProviderGroupCallsCLIDPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderInternalCallsCLIDPolicy ServiceProviderGroupCallsCLIDPolicy
        {
            get => _serviceProviderGroupCallsCLIDPolicy;
            set
            {
                ServiceProviderGroupCallsCLIDPolicySpecified = true;
                _serviceProviderGroupCallsCLIDPolicy = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderGroupCallsCLIDPolicySpecified { get; set; }

        private bool _useCallLimitsPolicy;

        [XmlElement(ElementName = "useCallLimitsPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
        public bool UseCallLimitsPolicy
        {
            get => _useCallLimitsPolicy;
            set
            {
                UseCallLimitsPolicySpecified = true;
                _useCallLimitsPolicy = value;
            }
        }

        [XmlIgnore]
        public bool UseCallLimitsPolicySpecified { get; set; }

        private bool _useMaxSimultaneousCalls;

        [XmlElement(ElementName = "useMaxSimultaneousCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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

        private int _maxRedirectionDepth;

        [XmlElement(ElementName = "maxRedirectionDepth", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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

        private bool _useTranslationRoutingPolicy;

        [XmlElement(ElementName = "useTranslationRoutingPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
        public bool UseTranslationRoutingPolicy
        {
            get => _useTranslationRoutingPolicy;
            set
            {
                UseTranslationRoutingPolicySpecified = true;
                _useTranslationRoutingPolicy = value;
            }
        }

        [XmlIgnore]
        public bool UseTranslationRoutingPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.NetworkUsageSelection _networkUsageSelection;

        [XmlElement(ElementName = "networkUsageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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

        private bool _enableEnterpriseExtensionDialing;

        [XmlElement(ElementName = "enableEnterpriseExtensionDialing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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

        private bool _allowEnterpriseGroupCallTypingForPrivateDialingPlan;

        [XmlElement(ElementName = "allowEnterpriseGroupCallTypingForPrivateDialingPlan", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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

        private bool _includeRedirectionsInMaximumNumberOfConcurrentCalls;

        [XmlElement(ElementName = "includeRedirectionsInMaximumNumberOfConcurrentCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:4701")]
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

    }
}
