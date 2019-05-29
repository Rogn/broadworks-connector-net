using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "defaultFromAddress", IsNullable = false)]
    public string DefaultFromAddress { get; set; }
    [XmlElement(ElementName = "statisticsSamplingPeriodMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes StatisticsSamplingPeriodMinutes { get; set; }
    [XmlElement(ElementName = "defaultEnableGuardTimer", IsNullable = false)]
    public bool DefaultEnableGuardTimer { get; set; }
    [XmlElement(ElementName = "defaultGuardTimerSeconds", IsNullable = false)]
    public int DefaultGuardTimerSeconds { get; set; }
    [XmlElement(ElementName = "forceAgentUnavailableOnDNDActivation", IsNullable = false)]
    public bool ForceAgentUnavailableOnDNDActivation { get; set; }
    [XmlElement(ElementName = "forceAgentUnavailableOnPersonalCalls", IsNullable = false)]
    public bool ForceAgentUnavailableOnPersonalCalls { get; set; }
    [XmlElement(ElementName = "forceAgentUnavailableOnBouncedCallLimit", IsNullable = false)]
    public bool ForceAgentUnavailableOnBouncedCallLimit { get; set; }
    [XmlElement(ElementName = "numberConsecutiveBouncedCallsToForceAgentUnavailable", IsNullable = false)]
    public int NumberConsecutiveBouncedCallsToForceAgentUnavailable { get; set; }
    [XmlElement(ElementName = "defaultPlayRingWhenOfferCall", IsNullable = false)]
    public bool DefaultPlayRingWhenOfferCall { get; set; }
    [XmlElement(ElementName = "uniformCallDistributionPolicyScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterUniformCallDistributionPolicyScope UniformCallDistributionPolicyScope { get; set; }
    [XmlElement(ElementName = "callHandlingSamplingPeriodMinutes", IsNullable = false)]
    public int CallHandlingSamplingPeriodMinutes { get; set; }
    [XmlElement(ElementName = "callHandlingMinimumSamplingSize", IsNullable = false)]
    public int CallHandlingMinimumSamplingSize { get; set; }
    [XmlElement(ElementName = "playToneToAgentForEmergencyCall", IsNullable = false)]
    public bool PlayToneToAgentForEmergencyCall { get; set; }
    [XmlElement(ElementName = "emergencyCallCLIDPrefix", IsNullable = false)]
    public string EmergencyCallCLIDPrefix { get; set; }
 }
}