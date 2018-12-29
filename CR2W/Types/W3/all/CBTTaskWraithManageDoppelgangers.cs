using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskWraithManageDoppelgangers : IBehTreeTask
{
#region RED Properties

[REDProp("killDoppelgangersAtDeath")]
public bool KillDoppelgangersAtDeath { get; set;}

[REDProp("killDoppelgangersAfterTime")]
public float KillDoppelgangersAfterTime { get; set;}

[REDProp("splitEffectEntityTemplate")]
public Handle<CEntityTemplate> SplitEffectEntityTemplate { get; set;}

[REDProp("healthPercentageToRegen")]
public float HealthPercentageToRegen { get; set;}

[REDProp("m_spawnTime")]
public float M_spawnTime { get; set;}

[REDProp("m_SplitEntities")]
public Array<Handle<CEntity>> M_SplitEntities { get; set;}

[REDProp("m_MergeReceived")]
public Int32 M_MergeReceived { get; set;}

[REDProp("m_HealthPercToReach")]
public float M_HealthPercToReach { get; set;}

[REDProp("m_MergingStarted")]
public bool M_MergingStarted { get; set;}

#endregion
}
}