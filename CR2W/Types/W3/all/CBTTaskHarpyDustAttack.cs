using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHarpyDustAttack : CBTTaskAttack
{
#region RED Properties

[REDProp("addtionalFX")]
public CName AddtionalFX { get; set;}

[REDProp("effectRange")]
public float EffectRange { get; set;}

[REDProp("effectAngle")]
public float EffectAngle { get; set;}

[REDProp("eventReceived")]
public bool EventReceived { get; set;}

#endregion
}
}