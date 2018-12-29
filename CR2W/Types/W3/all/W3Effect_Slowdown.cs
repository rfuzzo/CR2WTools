using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_Slowdown : CBaseGameplayEffect
{
#region RED Properties

[REDProp("slowdownCauserId")]
public Int32 SlowdownCauserId { get; set;}

[REDProp("decayPerSec")]
public float DecayPerSec { get; set;}

[REDProp("decayDelay")]
public float DecayDelay { get; set;}

[REDProp("delayTimer")]
public float DelayTimer { get; set;}

[REDProp("slowdown")]
public float Slowdown { get; set;}

#endregion
}
}