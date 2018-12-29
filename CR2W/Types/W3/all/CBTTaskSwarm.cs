using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSwarm : CBTTaskAttack
{
#region RED Properties

[REDProp("lair")]
public Handle<CFlyingSwarmMasterLair> Lair { get; set;}

[REDProp("entities")]
public Array<Handle<CGameplayEntity>> Entities { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

#endregion
}
}