using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express Profile Type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CommPilotExpressProfile
    {
        [XmlEnum(Name = "Available In Office")]
        AvailableInOffice,
        [XmlEnum(Name = "Available Out Of Office")]
        AvailableOutOfOffice,
        [XmlEnum(Name = "Busy")]
        Busy,
        [XmlEnum(Name = "Unavailable")]
        Unavailable,
    }
}
