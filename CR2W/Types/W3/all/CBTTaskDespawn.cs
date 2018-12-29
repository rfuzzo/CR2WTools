using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDespawn : IBehTreeTask
{
#region RED Properties

[REDProp("callFromQuest")]
public bool CallFromQuest { get; set;}

[REDProp("destroyCooldown")]
public float DestroyCooldown { get; set;}

[REDProp("despawn")]
public bool Despawn { get; set;}

[REDProp("disappearfxName")]
public CName DisappearfxName { get; set;}

[REDProp("emptyName")]
public CName EmptyName { get; set;}

[REDProp("despawnEventName")]
public CName DespawnEventName { get; set;}

[REDProp("raiseEventName")]
public CName RaiseEventName { get; set;}

#endregion
}
}