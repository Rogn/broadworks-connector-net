using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system call processing configuration for all subscribers.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in XS data mode and ignored in the AS data mode:
    /// minNoAnswerNumberOfRings
    /// 
    /// The following elements are only used in AS data mode and ignored in the XS data mode:
    /// isExtendedCallingLineIdActive
    /// isRingTimeOutActive
    /// ringTimeoutSeconds
    /// allowEmergencyRemoteOfficeOriginations
    /// incomingCallToUserAliasMode
    /// bypassTerminationLoopDetection
    /// honorCLIDBlockingForEmergencyCalls
    /// useUnicodeIdentityName
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17111""}]")]
    public class SystemSubscriberModifyCallProcessingParametersRequest14sp7 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _isExtendedCallingLineIdActive;

        [XmlElement(ElementName = "isExtendedCallingLineIdActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17111")]
        public bool IsExtendedCallingLineIdActive
        {
            get => _isExtendedCallingLineIdActive;
            set
            {
                IsExtendedCallingLineIdActiveSpecified = true;
                _isExtendedCallingLineIdActive = value;
            }
        }

        [XmlIgnore]
        public bool IsExtendedCallingLineIdActiveSpecified { get; set; }

        private bool _isRingTimeOutActive;

        [XmlElement(ElementName = "isRingTimeOutActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17111")]
        public bool IsRingTimeOutActive
        {
            get => _isRingTimeOutActive;
            set
            {
                IsRingTimeOutActiveSpecified = true;
                _isRingTimeOutActive = value;
            }
        }

        [XmlIgnore]
        public bool IsRingTimeOutActiveSpecified { get; set; }

        private int _ringTimeoutSeconds;

        [XmlElement(ElementName = "ringTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17111")]
        [MinInclusive(1)]
        [MaxInclusive(180)]
        public int RingTimeoutSeconds
        {
            get => _ringTimeoutSeconds;
            set
            {
                RingTimeoutSecondsSpecified = true;
                _ringTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RingTimeoutSecondsSpecified { get; set; }

        private bool _allowEmergencyRemoteOfficeOriginations;

        [XmlElement(ElementName = "allowEmergencyRemoteOfficeOriginations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17111")]
        public bool AllowEmergencyRemoteOfficeOriginations
        {
            get => _allowEmergencyRemoteOfficeOriginations;
            set
            {
                AllowEmergencyRemoteOfficeOriginationsSpecified = true;
                _allowEmergencyRemoteOfficeOriginations = value;
            }
        }

        [XmlIgnore]
        public bool AllowEmergencyRemoteOfficeOriginationsSpecified { get; set; }

        private int _maxNoAnswerNumberOfRings;

        [XmlElement(ElementName = "maxNoAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17111")]
        [MinInclusive(6)]
        [MaxInclusive(20)]
        public int MaxNoAnswerNumberOfRings
        {
            get => _maxNoAnswerNumberOfRings;
            set
            {
                MaxNoAnswerNumberOfRingsSpecified = true;
                _maxNoAnswerNumberOfRings = value;
            }
        }

        [XmlIgnore]
        public bool MaxNoAnswerNumberOfRingsSpecified { get; set; }

        private int _minNoAnswerNumberOfRings;

        [XmlElement(ElementName = "minNoAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17111")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int MinNoAnswerNumberOfRings
        {
            get => _minNoAnswerNumberOfRings;
            set
            {
                MinNoAnswerNumberOfRingsSpecified = true;
                _minNoAnswerNumberOfRings = value;
            }
        }

        [XmlIgnore]
        public bool MinNoAnswerNumberOfRingsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.IncomingCallToUserAliasMode _incomingCallToUserAliasMode;

        [XmlElement(ElementName = "incomingCallToUserAliasMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17111")]
        public BroadWorksConnector.Ocip.Models.IncomingCallToUserAliasMode IncomingCallToUserAliasMode
        {
            get => _incomingCallToUserAliasMode;
            set
            {
                IncomingCallToUserAliasModeSpecified = true;
                _incomingCallToUserAliasMode = value;
            }
        }

        [XmlIgnore]
        public bool IncomingCallToUserAliasModeSpecified { get; set; }

        private bool _bypassTerminationLoopDetection;

        [XmlElement(ElementName = "bypassTerminationLoopDetection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17111")]
        public bool BypassTerminationLoopDetection
        {
            get => _bypassTerminationLoopDetection;
            set
            {
                BypassTerminationLoopDetectionSpecified = true;
                _bypassTerminationLoopDetection = value;
            }
        }

        [XmlIgnore]
        public bool BypassTerminationLoopDetectionSpecified { get; set; }

        private bool _honorCLIDBlockingForEmergencyCalls;

        [XmlElement(ElementName = "honorCLIDBlockingForEmergencyCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17111")]
        public bool HonorCLIDBlockingForEmergencyCalls
        {
            get => _honorCLIDBlockingForEmergencyCalls;
            set
            {
                HonorCLIDBlockingForEmergencyCallsSpecified = true;
                _honorCLIDBlockingForEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        public bool HonorCLIDBlockingForEmergencyCallsSpecified { get; set; }

        private bool _useUnicodeIdentityName;

        [XmlElement(ElementName = "useUnicodeIdentityName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17111")]
        public bool UseUnicodeIdentityName
        {
            get => _useUnicodeIdentityName;
            set
            {
                UseUnicodeIdentityNameSpecified = true;
                _useUnicodeIdentityName = value;
            }
        }

        [XmlIgnore]
        public bool UseUnicodeIdentityNameSpecified { get; set; }

    }
}
