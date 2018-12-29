using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SGameplayAdditiveAnimation 
{
#region RED Properties

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("delay")]
public float Delay { get; set;}

[REDProp("cooldown")]
public float Cooldown { get; set;}

[REDProp("chance")]
public float Chance { get; set;}

[REDProp("onlyOnce")]
public bool OnlyOnce { get; set;}

[REDProp("useWeightRange")]
public bool UseWeightRange { get; set;}

[REDProp("weightRangeMin")]
public float WeightRangeMin { get; set;}

[REDProp("weightRangeMax")]
public float WeightRangeMax { get; set;}

[REDProp("useSpeedRange")]
public bool UseSpeedRange { get; set;}

[REDProp("speedRangeMin")]
public float SpeedRangeMin { get; set;}

[REDProp("speedRangeMax")]
public float SpeedRangeMax { get; set;}

#endregion
}
}