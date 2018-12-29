using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SAnimatedComponentSlotAnimationSettings 
{
#region RED Properties

[REDProp("blendIn")]
public float BlendIn { get; set;}

[REDProp("blendOut")]
public float BlendOut { get; set;}

#endregion
}
}