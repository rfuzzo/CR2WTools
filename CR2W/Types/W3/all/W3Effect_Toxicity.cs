using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_Toxicity : CBaseGameplayEffect
{
#region RED Properties

[REDProp("dmgTypeName")]
public CName DmgTypeName { get; set;}

[REDProp("toxThresholdEffect")]
public Int32 ToxThresholdEffect { get; set;}

[REDProp("delayToNextVFXUpdate")]
public float DelayToNextVFXUpdate { get; set;}

#endregion
}
}