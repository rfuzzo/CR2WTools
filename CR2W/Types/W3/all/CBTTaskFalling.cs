using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFalling : IBehTreeTask
{
#region RED Properties

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("drawableComp")]
public Handle<CDrawableComponent> DrawableComp { get; set;}

[REDProp("fakeBroomHidden")]
public bool FakeBroomHidden { get; set;}

[REDProp("attachedToGround")]
public bool AttachedToGround { get; set;}

[REDProp("broomSpawned")]
public bool BroomSpawned { get; set;}

#endregion
}
}