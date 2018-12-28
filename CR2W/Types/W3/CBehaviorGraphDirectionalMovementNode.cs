using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphDirectionalMovementNode : CBehaviorGraphNode
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("activateNotification")]
public CName ActivateNotification { get; set;}

[REDProp("deactivateNotification")]
public CName DeactivateNotification { get; set;}

[REDProp("generateEditorFragments")]
public bool GenerateEditorFragments { get; set;}

[REDProp("id")]
public uint Id { get; set;}

[REDProp("groupCount")]
public int GroupCount { get; set;}

[REDProp("animsPerGroup")]
public int AnimsPerGroup { get; set;}

[REDProp("firstGroupDirOffset")]
public float FirstGroupDirOffset { get; set;}

[REDProp("extraOverlapAngle")]
public float ExtraOverlapAngle { get; set;}

[REDProp("keepInCurrentGroupAngle")]
public float KeepInCurrentGroupAngle { get; set;}

[REDProp("findGroupDirOffset")]
public float FindGroupDirOffset { get; set;}

[REDProp("singleAnimOnly")]
public bool SingleAnimOnly { get; set;}

[REDProp("doNotSwitchAnim")]
public bool DoNotSwitchAnim { get; set;}

[REDProp("movementDirBlendTime")]
public float MovementDirBlendTime { get; set;}

[REDProp("movementDirMaxSpeedChange")]
public float MovementDirMaxSpeedChange { get; set;}

[REDProp("groupsBlendTime")]
public float GroupsBlendTime { get; set;}

[REDProp("quickTurnBlendTime")]
public float QuickTurnBlendTime { get; set;}

[REDProp("fasterQuickTurnBlendTime")]
public float FasterQuickTurnBlendTime { get; set;}

[REDProp("angleThresholdForQuickTurn")]
public float AngleThresholdForQuickTurn { get; set;}

[REDProp("reverseSyncOnQuickTurnFwdBwd")]
public bool ReverseSyncOnQuickTurnFwdBwd { get; set;}

[REDProp("reverseSyncOnQuickTurnLeftRight")]
public bool ReverseSyncOnQuickTurnLeftRight { get; set;}

[REDProp("syncBlendingOffsetPTLOnQuickTurn")]
public float SyncBlendingOffsetPTLOnQuickTurn { get; set;}

[REDProp("startPTLRightFootInFront")]
public float StartPTLRightFootInFront { get; set;}

[REDProp("startPTLLeftFootInFront")]
public float StartPTLLeftFootInFront { get; set;}

[REDProp("alwaysStartAtZero")]
public bool AlwaysStartAtZero { get; set;}

[REDProp("useSimpleBlendForMovementDelta")]
public bool UseSimpleBlendForMovementDelta { get; set;}

[REDProp("useDefinedVariablesAsRequestedInput")]
public bool UseDefinedVariablesAsRequestedInput { get; set;}

[REDProp("requestedMovementDirectionVariableName")]
public CName RequestedMovementDirectionVariableName { get; set;}

[REDProp("requestedFacingDirectionVariableName")]
public CName RequestedFacingDirectionVariableName { get; set;}

[REDProp("useDefinedInternalVariablesAsInitialInput")]
public bool UseDefinedInternalVariablesAsInitialInput { get; set;}

[REDProp("movementDirectionInternalVariableName")]
public CName MovementDirectionInternalVariableName { get; set;}

[REDProp("groupDirInternalVariableName")]
public CName GroupDirInternalVariableName { get; set;}

[REDProp("loopCount")]
public int LoopCount { get; set;}

[REDProp("syncGroupOffsetPTL")]
public float SyncGroupOffsetPTL { get; set;}

/*[REDProp("Right foot bone name")]
public CName Right foot bone name { get; set;}

[REDProp("Left foot bone name")]
public CName Left foot bone name { get; set;}*/

[REDProp("groupDir")]
public float GroupDir { get; set;}

[REDProp("sideAngleRange")]
public float SideAngleRange { get; set;}

[REDProp("syncMethod")]
public Ptr<IBehaviorSyncMethod> SyncMethod { get; set;}

[REDProp("allInputsValid")]
public bool AllInputsValid { get; set;}

[REDProp("cachedInputNodes")]
public Array<Ptr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

[REDProp("cachedRequestedMovementDirectionWSValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedRequestedMovementDirectionWSValueNode { get; set;}

[REDProp("cachedRequestedFacingDirectionWSValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedRequestedFacingDirectionWSValueNode { get; set;}

[REDProp("cachedInitialMovementDirectionWSValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedInitialMovementDirectionWSValueNode { get; set;}

[REDProp("cachedInitialGroupDirMSValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedInitialGroupDirMSValueNode { get; set;}

#endregion
}
}