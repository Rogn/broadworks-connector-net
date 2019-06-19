using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify Outgoing Pinhole Digit Plan originating call permissions for specified digit patterns.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:2294""}]")]
    public class OutgoingPinholeDigitPlanDigitPatternOriginatingDepartmentPermissionsModify
    {

        private BroadWorksConnector.Ocip.Models.DepartmentKey _departmentKey;

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2294")]
        public BroadWorksConnector.Ocip.Models.DepartmentKey DepartmentKey
        {
            get => _departmentKey;
            set
            {
                DepartmentKeySpecified = true;
                _departmentKey = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentKeySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingPermissions _digitPatternPermissions;

        [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2294")]
        public BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingPermissions DigitPatternPermissions
        {
            get => _digitPatternPermissions;
            set
            {
                DigitPatternPermissionsSpecified = true;
                _digitPatternPermissions = value;
            }
        }

        [XmlIgnore]
        public bool DigitPatternPermissionsSpecified { get; set; }

    }
}
