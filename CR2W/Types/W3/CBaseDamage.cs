using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBaseDamage : CObject
{
#region RED Properties

[REDProp("hitLocation")]
public Vector HitLocation { get; set;}

[REDProp("momentum")]
public Vector Momentum { get; set;}

[REDProp("causer")]
public Handle<IScriptable> Causer { get; set;}

[REDProp("attacker")]
public Handle<CGameplayEntity> Attacker { get; set;}

[REDProp("victim")]
public Handle<CGameplayEntity> Victim { get; set;}

[REDProp("hitReactionAnimRequested")]
public bool HitReactionAnimRequested { get; set;}

#endregion
}
}