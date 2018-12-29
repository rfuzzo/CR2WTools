using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskEredinSetCanPerformAction : IBehTreeTask
{
#region RED Properties

[REDProp("combatDataStorage")]
public Handle<CBossAICombatStorage> CombatDataStorage { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("action")]
public EBossAction Action { get; set;}

[REDProp("value")]
public bool Value { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

#endregion
}
}