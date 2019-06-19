using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Access Device Monitor system parameters.
    /// The response is either SystemAccessDeviceMonitorParametersGetResponse or ErrorResponse.
    /// <see cref="SystemAccessDeviceMonitorParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1202""}]")]
    public class SystemAccessDeviceMonitorParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
