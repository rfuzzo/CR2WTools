using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDespawnDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("callFromQuest")]
public bool CallFromQuest { get; set;}

[REDProp("despawnEventName")]
public CName DespawnEventName { get; set;}

[REDProp("disappearfxName")]
public CName DisappearfxName { get; set;}

[REDProp("raiseEventName")]
public CName RaiseEventName { get; set;}

[REDProp("destroyCooldown")]
public float DestroyCooldown { get; set;}

#endregion
}
}