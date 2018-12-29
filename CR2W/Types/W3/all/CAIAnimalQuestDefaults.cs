using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIAnimalQuestDefaults : CAIDefaults
{
#region RED Properties

[REDProp("combatTree")]
public Handle<CAICombatTree> CombatTree { get; set;}

[REDProp("idleTree")]
public Handle<CAIIdleTree> IdleTree { get; set;}

[REDProp("deathTree")]
public Handle<CAIDeathTree> DeathTree { get; set;}

#endregion
}
}