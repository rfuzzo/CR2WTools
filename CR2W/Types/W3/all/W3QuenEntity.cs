using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuenEntity : W3SignEntity
{
#region RED Properties

[REDProp("effects")]
public Array<SQuenEffects> Effects { get; set;}

[REDProp("hitEntityTemplate")]
public Handle<CEntityTemplate> HitEntityTemplate { get; set;}

[REDProp("shieldDuration")]
public float ShieldDuration { get; set;}

[REDProp("shieldHealth")]
public float ShieldHealth { get; set;}

[REDProp("initialShieldHealth")]
public float InitialShieldHealth { get; set;}

[REDProp("dischargePercent")]
public float DischargePercent { get; set;}

[REDProp("ownerBoneIndex")]
public Int32 OwnerBoneIndex { get; set;}

[REDProp("blockedAllDamage")]
public bool BlockedAllDamage { get; set;}

[REDProp("shieldStartTime")]
public EngineTime ShieldStartTime { get; set;}

[REDProp("hitEntityTimestamps")]
public Array<EngineTime> HitEntityTimestamps { get; set;}

[REDProp("MIN_HIT_ENTITY_SPAWN_DELAY")]
public float MIN_HIT_ENTITY_SPAWN_DELAY { get; set;}

[REDProp("hitDoTEntities")]
public Array<Handle<W3VisualFx>> HitDoTEntities { get; set;}

[REDProp("showForceFinishedFX")]
public bool ShowForceFinishedFX { get; set;}

[REDProp("freeFromBearSetBonus")]
public bool FreeFromBearSetBonus { get; set;}

#endregion
}
}