using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHitReactionDecorator : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("createHitReactionEvent")]
public CName CreateHitReactionEvent { get; set;}

[REDProp("increaseHitCounterOnlyOnMeleeDmg")]
public bool IncreaseHitCounterOnlyOnMeleeDmg { get; set;}

[REDProp("hitsToRaiseGuard")]
public Int32 HitsToRaiseGuard { get; set;}

[REDProp("raiseGuardChance")]
public Int32 RaiseGuardChance { get; set;}

[REDProp("hitsToCounter")]
public Int32 HitsToCounter { get; set;}

[REDProp("counterChance")]
public Int32 CounterChance { get; set;}

[REDProp("counterStaminaCost")]
public float CounterStaminaCost { get; set;}

[REDProp("damageData")]
public Handle<CDamageData> DamageData { get; set;}

[REDProp("damageIsMelee")]
public bool DamageIsMelee { get; set;}

[REDProp("rotateNode")]
public Handle<CNode> RotateNode { get; set;}

[REDProp("lastAttacker")]
public Handle<CGameplayEntity> LastAttacker { get; set;}

[REDProp("reactionDataStorage")]
public Handle<CAIStorageReactionData> ReactionDataStorage { get; set;}

#endregion
}
}