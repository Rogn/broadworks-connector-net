using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the session admission control settings for the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15134""}]")]
    public class SystemSessionAdmissionControlModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _countLongConnectionsToMediaServer;

        [XmlElement(ElementName = "countLongConnectionsToMediaServer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15134")]
        public bool CountLongConnectionsToMediaServer
        {
            get => _countLongConnectionsToMediaServer;
            set
            {
                CountLongConnectionsToMediaServerSpecified = true;
                _countLongConnectionsToMediaServer = value;
            }
        }

        [XmlIgnore]
        public bool CountLongConnectionsToMediaServerSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SessionAdmissionControlForMusicOnHoldType _sacHandlingForMoH;

        [XmlElement(ElementName = "sacHandlingForMoH", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15134")]
        public BroadWorksConnector.Ocip.Models.SessionAdmissionControlForMusicOnHoldType SacHandlingForMoH
        {
            get => _sacHandlingForMoH;
            set
            {
                SacHandlingForMoHSpecified = true;
                _sacHandlingForMoH = value;
            }
        }

        [XmlIgnore]
        public bool SacHandlingForMoHSpecified { get; set; }

        private bool _blockVMDepositDueToSACLimits;

        [XmlElement(ElementName = "blockVMDepositDueToSACLimits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15134")]
        public bool BlockVMDepositDueToSACLimits
        {
            get => _blockVMDepositDueToSACLimits;
            set
            {
                BlockVMDepositDueToSACLimitsSpecified = true;
                _blockVMDepositDueToSACLimits = value;
            }
        }

        [XmlIgnore]
        public bool BlockVMDepositDueToSACLimitsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SessionAdmissionControlCodecSelectionPolicyType _sacCodecSelectionPolicy;

        [XmlElement(ElementName = "sacCodecSelectionPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15134")]
        public BroadWorksConnector.Ocip.Models.SessionAdmissionControlCodecSelectionPolicyType SacCodecSelectionPolicy
        {
            get => _sacCodecSelectionPolicy;
            set
            {
                SacCodecSelectionPolicySpecified = true;
                _sacCodecSelectionPolicy = value;
            }
        }

        [XmlIgnore]
        public bool SacCodecSelectionPolicySpecified { get; set; }

        private bool _countCallToMobileNumberForSACSubscriber;

        [XmlElement(ElementName = "countCallToMobileNumberForSACSubscriber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15134")]
        public bool CountCallToMobileNumberForSACSubscriber
        {
            get => _countCallToMobileNumberForSACSubscriber;
            set
            {
                CountCallToMobileNumberForSACSubscriberSpecified = true;
                _countCallToMobileNumberForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        public bool CountCallToMobileNumberForSACSubscriberSpecified { get; set; }

        private bool _countBWAnywhereForSACSubscriber;

        [XmlElement(ElementName = "countBWAnywhereForSACSubscriber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15134")]
        public bool CountBWAnywhereForSACSubscriber
        {
            get => _countBWAnywhereForSACSubscriber;
            set
            {
                CountBWAnywhereForSACSubscriberSpecified = true;
                _countBWAnywhereForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        public bool CountBWAnywhereForSACSubscriberSpecified { get; set; }

        private bool _countROForSACSubscriber;

        [XmlElement(ElementName = "countROForSACSubscriber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15134")]
        public bool CountROForSACSubscriber
        {
            get => _countROForSACSubscriber;
            set
            {
                CountROForSACSubscriberSpecified = true;
                _countROForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        public bool CountROForSACSubscriberSpecified { get; set; }

        private bool _excludeBWMobilityForSACSubscriber;

        [XmlElement(ElementName = "excludeBWMobilityForSACSubscriber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15134")]
        public bool ExcludeBWMobilityForSACSubscriber
        {
            get => _excludeBWMobilityForSACSubscriber;
            set
            {
                ExcludeBWMobilityForSACSubscriberSpecified = true;
                _excludeBWMobilityForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        public bool ExcludeBWMobilityForSACSubscriberSpecified { get; set; }

    }
}
