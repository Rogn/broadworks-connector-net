using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCustomRingbackUserGetCriteriaRequest21.
    /// <see cref="UserCustomRingbackUserGetCriteriaRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""80acd3e6f38b9682dcefe7cd473392c3:218""}]")]
    public class UserCustomRingbackUserGetCriteriaResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public BroadWorksConnector.Ocip.Models.TimeSchedule TimeSchedule
        {
            get => _timeSchedule;
            set
            {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        public bool TimeScheduleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        public bool HolidayScheduleSpecified { get; set; }

        private bool _blacklisted;

        [XmlElement(ElementName = "blacklisted", IsNullable = false, Namespace = "")]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public bool Blacklisted
        {
            get => _blacklisted;
            set
            {
                BlacklistedSpecified = true;
                _blacklisted = value;
            }
        }

        [XmlIgnore]
        public bool BlacklistedSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CriteriaFromDn _fromDnCriteria;

        [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public BroadWorksConnector.Ocip.Models.CriteriaFromDn FromDnCriteria
        {
            get => _fromDnCriteria;
            set
            {
                FromDnCriteriaSpecified = true;
                _fromDnCriteria = value;
            }
        }

        [XmlIgnore]
        public bool FromDnCriteriaSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CallToNumber> _callToNumber = new List<BroadWorksConnector.Ocip.Models.CallToNumber>();

        [XmlElement(ElementName = "callToNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public List<BroadWorksConnector.Ocip.Models.CallToNumber> CallToNumber
        {
            get => _callToNumber;
            set
            {
                CallToNumberSpecified = true;
                _callToNumber = value;
            }
        }

        [XmlIgnore]
        public bool CallToNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioSelection;

        [XmlElement(ElementName = "audioSelection", IsNullable = false, Namespace = "")]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection AudioSelection
        {
            get => _audioSelection;
            set
            {
                AudioSelectionSpecified = true;
                _audioSelection = value;
            }
        }

        [XmlIgnore]
        public bool AudioSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey AudioFile
        {
            get => _audioFile;
            set
            {
                AudioFileSpecified = true;
                _audioFile = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileSpecified { get; set; }

        private string _audioFileUrl;

        [XmlElement(ElementName = "audioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AudioFileUrl
        {
            get => _audioFileUrl;
            set
            {
                AudioFileUrlSpecified = true;
                _audioFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileUrlSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoSelection;

        [XmlElement(ElementName = "videoSelection", IsNullable = false, Namespace = "")]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection VideoSelection
        {
            get => _videoSelection;
            set
            {
                VideoSelectionSpecified = true;
                _videoSelection = value;
            }
        }

        [XmlIgnore]
        public bool VideoSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey VideoFile
        {
            get => _videoFile;
            set
            {
                VideoFileSpecified = true;
                _videoFile = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileSpecified { get; set; }

        private string _videoFileUrl;

        [XmlElement(ElementName = "videoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VideoFileUrl
        {
            get => _videoFileUrl;
            set
            {
                VideoFileUrlSpecified = true;
                _videoFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileUrlSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingAudioSelection;

        [XmlElement(ElementName = "callWaitingAudioSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection CallWaitingAudioSelection
        {
            get => _callWaitingAudioSelection;
            set
            {
                CallWaitingAudioSelectionSpecified = true;
                _callWaitingAudioSelection = value;
            }
        }

        [XmlIgnore]
        public bool CallWaitingAudioSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _callWaitingAudioFile;

        [XmlElement(ElementName = "callWaitingAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey CallWaitingAudioFile
        {
            get => _callWaitingAudioFile;
            set
            {
                CallWaitingAudioFileSpecified = true;
                _callWaitingAudioFile = value;
            }
        }

        [XmlIgnore]
        public bool CallWaitingAudioFileSpecified { get; set; }

        private string _callWaitingAudioFileUrl;

        [XmlElement(ElementName = "callWaitingAudioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        [MinLength(1)]
        [MaxLength(256)]
        public string CallWaitingAudioFileUrl
        {
            get => _callWaitingAudioFileUrl;
            set
            {
                CallWaitingAudioFileUrlSpecified = true;
                _callWaitingAudioFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool CallWaitingAudioFileUrlSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingVideoSelection;

        [XmlElement(ElementName = "callWaitingVideoSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection CallWaitingVideoSelection
        {
            get => _callWaitingVideoSelection;
            set
            {
                CallWaitingVideoSelectionSpecified = true;
                _callWaitingVideoSelection = value;
            }
        }

        [XmlIgnore]
        public bool CallWaitingVideoSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _callWaitingVideoFile;

        [XmlElement(ElementName = "callWaitingVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey CallWaitingVideoFile
        {
            get => _callWaitingVideoFile;
            set
            {
                CallWaitingVideoFileSpecified = true;
                _callWaitingVideoFile = value;
            }
        }

        [XmlIgnore]
        public bool CallWaitingVideoFileSpecified { get; set; }

        private string _callWaitingVideoFileUrl;

        [XmlElement(ElementName = "callWaitingVideoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"80acd3e6f38b9682dcefe7cd473392c3:218")]
        [MinLength(1)]
        [MaxLength(256)]
        public string CallWaitingVideoFileUrl
        {
            get => _callWaitingVideoFileUrl;
            set
            {
                CallWaitingVideoFileUrlSpecified = true;
                _callWaitingVideoFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool CallWaitingVideoFileUrlSpecified { get; set; }

    }
}
