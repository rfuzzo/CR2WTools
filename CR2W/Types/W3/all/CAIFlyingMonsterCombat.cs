using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFlyingMonsterCombat : CAICombatTree
{
#region RED Properties

[REDProp("params")]
public Handle<CAIFlyingMonsterCombatParams> Params { get; set;}

#endregion
}
}