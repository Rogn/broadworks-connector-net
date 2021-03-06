using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNetworkProgressionGetRequest.
    /// <see cref="SystemNetworkProgressionGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11587""}]")]
    public class SystemNetworkProgressionGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11587")]
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
        protected bool IsActiveSpecified { get; set; }

        private int _waitPeriodSeconds;

        [XmlElement(ElementName = "waitPeriodSeconds", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11587")]
        [MinInclusive(1)]
        [MaxInclusive(15)]
        public int WaitPeriodSeconds
        {
            get => _waitPeriodSeconds;
            set
            {
                WaitPeriodSecondsSpecified = true;
                _waitPeriodSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool WaitPeriodSecondsSpecified { get; set; }

    }
}
