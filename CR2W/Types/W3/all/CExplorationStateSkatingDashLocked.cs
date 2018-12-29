using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateSkatingDashLocked : CExplorationInterceptorStateAbstract
{
#region RED Properties

[REDProp("skateGlobal")]
public Handle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

[REDProp("target")]
public Handle<CEntity> Target { get; set;}

[REDProp("isInFlow")]
public bool IsInFlow { get; set;}

[REDProp("targetMaxAngle")]
public float TargetMaxAngle { get; set;}

[REDProp("targetMaxAngleFlow")]
public float TargetMaxAngleFlow { get; set;}

[REDProp("reachSideDistance")]
public float ReachSideDistance { get; set;}

[REDProp("targetSideDistance")]
public float TargetSideDistance { get; set;}

[REDProp("inputAngleInfluence")]
public float InputAngleInfluence { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("speedMinMax")]
public float SpeedMinMax { get; set;}

[REDProp("impulseMax")]
public float ImpulseMax { get; set;}

[REDProp("impulseMaxFlow")]
public float ImpulseMaxFlow { get; set;}

[REDProp("aimSpeed")]
public float AimSpeed { get; set;}

[REDProp("adjustorTicket")]
public SMovementAdjustmentRequestTicket AdjustorTicket { get; set;}

[REDProp("attackDistGap")]
public float AttackDistGap { get; set;}

[REDProp("attackDistGapPerfect")]
public float AttackDistGapPerfect { get; set;}

[REDProp("toTargetDistanceInit")]
public float ToTargetDistanceInit { get; set;}

[REDProp("toTargetDistance")]
public float ToTargetDistance { get; set;}

[REDProp("targetDirLast")]
public Vector TargetDirLast { get; set;}

[REDProp("attacked")]
public bool Attacked { get; set;}

[REDProp("timeTotalMax")]
public float TimeTotalMax { get; set;}

[REDProp("timeTotalMaxFlow")]
public float TimeTotalMaxFlow { get; set;}

[REDProp("timeToChainMin")]
public float TimeToChainMin { get; set;}

[REDProp("useTimeScale")]
public bool UseTimeScale { get; set;}

[REDProp("timeScaleSpeed")]
public float TimeScaleSpeed { get; set;}

[REDProp("timeScaled")]
public bool TimeScaled { get; set;}

[REDProp("afterAttackTime")]
public float AfterAttackTime { get; set;}

[REDProp("timeToEndCur")]
public float TimeToEndCur { get; set;}

[REDProp("behParamAttackName")]
public CName BehParamAttackName { get; set;}

[REDProp("afterAttackImpulse")]
public float AfterAttackImpulse { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

#endregion
}
}