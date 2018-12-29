using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationSkatingGlobal : CObject
{
#region RED Properties

[REDProp("m_ExplorationO")]
public Handle<CExplorationStateManager> M_ExplorationO { get; set;}

[REDProp("speedLevelCur")]
public Int32 SpeedLevelCur { get; set;}

[REDProp("speedLevelCapDefault")]
public Int32 SpeedLevelCapDefault { get; set;}

[REDProp("speedLevelCap")]
public Int32 SpeedLevelCap { get; set;}

[REDProp("speedLevelTotal")]
public Int32 SpeedLevelTotal { get; set;}

[REDProp("maxSpeedTotal")]
public float MaxSpeedTotal { get; set;}

[REDProp("minSpeedTotal")]
public float MinSpeedTotal { get; set;}

[REDProp("speedPerLevel")]
public float SpeedPerLevel { get; set;}

[REDProp("movementParamsLevels")]
public Array<SSkatingLevelParams> MovementParamsLevels { get; set;}

[REDProp("movementLevelsSpeedCurve")]
public Handle<CCurve> MovementLevelsSpeedCurve { get; set;}

[REDProp("movementParams")]
public SSkatingMovementParams MovementParams { get; set;}

[REDProp("turnSpeedBase")]
public float TurnSpeedBase { get; set;}

[REDProp("dashCooldownTotal")]
public float DashCooldownTotal { get; set;}

[REDProp("dashCooldownCur")]
public float DashCooldownCur { get; set;}

[REDProp("speedToBrake")]
public float SpeedToBrake { get; set;}

[REDProp("speedToStop")]
public float SpeedToStop { get; set;}

[REDProp("m_TurnF")]
public float M_TurnF { get; set;}

[REDProp("m_Drifting")]
public bool M_Drifting { get; set;}

[REDProp("m_DrifIsLeft")]
public bool M_DrifIsLeft { get; set;}

[REDProp("flowComboCur")]
public Int32 FlowComboCur { get; set;}

[REDProp("flowGapTimeCur")]
public float FlowGapTimeCur { get; set;}

[REDProp("flowGapTimeTotal")]
public float FlowGapTimeTotal { get; set;}

[REDProp("flowSuccesfullTimeTotal")]
public float FlowSuccesfullTimeTotal { get; set;}

[REDProp("flowSuccesfullTime")]
public float FlowSuccesfullTime { get; set;}

[REDProp("behParamTurnName")]
public CName BehParamTurnName { get; set;}

[REDProp("behParamAccelName")]
public CName BehParamAccelName { get; set;}

[REDProp("behParamSpeedName")]
public CName BehParamSpeedName { get; set;}

[REDProp("behParamAttackName")]
public CName BehParamAttackName { get; set;}

[REDProp("behParamRandAttackName")]
public CName BehParamRandAttackName { get; set;}

[REDProp("behParamJumpAttackName")]
public CName BehParamJumpAttackName { get; set;}

[REDProp("behParamTurnMax")]
public float BehParamTurnMax { get; set;}

[REDProp("behIncreasedSpeed")]
public CName BehIncreasedSpeed { get; set;}

[REDProp("behIncreasedFwdSpeed")]
public CName BehIncreasedFwdSpeed { get; set;}

[REDProp("active")]
public bool Active { get; set;}

#endregion
}
}