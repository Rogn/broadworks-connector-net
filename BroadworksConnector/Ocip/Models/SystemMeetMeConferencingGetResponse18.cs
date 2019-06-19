using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMeetMeConferencingGetRequest18.
    /// <see cref="SystemMeetMeConferencingGetRequest18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26251""}]")]
    public class SystemMeetMeConferencingGetResponse18 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _conferenceIdLength;

        [XmlElement(ElementName = "conferenceIdLength", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        [MinInclusive(6)]
        [MaxInclusive(12)]
        public int ConferenceIdLength
        {
            get => _conferenceIdLength;
            set
            {
                ConferenceIdLengthSpecified = true;
                _conferenceIdLength = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceIdLengthSpecified { get; set; }

        private int _moderatorPinLength;

        [XmlElement(ElementName = "moderatorPinLength", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        [MinInclusive(6)]
        [MaxInclusive(12)]
        public int ModeratorPinLength
        {
            get => _moderatorPinLength;
            set
            {
                ModeratorPinLengthSpecified = true;
                _moderatorPinLength = value;
            }
        }

        [XmlIgnore]
        public bool ModeratorPinLengthSpecified { get; set; }

        private bool _enableConferenceEndDateRestriction;

        [XmlElement(ElementName = "enableConferenceEndDateRestriction", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        public bool EnableConferenceEndDateRestriction
        {
            get => _enableConferenceEndDateRestriction;
            set
            {
                EnableConferenceEndDateRestrictionSpecified = true;
                _enableConferenceEndDateRestriction = value;
            }
        }

        [XmlIgnore]
        public bool EnableConferenceEndDateRestrictionSpecified { get; set; }

        private int _conferenceEndDateRestrictionMonths;

        [XmlElement(ElementName = "conferenceEndDateRestrictionMonths", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        [MinInclusive(1)]
        [MaxInclusive(99)]
        public int ConferenceEndDateRestrictionMonths
        {
            get => _conferenceEndDateRestrictionMonths;
            set
            {
                ConferenceEndDateRestrictionMonthsSpecified = true;
                _conferenceEndDateRestrictionMonths = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceEndDateRestrictionMonthsSpecified { get; set; }

        private bool _deleteExpiredConferencesAfterHoldPeriod;

        [XmlElement(ElementName = "deleteExpiredConferencesAfterHoldPeriod", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        public bool DeleteExpiredConferencesAfterHoldPeriod
        {
            get => _deleteExpiredConferencesAfterHoldPeriod;
            set
            {
                DeleteExpiredConferencesAfterHoldPeriodSpecified = true;
                _deleteExpiredConferencesAfterHoldPeriod = value;
            }
        }

        [XmlIgnore]
        public bool DeleteExpiredConferencesAfterHoldPeriodSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingExpiredConferenceHoldPeriodDays _expiredConferenceHoldPeriodDays;

        [XmlElement(ElementName = "expiredConferenceHoldPeriodDays", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingExpiredConferenceHoldPeriodDays ExpiredConferenceHoldPeriodDays
        {
            get => _expiredConferenceHoldPeriodDays;
            set
            {
                ExpiredConferenceHoldPeriodDaysSpecified = true;
                _expiredConferenceHoldPeriodDays = value;
            }
        }

        [XmlIgnore]
        public bool ExpiredConferenceHoldPeriodDaysSpecified { get; set; }

        private string _recordingWebAppURL;

        [XmlElement(ElementName = "recordingWebAppURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RecordingWebAppURL
        {
            get => _recordingWebAppURL;
            set
            {
                RecordingWebAppURLSpecified = true;
                _recordingWebAppURL = value;
            }
        }

        [XmlIgnore]
        public bool RecordingWebAppURLSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingRecordingFileFormat _recordingFileFormat;

        [XmlElement(ElementName = "recordingFileFormat", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingRecordingFileFormat RecordingFileFormat
        {
            get => _recordingFileFormat;
            set
            {
                RecordingFileFormatSpecified = true;
                _recordingFileFormat = value;
            }
        }

        [XmlIgnore]
        public bool RecordingFileFormatSpecified { get; set; }

        private bool _terminateAfterGracePeriod;

        [XmlElement(ElementName = "terminateAfterGracePeriod", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        public bool TerminateAfterGracePeriod
        {
            get => _terminateAfterGracePeriod;
            set
            {
                TerminateAfterGracePeriodSpecified = true;
                _terminateAfterGracePeriod = value;
            }
        }

        [XmlIgnore]
        public bool TerminateAfterGracePeriodSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration _conferenceGracePeriodMinutes;

        [XmlElement(ElementName = "conferenceGracePeriodMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration ConferenceGracePeriodMinutes
        {
            get => _conferenceGracePeriodMinutes;
            set
            {
                ConferenceGracePeriodMinutesSpecified = true;
                _conferenceGracePeriodMinutes = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceGracePeriodMinutesSpecified { get; set; }

        private int _conferenceParticipantEarlyEntryMinutes;

        [XmlElement(ElementName = "conferenceParticipantEarlyEntryMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        [MinInclusive(0)]
        [MaxInclusive(15)]
        public int ConferenceParticipantEarlyEntryMinutes
        {
            get => _conferenceParticipantEarlyEntryMinutes;
            set
            {
                ConferenceParticipantEarlyEntryMinutesSpecified = true;
                _conferenceParticipantEarlyEntryMinutes = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceParticipantEarlyEntryMinutesSpecified { get; set; }

        private bool _enableConferenceExpiryNotification;

        [XmlElement(ElementName = "enableConferenceExpiryNotification", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        public bool EnableConferenceExpiryNotification
        {
            get => _enableConferenceExpiryNotification;
            set
            {
                EnableConferenceExpiryNotificationSpecified = true;
                _enableConferenceExpiryNotification = value;
            }
        }

        [XmlIgnore]
        public bool EnableConferenceExpiryNotificationSpecified { get; set; }

        private bool _enableActiveConferenceNotification;

        [XmlElement(ElementName = "enableActiveConferenceNotification", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        public bool EnableActiveConferenceNotification
        {
            get => _enableActiveConferenceNotification;
            set
            {
                EnableActiveConferenceNotificationSpecified = true;
                _enableActiveConferenceNotification = value;
            }
        }

        [XmlIgnore]
        public bool EnableActiveConferenceNotificationSpecified { get; set; }

        private string _conferenceFromAddress;

        [XmlElement(ElementName = "conferenceFromAddress", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26251")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ConferenceFromAddress
        {
            get => _conferenceFromAddress;
            set
            {
                ConferenceFromAddressSpecified = true;
                _conferenceFromAddress = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceFromAddressSpecified { get; set; }

    }
}
