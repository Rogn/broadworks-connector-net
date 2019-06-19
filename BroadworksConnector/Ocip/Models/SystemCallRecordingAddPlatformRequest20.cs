using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Call Recording platform.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9741e074fbfeb4c7312bfa4dfbaee3d3:101""}]")]
    public class SystemCallRecordingAddPlatformRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:101")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }

        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:101")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NetAddress
        {
            get => _netAddress;
            set
            {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        public bool NetAddressSpecified { get; set; }

        private int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:101")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int Port
        {
            get => _port;
            set
            {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        public bool PortSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaStream _mediaStream;

        [XmlElement(ElementName = "mediaStream", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:101")]
        public BroadWorksConnector.Ocip.Models.MediaStream MediaStream
        {
            get => _mediaStream;
            set
            {
                MediaStreamSpecified = true;
                _mediaStream = value;
            }
        }

        [XmlIgnore]
        public bool MediaStreamSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TransportProtocol _transportType;

        [XmlElement(ElementName = "transportType", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:101")]
        public BroadWorksConnector.Ocip.Models.TransportProtocol TransportType
        {
            get => _transportType;
            set
            {
                TransportTypeSpecified = true;
                _transportType = value;
            }
        }

        [XmlIgnore]
        public bool TransportTypeSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:101")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallRecordingPlatformSchemaVersion _schemaVersion;

        [XmlElement(ElementName = "schemaVersion", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:101")]
        public BroadWorksConnector.Ocip.Models.CallRecordingPlatformSchemaVersion SchemaVersion
        {
            get => _schemaVersion;
            set
            {
                SchemaVersionSpecified = true;
                _schemaVersion = value;
            }
        }

        [XmlIgnore]
        public bool SchemaVersionSpecified { get; set; }

        private bool _supportVideoRecording;

        [XmlElement(ElementName = "supportVideoRecording", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:101")]
        public bool SupportVideoRecording
        {
            get => _supportVideoRecording;
            set
            {
                SupportVideoRecordingSpecified = true;
                _supportVideoRecording = value;
            }
        }

        [XmlIgnore]
        public bool SupportVideoRecordingSpecified { get; set; }

    }
}
