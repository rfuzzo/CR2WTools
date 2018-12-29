using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskBehaviorGraph : IBehTreeTask
{
#region RED Properties

[REDProp("graph")]
public EBehaviorGraph Graph { get; set;}

[REDProp("forceHighPriority")]
public bool ForceHighPriority { get; set;}

[REDProp("res")]
public bool Res { get; set;}

[REDProp("graphName")]
public CName GraphName { get; set;}

[REDProp("combatDataStorage")]
public Handle<CHumanAICombatStorage> CombatDataStorage { get; set;}

#endregion
}
}