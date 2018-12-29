using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMonsterDefaults : CAIBaseMonsterDefaults
{
#region RED Properties

[REDProp("combatTree")]
public Handle<CAIMonsterCombat> CombatTree { get; set;}

[REDProp("deathTree")]
public Handle<CAIMonsterDeath> DeathTree { get; set;}

[REDProp("spawnEntityAtDeath")]
public bool SpawnEntityAtDeath { get; set;}

[REDProp("morphInCombat")]
public bool MorphInCombat { get; set;}

[REDProp("entityToSpawn")]
public CName EntityToSpawn { get; set;}

#endregion
}
}