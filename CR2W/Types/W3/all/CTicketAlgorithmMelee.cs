using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CTicketAlgorithmMelee : ITicketAlgorithmScript
{
#region RED Properties

[REDProp("priority")]
public float Priority { get; set;}

[REDProp("activationBonus")]
public float ActivationBonus { get; set;}

[REDProp("threatLevelBonus")]
public float ThreatLevelBonus { get; set;}

[REDProp("moraleBonus")]
public float MoraleBonus { get; set;}

[REDProp("hpBonus")]
public float HpBonus { get; set;}

[REDProp("timeBonus")]
public float TimeBonus { get; set;}

[REDProp("distanceBonus")]
public float DistanceBonus { get; set;}

[REDProp("desiredDistance")]
public float DesiredDistance { get; set;}

[REDProp("desiredTime")]
public float DesiredTime { get; set;}

[REDProp("isAttackedBonus")]
public float IsAttackedBonus { get; set;}

[REDProp("isAttackedStateDuration")]
public float IsAttackedStateDuration { get; set;}

[REDProp("isInVicinityBonus")]
public float IsInVicinityBonus { get; set;}

[REDProp("vicinityMax")]
public float VicinityMax { get; set;}

[REDProp("vicinityMin")]
public float VicinityMin { get; set;}

[REDProp("inTargetBackBonus")]
public float InTargetBackBonus { get; set;}

#endregion
}
}