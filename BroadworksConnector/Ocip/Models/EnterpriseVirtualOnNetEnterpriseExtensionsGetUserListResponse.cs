using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to   EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListRequest.
    /// Contains a table with column headings : "Group Id", "Last Name", "First Name", "Phone Number", "Extension",
    /// "Virtual On-Net Call Type" in a row for each user.
    /// <see cref="EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""179b744b0183abe614e8c32c17c96b7e:79""}]")]
    public class EnterpriseVirtualOnNetEnterpriseExtensionsGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:79")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserTable
        {
            get => _userTable;
            set
            {
                UserTableSpecified = true;
                _userTable = value;
            }
        }

        [XmlIgnore]
        public bool UserTableSpecified { get; set; }

    }
}
