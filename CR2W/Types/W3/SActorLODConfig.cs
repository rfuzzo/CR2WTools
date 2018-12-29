using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SActorLODConfig 
{
#region RED Properties

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("deadZone")]
public float DeadZone { get; set;}

[REDProp("hide")]
public bool Hide { get; set;}

[REDProp("enableIK")]
public bool EnableIK { get; set;}

[REDProp("enableDandles")]
public bool EnableDandles { get; set;}

[REDProp("mimicsQuality")]
public uint MimicsQuality { get; set;}

[REDProp("behaviorLOD")]
public EBehaviorLod BehaviorLOD { get; set;}

[REDProp("animatedComponentUpdateFrameSkip")]
public uint AnimatedComponentUpdateFrameSkip { get; set;}

[REDProp("suppressAnimatedComponent")]
public bool SuppressAnimatedComponent { get; set;}

[REDProp("budgetAnimatedComponentTick")]
public bool BudgetAnimatedComponentTick { get; set;}

[REDProp("suppressAnimatedComponentIfNotVisible")]
public bool SuppressAnimatedComponentIfNotVisible { get; set;}

[REDProp("budgetAnimatedComponentTickIfNotVisible")]
public bool BudgetAnimatedComponentTickIfNotVisible { get; set;}

#endregion
}
}