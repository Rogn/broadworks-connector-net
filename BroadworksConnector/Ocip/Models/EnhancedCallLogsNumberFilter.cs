using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Filter criteria based on the called number or number called.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:29"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:30""}]}]")]
    public class EnhancedCallLogsNumberFilter
    {

        private List<BroadWorksConnector.Ocip.Models.BasicCallType> _includeBasicCallType = new List<BroadWorksConnector.Ocip.Models.BasicCallType>();

        [XmlElement(ElementName = "includeBasicCallType", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:30")]
        public List<BroadWorksConnector.Ocip.Models.BasicCallType> IncludeBasicCallType
        {
            get => _includeBasicCallType;
            set
            {
                IncludeBasicCallTypeSpecified = true;
                _includeBasicCallType = value;
            }
        }

        [XmlIgnore]
        public bool IncludeBasicCallTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CallCategory> _includeCallCategory = new List<BroadWorksConnector.Ocip.Models.CallCategory>();

        [XmlElement(ElementName = "includeCallCategory", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:30")]
        public List<BroadWorksConnector.Ocip.Models.CallCategory> IncludeCallCategory
        {
            get => _includeCallCategory;
            set
            {
                IncludeCallCategorySpecified = true;
                _includeCallCategory = value;
            }
        }

        [XmlIgnore]
        public bool IncludeCallCategorySpecified { get; set; }

        private List<string> _includeConfigurableCallType = new List<string>();

        [XmlElement(ElementName = "includeConfigurableCallType", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:30")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> IncludeConfigurableCallType
        {
            get => _includeConfigurableCallType;
            set
            {
                IncludeConfigurableCallTypeSpecified = true;
                _includeConfigurableCallType = value;
            }
        }

        [XmlIgnore]
        public bool IncludeConfigurableCallTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaDialedNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI>();

        [XmlElement(ElementName = "searchCriteriaDialedNumber", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:30")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaDialedNumber
        {
            get => _searchCriteriaDialedNumber;
            set
            {
                SearchCriteriaDialedNumberSpecified = true;
                _searchCriteriaDialedNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDialedNumberSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaCalledNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI>();

        [XmlElement(ElementName = "searchCriteriaCalledNumber", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:30")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaCalledNumber
        {
            get => _searchCriteriaCalledNumber;
            set
            {
                SearchCriteriaCalledNumberSpecified = true;
                _searchCriteriaCalledNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaCalledNumberSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaNetworkTranslatedNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI>();

        [XmlElement(ElementName = "searchCriteriaNetworkTranslatedNumber", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:30")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaNetworkTranslatedNumber
        {
            get => _searchCriteriaNetworkTranslatedNumber;
            set
            {
                SearchCriteriaNetworkTranslatedNumberSpecified = true;
                _searchCriteriaNetworkTranslatedNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaNetworkTranslatedNumberSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> _searchCriteriaCallingPresentationNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI>();

        [XmlElement(ElementName = "searchCriteriaCallingPresentationNumber", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:30")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaCallingPresentationNumber
        {
            get => _searchCriteriaCallingPresentationNumber;
            set
            {
                SearchCriteriaCallingPresentationNumberSpecified = true;
                _searchCriteriaCallingPresentationNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaCallingPresentationNumberSpecified { get; set; }

    }
}
