using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CTicketAlgorithmMeleeDefinition : ITicketAlgorithmScriptDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValFloat Priority { get; set;}

[REDProp("activationBonus")]
public CBehTreeValFloat ActivationBonus { get; set;}

[REDProp("isInVicinityBonus")]
public CBehTreeValFloat IsInVicinityBonus { get; set;}

[REDProp("vicinityMax")]
public CBehTreeValFloat VicinityMax { get; set;}

[REDProp("vicinityMin")]
public CBehTreeValFloat VicinityMin { get; set;}

[REDProp("threatLevelBonus")]
public CBehTreeValFloat ThreatLevelBonus { get; set;}

[REDProp("moraleBonus")]
public CBehTreeValFloat MoraleBonus { get; set;}

[REDProp("hpBonus")]
public CBehTreeValFloat HpBonus { get; set;}

[REDProp("timeBonus")]
public CBehTreeValFloat TimeBonus { get; set;}

[REDProp("distanceBonus")]
public CBehTreeValFloat DistanceBonus { get; set;}

[REDProp("desiredDistance")]
public CBehTreeValFloat DesiredDistance { get; set;}

[REDProp("desiredTime")]
public CBehTreeValFloat DesiredTime { get; set;}

[REDProp("isAttackedBonus")]
public CBehTreeValFloat IsAttackedBonus { get; set;}

[REDProp("isAttackedStateDuration")]
public CBehTreeValFloat IsAttackedStateDuration { get; set;}

[REDProp("inTargetBackBonus")]
public CBehTreeValFloat InTargetBackBonus { get; set;}

#endregion
}
}