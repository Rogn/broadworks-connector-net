using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk group endpoint that can have multiple contacts.
    /// alternateTrunkIdentityDomain is only used in XS mode and the AS when deployed in IMS mode.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// alternateTrunkIdentityDomain
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4209""}]")]
    public class TrunkAddressingMultipleContactRead21
    {

        private BroadWorksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointRead _trunkGroupDeviceEndpoint;

        [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4209")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointRead TrunkGroupDeviceEndpoint
        {
            get => _trunkGroupDeviceEndpoint;
            set
            {
                TrunkGroupDeviceEndpointSpecified = true;
                _trunkGroupDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupDeviceEndpointSpecified { get; set; }

        private string _enterpriseTrunkName;

        [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4209")]
        [MinLength(1)]
        [MaxLength(30)]
        public string EnterpriseTrunkName
        {
            get => _enterpriseTrunkName;
            set
            {
                EnterpriseTrunkNameSpecified = true;
                _enterpriseTrunkName = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseTrunkNameSpecified { get; set; }

        private string _alternateTrunkIdentity;

        [XmlElement(ElementName = "alternateTrunkIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4209")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AlternateTrunkIdentity
        {
            get => _alternateTrunkIdentity;
            set
            {
                AlternateTrunkIdentitySpecified = true;
                _alternateTrunkIdentity = value;
            }
        }

        [XmlIgnore]
        public bool AlternateTrunkIdentitySpecified { get; set; }

        private string _alternateTrunkIdentityDomain;

        [XmlElement(ElementName = "alternateTrunkIdentityDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4209")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AlternateTrunkIdentityDomain
        {
            get => _alternateTrunkIdentityDomain;
            set
            {
                AlternateTrunkIdentityDomainSpecified = true;
                _alternateTrunkIdentityDomain = value;
            }
        }

        [XmlIgnore]
        public bool AlternateTrunkIdentityDomainSpecified { get; set; }

    }
}
