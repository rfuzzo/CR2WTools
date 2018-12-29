using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SGameplayLODConfig 
{
#region RED Properties

[REDProp("actorLODs")]
public Array<SActorLODConfig> ActorLODs { get; set;}

[REDProp("actorInvisibilityTimeThreshold")]
public float ActorInvisibilityTimeThreshold { get; set;}

[REDProp("maxBudgetedComponentsTickTime")]
public float MaxBudgetedComponentsTickTime { get; set;}

[REDProp("minBudgetedComponentsTickPercentage")]
public uint MinBudgetedComponentsTickPercentage { get; set;}

[REDProp("componentsTickLODUpdateTime")]
public float ComponentsTickLODUpdateTime { get; set;}

[REDProp("componentsBudgetableTickDistance")]
public float ComponentsBudgetableTickDistance { get; set;}

[REDProp("componentsDisableTickDistance")]
public float ComponentsDisableTickDistance { get; set;}

[REDProp("entitiesBudgetableTickDistance")]
public float EntitiesBudgetableTickDistance { get; set;}

[REDProp("entitiesDisableTickDistance")]
public float EntitiesDisableTickDistance { get; set;}

[REDProp("entitiesTickTime")]
public float EntitiesTickTime { get; set;}

[REDProp("effectsBudgetableTickDistance")]
public float EffectsBudgetableTickDistance { get; set;}

[REDProp("effectsTickLODUpdateTime")]
public float EffectsTickLODUpdateTime { get; set;}

[REDProp("effectsTickTime")]
public float EffectsTickTime { get; set;}

#endregion
}
}