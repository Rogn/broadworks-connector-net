using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is a response to DeviceManagementFileAuthLocationGetRequest21.
    /// Return the address and credentials of the File Repository hosting the requested access device file.
    /// Also return the file name and path on the File Repository.
    /// Also returns the status of the file authentication.
    /// Replaced by: DeviceManagementFileAuthLocationGetResponse21sp1.
    /// <see cref="DeviceManagementFileAuthLocationGetRequest21"/>
    /// <see cref="DeviceManagementFileAuthLocationGetResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:33017""}]")]
    public class DeviceManagementFileAuthLocationGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.DeviceManagementFileAuthenticationStatus _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementFileAuthenticationStatus Status
        {
            get => _status;
            set
            {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        public bool StatusSpecified { get; set; }

        private string _fileRepositoryUserName;

        [XmlElement(ElementName = "fileRepositoryUserName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        [MinLength(1)]
        [MaxLength(30)]
        public string FileRepositoryUserName
        {
            get => _fileRepositoryUserName;
            set
            {
                FileRepositoryUserNameSpecified = true;
                _fileRepositoryUserName = value;
            }
        }

        [XmlIgnore]
        public bool FileRepositoryUserNameSpecified { get; set; }

        private string _fileRepositoryPassword;

        [XmlElement(ElementName = "fileRepositoryPassword", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        [MinLength(1)]
        [MaxLength(30)]
        public string FileRepositoryPassword
        {
            get => _fileRepositoryPassword;
            set
            {
                FileRepositoryPasswordSpecified = true;
                _fileRepositoryPassword = value;
            }
        }

        [XmlIgnore]
        public bool FileRepositoryPasswordSpecified { get; set; }

        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
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

        private string _remoteFileFormat;

        [XmlElement(ElementName = "remoteFileFormat", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        [MinLength(1)]
        [MaxLength(128)]
        public string RemoteFileFormat
        {
            get => _remoteFileFormat;
            set
            {
                RemoteFileFormatSpecified = true;
                _remoteFileFormat = value;
            }
        }

        [XmlIgnore]
        public bool RemoteFileFormatSpecified { get; set; }

        private int _portNumber;

        [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int PortNumber
        {
            get => _portNumber;
            set
            {
                PortNumberSpecified = true;
                _portNumber = value;
            }
        }

        [XmlIgnore]
        public bool PortNumberSpecified { get; set; }

        private string _rootDirectory;

        [XmlElement(ElementName = "rootDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RootDirectory
        {
            get => _rootDirectory;
            set
            {
                RootDirectorySpecified = true;
                _rootDirectory = value;
            }
        }

        [XmlIgnore]
        public bool RootDirectorySpecified { get; set; }

        private string _cpeFileDirectory;

        [XmlElement(ElementName = "cpeFileDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        [MinLength(1)]
        [MaxLength(256)]
        public string CpeFileDirectory
        {
            get => _cpeFileDirectory;
            set
            {
                CpeFileDirectorySpecified = true;
                _cpeFileDirectory = value;
            }
        }

        [XmlIgnore]
        public bool CpeFileDirectorySpecified { get; set; }

        private bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        public bool Secure
        {
            get => _secure;
            set
            {
                SecureSpecified = true;
                _secure = value;
            }
        }

        [XmlIgnore]
        public bool SecureSpecified { get; set; }

        private bool _macInNonRequestURI;

        [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        public bool MacInNonRequestURI
        {
            get => _macInNonRequestURI;
            set
            {
                MacInNonRequestURISpecified = true;
                _macInNonRequestURI = value;
            }
        }

        [XmlIgnore]
        public bool MacInNonRequestURISpecified { get; set; }

        private string _macFormatInNonRequestURI;

        [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        [MinLength(1)]
        [MaxLength(256)]
        public string MacFormatInNonRequestURI
        {
            get => _macFormatInNonRequestURI;
            set
            {
                MacFormatInNonRequestURISpecified = true;
                _macFormatInNonRequestURI = value;
            }
        }

        [XmlIgnore]
        public bool MacFormatInNonRequestURISpecified { get; set; }

        private bool _useHttpDigestAuthentication;

        [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        public bool UseHttpDigestAuthentication
        {
            get => _useHttpDigestAuthentication;
            set
            {
                UseHttpDigestAuthenticationSpecified = true;
                _useHttpDigestAuthentication = value;
            }
        }

        [XmlIgnore]
        public bool UseHttpDigestAuthenticationSpecified { get; set; }

        private bool _macBasedFileAuthentication;

        [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        public bool MacBasedFileAuthentication
        {
            get => _macBasedFileAuthentication;
            set
            {
                MacBasedFileAuthenticationSpecified = true;
                _macBasedFileAuthentication = value;
            }
        }

        [XmlIgnore]
        public bool MacBasedFileAuthenticationSpecified { get; set; }

        private bool _userNamePasswordFileAuthentication;

        [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        public bool UserNamePasswordFileAuthentication
        {
            get => _userNamePasswordFileAuthentication;
            set
            {
                UserNamePasswordFileAuthenticationSpecified = true;
                _userNamePasswordFileAuthentication = value;
            }
        }

        [XmlIgnore]
        public bool UserNamePasswordFileAuthenticationSpecified { get; set; }

        private bool _completionNotification;

        [XmlElement(ElementName = "completionNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        public bool CompletionNotification
        {
            get => _completionNotification;
            set
            {
                CompletionNotificationSpecified = true;
                _completionNotification = value;
            }
        }

        [XmlIgnore]
        public bool CompletionNotificationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceManagementFileCategory _fileCategory;

        [XmlElement(ElementName = "fileCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementFileCategory FileCategory
        {
            get => _fileCategory;
            set
            {
                FileCategorySpecified = true;
                _fileCategory = value;
            }
        }

        [XmlIgnore]
        public bool FileCategorySpecified { get; set; }

        private bool _enableCaching;

        [XmlElement(ElementName = "enableCaching", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        public bool EnableCaching
        {
            get => _enableCaching;
            set
            {
                EnableCachingSpecified = true;
                _enableCaching = value;
            }
        }

        [XmlIgnore]
        public bool EnableCachingSpecified { get; set; }

        private bool _notifyFileUpload;

        [XmlElement(ElementName = "notifyFileUpload", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33017")]
        public bool NotifyFileUpload
        {
            get => _notifyFileUpload;
            set
            {
                NotifyFileUploadSpecified = true;
                _notifyFileUpload = value;
            }
        }

        [XmlIgnore]
        public bool NotifyFileUploadSpecified { get; set; }

    }
}
