using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4LocomotionPlayerControllerScript : CR4LocomotionDirectControllerScript
{
#region RED Properties

[REDProp("player")]
public Handle<CR4Player> Player { get; set;}

[REDProp("angularInputSpeed")]
public float AngularInputSpeed { get; set;}

[REDProp("worldMoveDirection")]
public float WorldMoveDirection { get; set;}

[REDProp("localMoveDirection")]
public float LocalMoveDirection { get; set;}

[REDProp("previousInputVector")]
public Vector PreviousInputVector { get; set;}

[REDProp("timerValue")]
public float TimerValue { get; set;}

[REDProp("angularSpeed")]
public float AngularSpeed { get; set;}

[REDProp("_inputLocoEnabled")]
public bool _inputLocoEnabled { get; set;}

[REDProp("_inputVecCurr")]
public Vector _inputVecCurr { get; set;}

[REDProp("_inputVecPrev")]
public Vector _inputVecPrev { get; set;}

[REDProp("_inputHeading180Curr")]
public float _inputHeading180Curr { get; set;}

[REDProp("_inputHeading180Prev")]
public float _inputHeading180Prev { get; set;}

[REDProp("_inputHeading180LastCached")]
public float _inputHeading180LastCached { get; set;}

[REDProp("_inputMagCurr")]
public float _inputMagCurr { get; set;}

[REDProp("_inputMagPrev")]
public float _inputMagPrev { get; set;}

[REDProp("_inputMagDiffCurr")]
public float _inputMagDiffCurr { get; set;}

[REDProp("_inputMagDiffPrev")]
public float _inputMagDiffPrev { get; set;}

[REDProp("_inputMagLastCached")]
public float _inputMagLastCached { get; set;}

[REDProp("speedSlowWalkingMax")]
public float SpeedSlowWalkingMax { get; set;}

[REDProp("speedWalkingMax")]
public float SpeedWalkingMax { get; set;}

[REDProp("speedRunning")]
public float SpeedRunning { get; set;}

[REDProp("speedSprinting")]
public float SpeedSprinting { get; set;}

[REDProp("speedSprintingWithPerk")]
public float SpeedSprintingWithPerk { get; set;}

[REDProp("maxTerrainPitchToWalkUp")]
public float MaxTerrainPitchToWalkUp { get; set;}

[REDProp("prevPosition")]
public Vector PrevPosition { get; set;}

[REDProp("prevRotation")]
public EulerAngles PrevRotation { get; set;}

[REDProp("cachedMoveSpeed")]
public float CachedMoveSpeed { get; set;}

[REDProp("stoppedTimeStamp")]
public float StoppedTimeStamp { get; set;}

[REDProp("stopCheckEnabled")]
public bool StopCheckEnabled { get; set;}

[REDProp("stoppedTimeStampDelta")]
public float StoppedTimeStampDelta { get; set;}

[REDProp("doubleTapEnabled")]
public bool DoubleTapEnabled { get; set;}

[REDProp("localMoveDirectionPrevFrame")]
public float LocalMoveDirectionPrevFrame { get; set;}

[REDProp("directionSwitchTimeStamp")]
public float DirectionSwitchTimeStamp { get; set;}

[REDProp("directionCenteredTimeStamp")]
public float DirectionCenteredTimeStamp { get; set;}

[REDProp("isCheckingCentered")]
public bool IsCheckingCentered { get; set;}

[REDProp("isCheckingCommitToRightTurn")]
public bool IsCheckingCommitToRightTurn { get; set;}

[REDProp("isCheckingCommitToLeftTurn")]
public bool IsCheckingCommitToLeftTurn { get; set;}

[REDProp("isTurningRight")]
public bool IsTurningRight { get; set;}

[REDProp("isTurningLeft")]
public bool IsTurningLeft { get; set;}

[REDProp("commitToRightTurnTimeStamp")]
public float CommitToRightTurnTimeStamp { get; set;}

[REDProp("commitToLeftTurnTimeStamp")]
public float CommitToLeftTurnTimeStamp { get; set;}

[REDProp("directionSwitchTimeStampDelta")]
public float DirectionSwitchTimeStampDelta { get; set;}

[REDProp("startRightTurnTimeStamp")]
public float StartRightTurnTimeStamp { get; set;}

[REDProp("startLeftTurnTimeStamp")]
public float StartLeftTurnTimeStamp { get; set;}

[REDProp("useRightTurnTimeStamp")]
public bool UseRightTurnTimeStamp { get; set;}

[REDProp("useLeftTurnTimeStamp")]
public bool UseLeftTurnTimeStamp { get; set;}

[REDProp("fastTurnEnabled")]
public bool FastTurnEnabled { get; set;}

#endregion
}
}