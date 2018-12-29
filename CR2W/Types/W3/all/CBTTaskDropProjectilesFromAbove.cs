using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDropProjectilesFromAbove : IBehTreeTask
{
#region RED Properties

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("activeOnAnimEvent")]
public CName ActiveOnAnimEvent { get; set;}

[REDProp("chanceToGuaranteePlayerHit")]
public float ChanceToGuaranteePlayerHit { get; set;}

[REDProp("timeBetweenSpawn")]
public float TimeBetweenSpawn { get; set;}

[REDProp("timeBetweenSpawnRandomizationPerc")]
public float TimeBetweenSpawnRandomizationPerc { get; set;}

[REDProp("minDistFromTarget")]
public float MinDistFromTarget { get; set;}

[REDProp("maxDistFromTarget")]
public float MaxDistFromTarget { get; set;}

[REDProp("minDistFromEachOther")]
public float MinDistFromEachOther { get; set;}

[REDProp("minYOffset")]
public float MinYOffset { get; set;}

[REDProp("maxYOffset")]
public float MaxYOffset { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("useOwnerAsTarget")]
public bool UseOwnerAsTarget { get; set;}

[REDProp("target")]
public Handle<CActor> Target { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("usedPos")]
public Array<Vector> UsedPos { get; set;}

[REDProp("activated")]
public bool Activated { get; set;}

#endregion
}
}