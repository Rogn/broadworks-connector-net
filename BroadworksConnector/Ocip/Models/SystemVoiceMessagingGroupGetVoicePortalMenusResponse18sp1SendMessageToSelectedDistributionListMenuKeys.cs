using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27782""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SendMessageToSelectedDistributionListMenuKeys
    {

        private string _confirmSendingToDistributionList;

        [XmlElement(ElementName = "confirmSendingToDistributionList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27782")]
        [Length(1)]
        [RegularExpression(@"\*|#")]
        public string ConfirmSendingToDistributionList
        {
            get => _confirmSendingToDistributionList;
            set
            {
                ConfirmSendingToDistributionListSpecified = true;
                _confirmSendingToDistributionList = value;
            }
        }

        [XmlIgnore]
        public bool ConfirmSendingToDistributionListSpecified { get; set; }

        private string _cancelSendingToDistributionList;

        [XmlElement(ElementName = "cancelSendingToDistributionList", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27782")]
        [Length(1)]
        [RegularExpression(@"\*|#")]
        public string CancelSendingToDistributionList
        {
            get => _cancelSendingToDistributionList;
            set
            {
                CancelSendingToDistributionListSpecified = true;
                _cancelSendingToDistributionList = value;
            }
        }

        [XmlIgnore]
        public bool CancelSendingToDistributionListSpecified { get; set; }

    }
}
