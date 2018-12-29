using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class IBehTreeTaskProcessProjectile : IBehTreeTask
{
#region RED Properties

[REDProp("destroyProjectileOnDeactivate")]
public bool DestroyProjectileOnDeactivate { get; set;}

[REDProp("combatDataStorage")]
public Handle<CHumanAICombatStorage> CombatDataStorage { get; set;}

[REDProp("takeProjectile")]
public bool TakeProjectile { get; set;}

[REDProp("projTemplate")]
public Handle<CEntityTemplate> ProjTemplate { get; set;}

#endregion
}
}