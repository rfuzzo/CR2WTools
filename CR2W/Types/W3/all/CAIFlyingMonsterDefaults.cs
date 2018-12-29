using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFlyingMonsterDefaults : CAIBaseMonsterDefaults
{
#region RED Properties

[REDProp("combatTree")]
public Handle<CAIFlyingMonsterCombat> CombatTree { get; set;}

[REDProp("deathTree")]
public Handle<CAIFlyingMonsterDeath> DeathTree { get; set;}

[REDProp("flyingWander")]
public Handle<CAISubTree> FlyingWander { get; set;}

[REDProp("freeFlight")]
public Handle<IAIFlightIdleTree> FreeFlight { get; set;}

[REDProp("canFly")]
public bool CanFly { get; set;}

#endregion
}
}