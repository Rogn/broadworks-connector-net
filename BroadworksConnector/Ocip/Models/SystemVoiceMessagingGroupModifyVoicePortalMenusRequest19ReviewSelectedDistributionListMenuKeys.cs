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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1529""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ReviewSelectedDistributionListMenuKeys
    {

        private string _interruptPlaybackAndReturnToPreviousMenu;

        [XmlElement(ElementName = "interruptPlaybackAndReturnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1529")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string InterruptPlaybackAndReturnToPreviousMenu
        {
            get => _interruptPlaybackAndReturnToPreviousMenu;
            set
            {
                InterruptPlaybackAndReturnToPreviousMenuSpecified = true;
                _interruptPlaybackAndReturnToPreviousMenu = value;
            }
        }

        [XmlIgnore]
        public bool InterruptPlaybackAndReturnToPreviousMenuSpecified { get; set; }

    }
}
