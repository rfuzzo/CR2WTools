using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskWyvernTakeOffEffectDef : CBTTaskPlayAnimationEventDecoratorDef
{
#region RED Properties

[REDProp("effectRange")]
public float EffectRange { get; set;}

[REDProp("effectAngle")]
public float EffectAngle { get; set;}

#endregion
}
}