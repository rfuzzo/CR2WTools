using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMonsterDefeated : CAIMonsterDeath
{
#region RED Properties

[REDProp("localDeathTree")]
public Handle<CAIMonsterDeath> LocalDeathTree { get; set;}

[REDProp("unconsciousTree")]
public Handle<CAINpcUnconsciousTree> UnconsciousTree { get; set;}

#endregion
}
}