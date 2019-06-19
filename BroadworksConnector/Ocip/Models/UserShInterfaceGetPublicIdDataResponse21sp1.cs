using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserShInterfaceGetPublicIdDataRequest21sp1.
    /// The response contains the Sh non-transparent data for the specified Public User Identity.
    /// The data also includes a userId, userType, and endpointType.
    /// The value Mobility in Endpoint Type is only applicable in AS data mode.
    /// <see cref="UserShInterfaceGetPublicIdDataRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3887""}]")]
    public class UserShInterfaceGetPublicIdDataResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3887")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UserType _userType;

        [XmlElement(ElementName = "userType", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3887")]
        public BroadWorksConnector.Ocip.Models.UserType UserType
        {
            get => _userType;
            set
            {
                UserTypeSpecified = true;
                _userType = value;
            }
        }

        [XmlIgnore]
        public bool UserTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EndpointType21sp1 _endpointType;

        [XmlElement(ElementName = "endpointType", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3887")]
        public BroadWorksConnector.Ocip.Models.EndpointType21sp1 EndpointType
        {
            get => _endpointType;
            set
            {
                EndpointTypeSpecified = true;
                _endpointType = value;
            }
        }

        [XmlIgnore]
        public bool EndpointTypeSpecified { get; set; }

        private string _sCSCFName;

        [XmlElement(ElementName = "SCSCFName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3887")]
        [MinLength(1)]
        [MaxLength(161)]
        public string SCSCFName
        {
            get => _sCSCFName;
            set
            {
                SCSCFNameSpecified = true;
                _sCSCFName = value;
            }
        }

        [XmlIgnore]
        public bool SCSCFNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.IMSUserState _iMSUserState;

        [XmlElement(ElementName = "IMSUserState", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3887")]
        public BroadWorksConnector.Ocip.Models.IMSUserState IMSUserState
        {
            get => _iMSUserState;
            set
            {
                IMSUserStateSpecified = true;
                _iMSUserState = value;
            }
        }

        [XmlIgnore]
        public bool IMSUserStateSpecified { get; set; }

    }
}
