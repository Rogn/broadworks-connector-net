using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Security Classification
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b3afea8308b7fdaab8d385357ca9c2d:275""}]")]
    public class SystemSecurityClassificationModifyClassificationRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _securityClassificationName;

        [XmlElement(ElementName = "securityClassificationName", IsNullable = false, Namespace = "")]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:275")]
        [MinLength(1)]
        [MaxLength(40)]
        public string SecurityClassificationName
        {
            get => _securityClassificationName;
            set
            {
                SecurityClassificationNameSpecified = true;
                _securityClassificationName = value;
            }
        }

        [XmlIgnore]
        public bool SecurityClassificationNameSpecified { get; set; }

        private string _newSecurityClassificationName;

        [XmlElement(ElementName = "newSecurityClassificationName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:275")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewSecurityClassificationName
        {
            get => _newSecurityClassificationName;
            set
            {
                NewSecurityClassificationNameSpecified = true;
                _newSecurityClassificationName = value;
            }
        }

        [XmlIgnore]
        public bool NewSecurityClassificationNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b3afea8308b7fdaab8d385357ca9c2d:275")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource AudioFile
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

    }
}
