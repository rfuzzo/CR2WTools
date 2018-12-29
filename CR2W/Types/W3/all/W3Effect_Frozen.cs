using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_Frozen : W3ImmobilizeEffect
{
#region RED Properties

[REDProp("killOnHit")]
public bool KillOnHit { get; set;}

[REDProp("bonusDamagePercents")]
public float BonusDamagePercents { get; set;}

[REDProp("targetWasFlying")]
public bool TargetWasFlying { get; set;}

[REDProp("pushPriority")]
public EInteractionPriority PushPriority { get; set;}

[REDProp("wasKnockedDown")]
public bool WasKnockedDown { get; set;}

#endregion
}
}