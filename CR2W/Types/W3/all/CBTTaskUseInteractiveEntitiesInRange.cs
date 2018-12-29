using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskUseInteractiveEntitiesInRange : IBehTreeTask
{
#region RED Properties

[REDProp("animationEventName")]
public CName AnimationEventName { get; set;}

[REDProp("usableEntityTag")]
public CName UsableEntityTag { get; set;}

[REDProp("maxTriggeredEntities")]
public Int32 MaxTriggeredEntities { get; set;}

[REDProp("delayBetweenUses")]
public float DelayBetweenUses { get; set;}

[REDProp("checkDistance")]
public float CheckDistance { get; set;}

[REDProp("minDistanceToSelf")]
public float MinDistanceToSelf { get; set;}

[REDProp("targetType")]
public EChosenTarget TargetType { get; set;}

[REDProp("targetTag")]
public CName TargetTag { get; set;}

[REDProp("betweenTargetAndSelf")]
public bool BetweenTargetAndSelf { get; set;}

[REDProp("chosenEntities")]
public Array<Handle<W3UsableEntity>> ChosenEntities { get; set;}

[REDProp("interactiveNodes")]
public Array<Handle<CNode>> InteractiveNodes { get; set;}

[REDProp("lastUsedTime")]
public EngineTime LastUsedTime { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

#endregion
}
}