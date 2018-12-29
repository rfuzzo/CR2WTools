using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBehaviorComboAttack 
{
#region RED Properties

[REDProp("level")]
public int Level { get; set;}

[REDProp("type")]
public int Type { get; set;}

[REDProp("direction")]
public EAttackDirection Direction { get; set;}

[REDProp("distance")]
public EAttackDistance Distance { get; set;}

[REDProp("attackTime")]
public float AttackTime { get; set;}

[REDProp("parryTime")]
public float ParryTime { get; set;}

[REDProp("attackAnimation")]
public CName AttackAnimation { get; set;}

[REDProp("parryAnimation")]
public CName ParryAnimation { get; set;}

[REDProp("attackHitTime")]
public float AttackHitTime { get; set;}

[REDProp("parryHitTime")]
public float ParryHitTime { get; set;}

[REDProp("attackHitLevel")]
public float AttackHitLevel { get; set;}

[REDProp("parryHitLevel")]
public float ParryHitLevel { get; set;}

[REDProp("attackHitTime1")]
public float AttackHitTime1 { get; set;}

[REDProp("parryHitTime1")]
public float ParryHitTime1 { get; set;}

[REDProp("attackHitLevel1")]
public float AttackHitLevel1 { get; set;}

[REDProp("parryHitLevel1")]
public float ParryHitLevel1 { get; set;}

[REDProp("attackHitTime2")]
public float AttackHitTime2 { get; set;}

[REDProp("parryHitTime2")]
public float ParryHitTime2 { get; set;}

[REDProp("attackHitLevel2")]
public float AttackHitLevel2 { get; set;}

[REDProp("parryHitLevel2")]
public float ParryHitLevel2 { get; set;}

[REDProp("attackHitTime3")]
public float AttackHitTime3 { get; set;}

[REDProp("parryHitTime3")]
public float ParryHitTime3 { get; set;}

[REDProp("attackHitLevel3")]
public float AttackHitLevel3 { get; set;}

[REDProp("parryHitLevel3")]
public float ParryHitLevel3 { get; set;}

#endregion
}
}