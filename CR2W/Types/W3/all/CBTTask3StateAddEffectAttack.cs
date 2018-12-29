using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTask3StateAddEffectAttack : CBTTask3StateAttack
{
#region RED Properties

[REDProp("applyEffectInRange")]
public float ApplyEffectInRange { get; set;}

[REDProp("applyEffectInCone")]
public float ApplyEffectInCone { get; set;}

[REDProp("applyEffectInterval")]
public float ApplyEffectInterval { get; set;}

[REDProp("effectType")]
public EEffectType EffectType { get; set;}

[REDProp("effectDuration")]
public float EffectDuration { get; set;}

[REDProp("effectValue")]
public float EffectValue { get; set;}

[REDProp("effectPercentValue")]
public float EffectPercentValue { get; set;}

[REDProp("activated")]
public bool Activated { get; set;}

#endregion
}
}