using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDeviceTypeTagSetGetRequest.
    /// <see cref="GroupDeviceTypeTagSetGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:3604""}]")]
    public class GroupDeviceTypeTagSetGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _tagSetName;

        [XmlElement(ElementName = "tagSetName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3604")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TagSetName
        {
            get => _tagSetName;
            set
            {
                TagSetNameSpecified = true;
                _tagSetName = value;
            }
        }

        [XmlIgnore]
        public bool TagSetNameSpecified { get; set; }

    }
}
