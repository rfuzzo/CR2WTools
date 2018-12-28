using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SCameraAnimationDefinition 
{
#region RED Properties

[REDProp("animation")]
public CName Animation { get; set;}

[REDProp("priority")]
public int Priority { get; set;}

[REDProp("blendIn")]
public float BlendIn { get; set;}

[REDProp("blendOut")]
public float BlendOut { get; set;}

[REDProp("weight")]
public float Weight { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("loop")]
public bool Loop { get; set;}

[REDProp("reset")]
public bool Reset { get; set;}

[REDProp("additive")]
public bool Additive { get; set;}

[REDProp("exclusive")]
public bool Exclusive { get; set;}

#endregion
}
}