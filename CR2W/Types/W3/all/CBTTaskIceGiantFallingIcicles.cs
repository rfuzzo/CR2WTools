using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskIceGiantFallingIcicles : CBTTaskAttack
{
#region RED Properties

[REDProp("icicles")]
public Array<Handle<CGameplayEntity>> Icicles { get; set;}

[REDProp("rangeForIcyclesActivation")]
public float RangeForIcyclesActivation { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

#endregion
}
}