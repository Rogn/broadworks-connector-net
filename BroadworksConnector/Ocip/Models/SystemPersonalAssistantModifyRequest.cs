using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify system Personal Assistant Parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f53ece1c00394ef2d3d76f532f9a9663:81""}]")]
    public class SystemPersonalAssistantModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _transferToAttendantKey;

        [XmlElement(ElementName = "transferToAttendantKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:81")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string TransferToAttendantKey
        {
            get => _transferToAttendantKey;
            set
            {
                TransferToAttendantKeySpecified = true;
                _transferToAttendantKey = value;
            }
        }

        [XmlIgnore]
        public bool TransferToAttendantKeySpecified { get; set; }

        private string _transferToVoiceMessagingKey;

        [XmlElement(ElementName = "transferToVoiceMessagingKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:81")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string TransferToVoiceMessagingKey
        {
            get => _transferToVoiceMessagingKey;
            set
            {
                TransferToVoiceMessagingKeySpecified = true;
                _transferToVoiceMessagingKey = value;
            }
        }

        [XmlIgnore]
        public bool TransferToVoiceMessagingKeySpecified { get; set; }

    }
}
