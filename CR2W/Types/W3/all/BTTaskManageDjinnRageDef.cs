using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageDjinnRageDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("defaultFXName")]
public CName DefaultFXName { get; set;}

[REDProp("playFXOnAardHit")]
public CName PlayFXOnAardHit { get; set;}

[REDProp("playFXOnIgniHit")]
public CName PlayFXOnIgniHit { get; set;}

[REDProp("weakenedFXName")]
public CName WeakenedFXName { get; set;}

[REDProp("rageAbilityName")]
public CName RageAbilityName { get; set;}

[REDProp("weakenedAbilityName")]
public CName WeakenedAbilityName { get; set;}

[REDProp("calmDownCooldown")]
public float CalmDownCooldown { get; set;}

[REDProp("removeWeakenedStateOnCounter")]
public bool RemoveWeakenedStateOnCounter { get; set;}

#endregion
}
}