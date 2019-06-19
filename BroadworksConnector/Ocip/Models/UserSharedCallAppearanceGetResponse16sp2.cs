using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSharedCallAppearanceGetRequest.
    /// The endpointTable contains columns:
    /// "Device Level", "Device Name", "Device Type", "Line/Port", "SIP Contact", "Port Number". "Private Identity" .
    /// The following columns are only returned in XS data mode:
    /// "Private Identity"
    /// 
    /// The "Device Level" column contains one of the AccessDeviceLevel enumerated constants.
    /// Port numbers are only used by devices with static line ordering.
    /// 
    /// The following elements are only used in AS data mode:
    /// enableCallParkNotification
    /// 
    /// Replaced by: UserSharedCallAppearanceGetResponse21sp1.
    /// <see cref="UserSharedCallAppearanceGetRequest"/>
    /// <see cref="UserSharedCallAppearanceGetResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7729""}]")]
    public class UserSharedCallAppearanceGetResponse16sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _alertAllAppearancesForClickToDialCalls;

        [XmlElement(ElementName = "alertAllAppearancesForClickToDialCalls", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7729")]
        public bool AlertAllAppearancesForClickToDialCalls
        {
            get => _alertAllAppearancesForClickToDialCalls;
            set
            {
                AlertAllAppearancesForClickToDialCallsSpecified = true;
                _alertAllAppearancesForClickToDialCalls = value;
            }
        }

        [XmlIgnore]
        public bool AlertAllAppearancesForClickToDialCallsSpecified { get; set; }

        private bool _alertAllAppearancesForGroupPagingCalls;

        [XmlElement(ElementName = "alertAllAppearancesForGroupPagingCalls", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7729")]
        public bool AlertAllAppearancesForGroupPagingCalls
        {
            get => _alertAllAppearancesForGroupPagingCalls;
            set
            {
                AlertAllAppearancesForGroupPagingCallsSpecified = true;
                _alertAllAppearancesForGroupPagingCalls = value;
            }
        }

        [XmlIgnore]
        public bool AlertAllAppearancesForGroupPagingCallsSpecified { get; set; }

        private int _maxAppearances;

        [XmlElement(ElementName = "maxAppearances", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7729")]
        public int MaxAppearances
        {
            get => _maxAppearances;
            set
            {
                MaxAppearancesSpecified = true;
                _maxAppearances = value;
            }
        }

        [XmlIgnore]
        public bool MaxAppearancesSpecified { get; set; }

        private bool _allowSCACallRetrieve;

        [XmlElement(ElementName = "allowSCACallRetrieve", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7729")]
        public bool AllowSCACallRetrieve
        {
            get => _allowSCACallRetrieve;
            set
            {
                AllowSCACallRetrieveSpecified = true;
                _allowSCACallRetrieve = value;
            }
        }

        [XmlIgnore]
        public bool AllowSCACallRetrieveSpecified { get; set; }

        private bool _enableMultipleCallArrangement;

        [XmlElement(ElementName = "enableMultipleCallArrangement", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7729")]
        public bool EnableMultipleCallArrangement
        {
            get => _enableMultipleCallArrangement;
            set
            {
                EnableMultipleCallArrangementSpecified = true;
                _enableMultipleCallArrangement = value;
            }
        }

        [XmlIgnore]
        public bool EnableMultipleCallArrangementSpecified { get; set; }

        private bool _multipleCallArrangementIsActive;

        [XmlElement(ElementName = "multipleCallArrangementIsActive", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7729")]
        public bool MultipleCallArrangementIsActive
        {
            get => _multipleCallArrangementIsActive;
            set
            {
                MultipleCallArrangementIsActiveSpecified = true;
                _multipleCallArrangementIsActive = value;
            }
        }

        [XmlIgnore]
        public bool MultipleCallArrangementIsActiveSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _endpointTable;

        [XmlElement(ElementName = "endpointTable", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7729")]
        public BroadWorksConnector.Ocip.Models.C.OCITable EndpointTable
        {
            get => _endpointTable;
            set
            {
                EndpointTableSpecified = true;
                _endpointTable = value;
            }
        }

        [XmlIgnore]
        public bool EndpointTableSpecified { get; set; }

        private bool _allowBridgingBetweenLocations;

        [XmlElement(ElementName = "allowBridgingBetweenLocations", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7729")]
        public bool AllowBridgingBetweenLocations
        {
            get => _allowBridgingBetweenLocations;
            set
            {
                AllowBridgingBetweenLocationsSpecified = true;
                _allowBridgingBetweenLocations = value;
            }
        }

        [XmlIgnore]
        public bool AllowBridgingBetweenLocationsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SharedCallAppearanceBridgeWarningTone _bridgeWarningTone;

        [XmlElement(ElementName = "bridgeWarningTone", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7729")]
        public BroadWorksConnector.Ocip.Models.SharedCallAppearanceBridgeWarningTone BridgeWarningTone
        {
            get => _bridgeWarningTone;
            set
            {
                BridgeWarningToneSpecified = true;
                _bridgeWarningTone = value;
            }
        }

        [XmlIgnore]
        public bool BridgeWarningToneSpecified { get; set; }

        private bool _enableCallParkNotification;

        [XmlElement(ElementName = "enableCallParkNotification", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7729")]
        public bool EnableCallParkNotification
        {
            get => _enableCallParkNotification;
            set
            {
                EnableCallParkNotificationSpecified = true;
                _enableCallParkNotification = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallParkNotificationSpecified { get; set; }

    }
}
