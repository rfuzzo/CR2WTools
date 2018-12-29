using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskToadEatCorpse : IBehTreeTask
{
#region RED Properties

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("corpsePos")]
public Vector CorpsePos { get; set;}

[REDProp("corpse")]
public Handle<CEntity> Corpse { get; set;}

[REDProp("distance")]
public float Distance { get; set;}

#endregion
}
}