using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:32048""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1VoicePortalMainMenuKeys
    {

        private string _voiceMessaging;

        [XmlElement(ElementName = "voiceMessaging", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32048")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string VoiceMessaging
        {
            get => _voiceMessaging;
            set
            {
                VoiceMessagingSpecified = true;
                _voiceMessaging = value;
            }
        }

        [XmlIgnore]
        public bool VoiceMessagingSpecified { get; set; }

        private string _commPilotExpressProfile;

        [XmlElement(ElementName = "commPilotExpressProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32048")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string CommPilotExpressProfile
        {
            get => _commPilotExpressProfile;
            set
            {
                CommPilotExpressProfileSpecified = true;
                _commPilotExpressProfile = value;
            }
        }

        [XmlIgnore]
        public bool CommPilotExpressProfileSpecified { get; set; }

        private string _greetings;

        [XmlElement(ElementName = "greetings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32048")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string Greetings
        {
            get => _greetings;
            set
            {
                GreetingsSpecified = true;
                _greetings = value;
            }
        }

        [XmlIgnore]
        public bool GreetingsSpecified { get; set; }

        private string _callForwardingOptions;

        [XmlElement(ElementName = "callForwardingOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32048")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string CallForwardingOptions
        {
            get => _callForwardingOptions;
            set
            {
                CallForwardingOptionsSpecified = true;
                _callForwardingOptions = value;
            }
        }

        [XmlIgnore]
        public bool CallForwardingOptionsSpecified { get; set; }

        private string _voicePortalCalling;

        [XmlElement(ElementName = "voicePortalCalling", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32048")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string VoicePortalCalling
        {
            get => _voicePortalCalling;
            set
            {
                VoicePortalCallingSpecified = true;
                _voicePortalCalling = value;
            }
        }

        [XmlIgnore]
        public bool VoicePortalCallingSpecified { get; set; }

        private string _hoteling;

        [XmlElement(ElementName = "hoteling", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32048")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string Hoteling
        {
            get => _hoteling;
            set
            {
                HotelingSpecified = true;
                _hoteling = value;
            }
        }

        [XmlIgnore]
        public bool HotelingSpecified { get; set; }

        private string _passcode;

        [XmlElement(ElementName = "passcode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32048")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string Passcode
        {
            get => _passcode;
            set
            {
                PasscodeSpecified = true;
                _passcode = value;
            }
        }

        [XmlIgnore]
        public bool PasscodeSpecified { get; set; }

        private string _exitVoicePortal;

        [XmlElement(ElementName = "exitVoicePortal", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32048")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ExitVoicePortal
        {
            get => _exitVoicePortal;
            set
            {
                ExitVoicePortalSpecified = true;
                _exitVoicePortal = value;
            }
        }

        [XmlIgnore]
        public bool ExitVoicePortalSpecified { get; set; }

        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32048")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RepeatMenu
        {
            get => _repeatMenu;
            set
            {
                RepeatMenuSpecified = true;
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        public bool RepeatMenuSpecified { get; set; }

        private string _externalRouting;

        [XmlElement(ElementName = "externalRouting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32048")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ExternalRouting
        {
            get => _externalRouting;
            set
            {
                ExternalRoutingSpecified = true;
                _externalRouting = value;
            }
        }

        [XmlIgnore]
        public bool ExternalRoutingSpecified { get; set; }

    }
}
