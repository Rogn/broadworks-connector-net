using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a user time schedule.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:17826""}]")]
    public class UserTimeScheduleDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17826")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }

        private string _timeScheduleName;

        [XmlElement(ElementName = "timeScheduleName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17826")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TimeScheduleName
        {
            get => _timeScheduleName;
            set
            {
                TimeScheduleNameSpecified = true;
                _timeScheduleName = value;
            }
        }

        [XmlIgnore]
        public bool TimeScheduleNameSpecified { get; set; }

    }
}
