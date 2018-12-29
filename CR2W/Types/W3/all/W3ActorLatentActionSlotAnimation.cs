using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ActorLatentActionSlotAnimation : IPresetActorLatentAction
{
#region RED Properties

[REDProp("animName")]
public CName AnimName { get; set;}

[REDProp("slotName")]
public CName SlotName { get; set;}

#endregion
}
}