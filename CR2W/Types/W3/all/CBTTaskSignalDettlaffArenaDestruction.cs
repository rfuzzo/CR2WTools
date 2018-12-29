using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSignalDettlaffArenaDestruction : IBehTreeTask
{
#region RED Properties

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("destroyTime")]
public float DestroyTime { get; set;}

#endregion
}
}