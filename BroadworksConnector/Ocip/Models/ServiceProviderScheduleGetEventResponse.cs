using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderScheduleGetEventRequest.
    /// The response contains the event of the service provider schedule.
    /// <see cref="ServiceProviderScheduleGetEventRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4984"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4986"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4988""}]}]}]")]
    public class ServiceProviderScheduleGetEventResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _startDate;

        [XmlElement(ElementName = "startDate", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4984")]
        public string StartDate
        {
            get => _startDate;
            set
            {
                StartDateSpecified = true;
                _startDate = value;
            }
        }

        [XmlIgnore]
        public bool StartDateSpecified { get; set; }

        private bool _allDayEvent;

        [XmlElement(ElementName = "allDayEvent", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4986")]
        public bool AllDayEvent
        {
            get => _allDayEvent;
            set
            {
                AllDayEventSpecified = true;
                _allDayEvent = value;
            }
        }

        [XmlIgnore]
        public bool AllDayEventSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HourMinute _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4988")]
        public BroadWorksConnector.Ocip.Models.HourMinute StartTime
        {
            get => _startTime;
            set
            {
                StartTimeSpecified = true;
                _startTime = value;
            }
        }

        [XmlIgnore]
        public bool StartTimeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HourMinute _endTime;

        [XmlElement(ElementName = "endTime", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4988")]
        public BroadWorksConnector.Ocip.Models.HourMinute EndTime
        {
            get => _endTime;
            set
            {
                EndTimeSpecified = true;
                _endTime = value;
            }
        }

        [XmlIgnore]
        public bool EndTimeSpecified { get; set; }

        private string _endDate;

        [XmlElement(ElementName = "endDate", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4984")]
        public string EndDate
        {
            get => _endDate;
            set
            {
                EndDateSpecified = true;
                _endDate = value;
            }
        }

        [XmlIgnore]
        public bool EndDateSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.Recurrence _recurrence;

        [XmlElement(ElementName = "recurrence", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4984")]
        public BroadWorksConnector.Ocip.Models.Recurrence Recurrence
        {
            get => _recurrence;
            set
            {
                RecurrenceSpecified = true;
                _recurrence = value;
            }
        }

        [XmlIgnore]
        public bool RecurrenceSpecified { get; set; }

    }
}
