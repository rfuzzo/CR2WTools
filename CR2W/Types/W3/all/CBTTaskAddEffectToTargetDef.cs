using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskAddEffectToTargetDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onEvent")]
public bool OnEvent { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("useLookAt")]
public bool UseLookAt { get; set;}

[REDProp("applyEffectInterval")]
public float ApplyEffectInterval { get; set;}

[REDProp("applyEffectForTime")]
public float ApplyEffectForTime { get; set;}

[REDProp("applyEffectInRange")]
public float ApplyEffectInRange { get; set;}

[REDProp("applyEffectInCone")]
public float ApplyEffectInCone { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("effectType")]
public EEffectType EffectType { get; set;}

[REDProp("effectDuration")]
public float EffectDuration { get; set;}

[REDProp("effectValue")]
public float EffectValue { get; set;}

[REDProp("effectValuePerc")]
public float EffectValuePerc { get; set;}

[REDProp("applyOnOwner")]
public bool ApplyOnOwner { get; set;}

[REDProp("customFXName")]
public CName CustomFXName { get; set;}

[REDProp("breakQuen")]
public bool BreakQuen { get; set;}

#endregion
}
}