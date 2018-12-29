using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIAnimalDefaults : CAIDefaults
{
#region RED Properties

[REDProp("combatTree")]
public Handle<CAIAnimalCombat> CombatTree { get; set;}

[REDProp("idleTree")]
public Handle<CAIIdleTree> IdleTree { get; set;}

[REDProp("idleDecoratorTree")]
public Handle<CAIMonsterIdleDecorator> IdleDecoratorTree { get; set;}

[REDProp("charmedTree")]
public Handle<CAIAnimalCharmed> CharmedTree { get; set;}

[REDProp("deathTree")]
public Handle<CAIAnimalDeath> DeathTree { get; set;}

[REDProp("isAnimal")]
public bool IsAnimal { get; set;}

#endregion
}
}