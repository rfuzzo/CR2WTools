using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SAnimatedSlideSettings 
{
#region RED Properties

[REDProp("animation")]
public CName Animation { get; set;}

[REDProp("slotName")]
public CName SlotName { get; set;}

[REDProp("blendIn")]
public float BlendIn { get; set;}

[REDProp("blendOut")]
public float BlendOut { get; set;}

[REDProp("useGameTimeScale")]
public bool UseGameTimeScale { get; set;}

[REDProp("useRotationDeltaPolicy")]
public bool UseRotationDeltaPolicy { get; set;}

#endregion
}
}