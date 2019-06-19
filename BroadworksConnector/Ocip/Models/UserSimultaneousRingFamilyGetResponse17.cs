using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSimultaneousRingFamilyGetRequest17.
    /// Contains a criteria table wich column heading: "Is Active", "Criteria Name", "Time Schedule", "Holiday Schedule", "Calls From" and "Blacklisted".
    /// <see cref="UserSimultaneousRingFamilyGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""239d22a382d3190a183f2ff4efdc404f:136""}]")]
    public class UserSimultaneousRingFamilyGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"239d22a382d3190a183f2ff4efdc404f:136")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }

        private bool _doNotRingIfOnCall;

        [XmlElement(ElementName = "doNotRingIfOnCall", IsNullable = false, Namespace = "")]
        [Group(@"239d22a382d3190a183f2ff4efdc404f:136")]
        public bool DoNotRingIfOnCall
        {
            get => _doNotRingIfOnCall;
            set
            {
                DoNotRingIfOnCallSpecified = true;
                _doNotRingIfOnCall = value;
            }
        }

        [XmlIgnore]
        public bool DoNotRingIfOnCallSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SimultaneousRingNumber> _simultaneousRingNumber = new List<BroadWorksConnector.Ocip.Models.SimultaneousRingNumber>();

        [XmlElement(ElementName = "simultaneousRingNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"239d22a382d3190a183f2ff4efdc404f:136")]
        public List<BroadWorksConnector.Ocip.Models.SimultaneousRingNumber> SimultaneousRingNumber
        {
            get => _simultaneousRingNumber;
            set
            {
                SimultaneousRingNumberSpecified = true;
                _simultaneousRingNumber = value;
            }
        }

        [XmlIgnore]
        public bool SimultaneousRingNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        [Group(@"239d22a382d3190a183f2ff4efdc404f:136")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CriteriaTable
        {
            get => _criteriaTable;
            set
            {
                CriteriaTableSpecified = true;
                _criteriaTable = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaTableSpecified { get; set; }

    }
}
