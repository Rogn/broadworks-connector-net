using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for an administrator's first name.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:95""}]")]
    public class SearchCriteriaAdminFirstName : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private BroadWorksConnector.Ocip.Models.SearchMode _mode;

        [XmlElement(ElementName = "mode", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:95")]
        public BroadWorksConnector.Ocip.Models.SearchMode Mode
        {
            get => _mode;
            set
            {
                ModeSpecified = true;
                _mode = value;
            }
        }

        [XmlIgnore]
        public bool ModeSpecified { get; set; }

        private string _value;

        [XmlElement(ElementName = "value", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:95")]
        [MinLength(1)]
        [MaxLength(30)]
        public string Value
        {
            get => _value;
            set
            {
                ValueSpecified = true;
                _value = value;
            }
        }

        [XmlIgnore]
        public bool ValueSpecified { get; set; }

        private bool _isCaseInsensitive;

        [XmlElement(ElementName = "isCaseInsensitive", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:95")]
        public bool IsCaseInsensitive
        {
            get => _isCaseInsensitive;
            set
            {
                IsCaseInsensitiveSpecified = true;
                _isCaseInsensitive = value;
            }
        }

        [XmlIgnore]
        public bool IsCaseInsensitiveSpecified { get; set; }

    }
}
