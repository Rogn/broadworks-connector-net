using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserDirectRouteGetRequest.
    /// Contains the direct route setting and the list of DTGs/Trunk Identities assigned to a user.
    /// <see cref="UserDirectRouteGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4e1b40cd187e65e0dc647394b1e74e3c:57""}]")]
    public class UserDirectRouteGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.DirectRouteOutgoingDTGPolicy _outgoingDTGPolicy;

        [XmlElement(ElementName = "outgoingDTGPolicy", IsNullable = false, Namespace = "")]
        [Group(@"4e1b40cd187e65e0dc647394b1e74e3c:57")]
        public BroadWorksConnector.Ocip.Models.DirectRouteOutgoingDTGPolicy OutgoingDTGPolicy
        {
            get => _outgoingDTGPolicy;
            set
            {
                OutgoingDTGPolicySpecified = true;
                _outgoingDTGPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool OutgoingDTGPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DirectRouteOutgoingTrunkIdentityPolicy _outgoingTrunkIdentityPolicy;

        [XmlElement(ElementName = "outgoingTrunkIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"4e1b40cd187e65e0dc647394b1e74e3c:57")]
        public BroadWorksConnector.Ocip.Models.DirectRouteOutgoingTrunkIdentityPolicy OutgoingTrunkIdentityPolicy
        {
            get => _outgoingTrunkIdentityPolicy;
            set
            {
                OutgoingTrunkIdentityPolicySpecified = true;
                _outgoingTrunkIdentityPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool OutgoingTrunkIdentityPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DirectRouteIdentifiers _directRouteIdentityList;

        [XmlElement(ElementName = "directRouteIdentityList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4e1b40cd187e65e0dc647394b1e74e3c:57")]
        public BroadWorksConnector.Ocip.Models.DirectRouteIdentifiers DirectRouteIdentityList
        {
            get => _directRouteIdentityList;
            set
            {
                DirectRouteIdentityListSpecified = true;
                _directRouteIdentityList = value;
            }
        }

        [XmlIgnore]
        protected bool DirectRouteIdentityListSpecified { get; set; }

    }
}
