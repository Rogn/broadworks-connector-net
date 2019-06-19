using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a 6 column table with column headings 'Instance', 'Realm',  'ApplicationID', 'Identity, 'Priority', and 'Weight'.  One row is present for each Diameter Routing Peer.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2496""}]")]
    public class SystemBwDiameterRoutingPeerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _routingPeerTable;

        [XmlElement(ElementName = "routingPeerTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2496")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RoutingPeerTable
        {
            get => _routingPeerTable;
            set
            {
                RoutingPeerTableSpecified = true;
                _routingPeerTable = value;
            }
        }

        [XmlIgnore]
        public bool RoutingPeerTableSpecified { get; set; }

    }
}
