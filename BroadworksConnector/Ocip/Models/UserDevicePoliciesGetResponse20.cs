using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserDevicePoliciesGetRequest201. enableDeviceFeatureSynchronization is ignored by the
    /// application server in Multiple User Shared mode.
    /// <see cref="UserDevicePoliciesGetRequest201"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35712""}]")]
    public class UserDevicePoliciesGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.UserDevicePolicyLineMode _lineMode;

        [XmlElement(ElementName = "lineMode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35712")]
        public BroadWorksConnector.Ocip.Models.UserDevicePolicyLineMode LineMode
        {
            get => _lineMode;
            set
            {
                LineModeSpecified = true;
                _lineMode = value;
            }
        }

        [XmlIgnore]
        public bool LineModeSpecified { get; set; }

        private bool _enableDeviceFeatureSynchronization;

        [XmlElement(ElementName = "enableDeviceFeatureSynchronization", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35712")]
        public bool EnableDeviceFeatureSynchronization
        {
            get => _enableDeviceFeatureSynchronization;
            set
            {
                EnableDeviceFeatureSynchronizationSpecified = true;
                _enableDeviceFeatureSynchronization = value;
            }
        }

        [XmlIgnore]
        public bool EnableDeviceFeatureSynchronizationSpecified { get; set; }

        private bool _enableDnd;

        [XmlElement(ElementName = "enableDnd", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35712")]
        public bool EnableDnd
        {
            get => _enableDnd;
            set
            {
                EnableDndSpecified = true;
                _enableDnd = value;
            }
        }

        [XmlIgnore]
        public bool EnableDndSpecified { get; set; }

        private bool _enableCallForwardingAlways;

        [XmlElement(ElementName = "enableCallForwardingAlways", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35712")]
        public bool EnableCallForwardingAlways
        {
            get => _enableCallForwardingAlways;
            set
            {
                EnableCallForwardingAlwaysSpecified = true;
                _enableCallForwardingAlways = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallForwardingAlwaysSpecified { get; set; }

        private bool _enableCallForwardingBusy;

        [XmlElement(ElementName = "enableCallForwardingBusy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35712")]
        public bool EnableCallForwardingBusy
        {
            get => _enableCallForwardingBusy;
            set
            {
                EnableCallForwardingBusySpecified = true;
                _enableCallForwardingBusy = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallForwardingBusySpecified { get; set; }

        private bool _enableCallForwardingNoAnswer;

        [XmlElement(ElementName = "enableCallForwardingNoAnswer", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35712")]
        public bool EnableCallForwardingNoAnswer
        {
            get => _enableCallForwardingNoAnswer;
            set
            {
                EnableCallForwardingNoAnswerSpecified = true;
                _enableCallForwardingNoAnswer = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallForwardingNoAnswerSpecified { get; set; }

        private bool _enableAcd;

        [XmlElement(ElementName = "enableAcd", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35712")]
        public bool EnableAcd
        {
            get => _enableAcd;
            set
            {
                EnableAcdSpecified = true;
                _enableAcd = value;
            }
        }

        [XmlIgnore]
        public bool EnableAcdSpecified { get; set; }

        private bool _enableExecutive;

        [XmlElement(ElementName = "enableExecutive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35712")]
        public bool EnableExecutive
        {
            get => _enableExecutive;
            set
            {
                EnableExecutiveSpecified = true;
                _enableExecutive = value;
            }
        }

        [XmlIgnore]
        public bool EnableExecutiveSpecified { get; set; }

        private bool _enableExecutiveAssistant;

        [XmlElement(ElementName = "enableExecutiveAssistant", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35712")]
        public bool EnableExecutiveAssistant
        {
            get => _enableExecutiveAssistant;
            set
            {
                EnableExecutiveAssistantSpecified = true;
                _enableExecutiveAssistant = value;
            }
        }

        [XmlIgnore]
        public bool EnableExecutiveAssistantSpecified { get; set; }

        private bool _enableSecurityClassification;

        [XmlElement(ElementName = "enableSecurityClassification", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35712")]
        public bool EnableSecurityClassification
        {
            get => _enableSecurityClassification;
            set
            {
                EnableSecurityClassificationSpecified = true;
                _enableSecurityClassification = value;
            }
        }

        [XmlIgnore]
        public bool EnableSecurityClassificationSpecified { get; set; }

        private bool _enableCallRecording;

        [XmlElement(ElementName = "enableCallRecording", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35712")]
        public bool EnableCallRecording
        {
            get => _enableCallRecording;
            set
            {
                EnableCallRecordingSpecified = true;
                _enableCallRecording = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallRecordingSpecified { get; set; }

    }
}
