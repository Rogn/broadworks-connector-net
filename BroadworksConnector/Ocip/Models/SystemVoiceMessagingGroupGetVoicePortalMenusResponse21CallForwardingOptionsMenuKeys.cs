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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:853""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21CallForwardingOptionsMenuKeys
    {

        private string _activateCallForwarding;

        [XmlElement(ElementName = "activateCallForwarding", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:853")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ActivateCallForwarding
        {
            get => _activateCallForwarding;
            set
            {
                ActivateCallForwardingSpecified = true;
                _activateCallForwarding = value;
            }
        }

        [XmlIgnore]
        public bool ActivateCallForwardingSpecified { get; set; }

        private string _deactivateCallForwarding;

        [XmlElement(ElementName = "deactivateCallForwarding", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:853")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DeactivateCallForwarding
        {
            get => _deactivateCallForwarding;
            set
            {
                DeactivateCallForwardingSpecified = true;
                _deactivateCallForwarding = value;
            }
        }

        [XmlIgnore]
        public bool DeactivateCallForwardingSpecified { get; set; }

        private string _changeCallForwardingDestination;

        [XmlElement(ElementName = "changeCallForwardingDestination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:853")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ChangeCallForwardingDestination
        {
            get => _changeCallForwardingDestination;
            set
            {
                ChangeCallForwardingDestinationSpecified = true;
                _changeCallForwardingDestination = value;
            }
        }

        [XmlIgnore]
        public bool ChangeCallForwardingDestinationSpecified { get; set; }

        private string _listenToCallForwardingStatus;

        [XmlElement(ElementName = "listenToCallForwardingStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:853")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ListenToCallForwardingStatus
        {
            get => _listenToCallForwardingStatus;
            set
            {
                ListenToCallForwardingStatusSpecified = true;
                _listenToCallForwardingStatus = value;
            }
        }

        [XmlIgnore]
        public bool ListenToCallForwardingStatusSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:853")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ReturnToPreviousMenu
        {
            get => _returnToPreviousMenu;
            set
            {
                ReturnToPreviousMenuSpecified = true;
                _returnToPreviousMenu = value;
            }
        }

        [XmlIgnore]
        public bool ReturnToPreviousMenuSpecified { get; set; }

        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:853")]
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

    }
}
