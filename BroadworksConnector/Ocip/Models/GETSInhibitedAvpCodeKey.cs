using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The GETS inhibited Avp code entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18534""}]")]
    public class GETSInhibitedAvpCodeKey
    {

        private int _avpCode;

        [XmlElement(ElementName = "avpCode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18534")]
        public int AvpCode
        {
            get => _avpCode;
            set
            {
                AvpCodeSpecified = true;
                _avpCode = value;
            }
        }

        [XmlIgnore]
        public bool AvpCodeSpecified { get; set; }

        private int _vendorId;

        [XmlElement(ElementName = "vendorId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18534")]
        public int VendorId
        {
            get => _vendorId;
            set
            {
                VendorIdSpecified = true;
                _vendorId = value;
            }
        }

        [XmlIgnore]
        public bool VendorIdSpecified { get; set; }

    }
}
