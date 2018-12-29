using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3BeeSwarm : CGameplayEntity
{
#region RED Properties

[REDProp("damageVal")]
public SAbilityAttributeValue DamageVal { get; set;}

[REDProp("destroyEntAfter")]
public float DestroyEntAfter { get; set;}

[REDProp("velocity")]
public float Velocity { get; set;}

[REDProp("bIsEnabled")]
public bool BIsEnabled { get; set;}

[REDProp("AIReactionRange")]
public float AIReactionRange { get; set;}

[REDProp("ignoreNPCsFriendlyToPlayer")]
public bool IgnoreNPCsFriendlyToPlayer { get; set;}

[REDProp("maxChaseDistance")]
public float MaxChaseDistance { get; set;}

[REDProp("desiredTargetTag")]
public CName DesiredTargetTag { get; set;}

[REDProp("excludedEntitiesTags")]
public Array<CName> ExcludedEntitiesTags { get; set;}

[REDProp("factOnDestruction")]
public string FactOnDestruction { get; set;}

[REDProp("originEntity")]
public Handle<CGameplayEntity> OriginEntity { get; set;}

[REDProp("originPoint")]
public Vector OriginPoint { get; set;}

[REDProp("victims")]
public Array<SSwarmVictim> Victims { get; set;}

[REDProp("buffParams")]
public SCustomEffectParams BuffParams { get; set;}

[REDProp("targets")]
public Array<Handle<CGameplayEntity>> Targets { get; set;}

[REDProp("activeDistanceSquared")]
public float ActiveDistanceSquared { get; set;}

[REDProp("PLAYER_PRESENCE_CHECK_DISTANCE")]
public float PLAYER_PRESENCE_CHECK_DISTANCE { get; set;}

[REDProp("PRESENCE_CHECK_DT")]
public float PRESENCE_CHECK_DT { get; set;}

[REDProp("TARGETS_CHECK_DT")]
public float TARGETS_CHECK_DT { get; set;}

#endregion
}
}