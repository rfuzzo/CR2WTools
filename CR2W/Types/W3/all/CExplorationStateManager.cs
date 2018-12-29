using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateManager : CSelfUpdatingComponent
{
#region RED Properties

[REDProp("m_OwnerE")]
public Handle<CGameplayEntity> M_OwnerE { get; set;}

[REDProp("m_OwnerMAC")]
public Handle<CMovingPhysicalAgentComponent> M_OwnerMAC { get; set;}

[REDProp("m_InputO")]
public Handle<CExplorationInput> M_InputO { get; set;}

[REDProp("m_MoverO")]
public Handle<CExplorationMover> M_MoverO { get; set;}

[REDProp("m_SharedDataO")]
public Handle<CExplorationSharedData> M_SharedDataO { get; set;}

[REDProp("m_CollisionManagerO")]
public Handle<CExplorationCollisionManager> M_CollisionManagerO { get; set;}

[REDProp("m_MovementCorrectorO")]
public Handle<CExplorationMovementCorrector> M_MovementCorrectorO { get; set;}

[REDProp("m_SuperStateLastN")]
public CName M_SuperStateLastN { get; set;}

[REDProp("m_StatesSArr")]
public Array<Handle<CExplorationStateAbstract>> M_StatesSArr { get; set;}

[REDProp("m_StatesUpdatedInactiveSArr")]
public Array<Handle<CExplorationStateAbstract>> M_StatesUpdatedInactiveSArr { get; set;}

[REDProp("m_StateNamesSArr")]
public Array<CName> M_StateNamesSArr { get; set;}

[REDProp("m_StateTransitionsSArr")]
public Array<Handle<CExplorationStateTransitionAbstract>> M_StateTransitionsSArr { get; set;}

[REDProp("m_StateLastN")]
public CName M_StateLastN { get; set;}

[REDProp("m_StateLastI")]
public Int32 M_StateLastI { get; set;}

[REDProp("m_StateCurN")]
public CName M_StateCurN { get; set;}

[REDProp("m_StateCurI")]
public Int32 M_StateCurI { get; set;}

[REDProp("m_StateTimeCurF")]
public float M_StateTimeCurF { get; set;}

[REDProp("m_StateTimeLastF")]
public float M_StateTimeLastF { get; set;}

[REDProp("m_StateGlobalQueuedN")]
public CName M_StateGlobalQueuedN { get; set;}

[REDProp("m_StateDefaultN")]
public CName M_StateDefaultN { get; set;}

[REDProp("c_InvalidStateN")]
public CName C_InvalidStateN { get; set;}

[REDProp("c_InvalidStateI")]
public Int32 C_InvalidStateI { get; set;}

[REDProp("m_StateChanged")]
public bool M_StateChanged { get; set;}

[REDProp("m_StateExitedFromBehN")]
public CName M_StateExitedFromBehN { get; set;}

[REDProp("m_StateEnteredFromBehN")]
public CName M_StateEnteredFromBehN { get; set;}

[REDProp("m_BehaviorConfirmStateE")]
public EBehGraphConfirmationState M_BehaviorConfirmStateE { get; set;}

[REDProp("m_StateBehCurReportedN")]
public CName M_StateBehCurReportedN { get; set;}

[REDProp("m_DefaultCameraSetS")]
public Handle<CCameraParametersSet> M_DefaultCameraSetS { get; set;}

[REDProp("m_IsOnGroundB")]
public bool M_IsOnGroundB { get; set;}

[REDProp("m_TeleportedFallHackTime")]
public float M_TeleportedFallHackTime { get; set;}

[REDProp("m_TeleportedFallHackTimeTotalF")]
public float M_TeleportedFallHackTimeTotalF { get; set;}

[REDProp("m_storedInteractionPri")]
public EInteractionPriority M_storedInteractionPri { get; set;}

[REDProp("m_NoSaveLock")]
public Int32 M_NoSaveLock { get; set;}

[REDProp("m_NoSaveLockStringS")]
public string M_NoSaveLockStringS { get; set;}

[REDProp("m_ActiveB")]
public bool M_ActiveB { get; set;}

[REDProp("m_InitializedB")]
public bool M_InitializedB { get; set;}

[REDProp("m_IsDebugModeB")]
public bool M_IsDebugModeB { get; set;}

[REDProp("m_DebugPointV")]
public Vector M_DebugPointV { get; set;}

[REDProp("m_SmoothedVelocityV")]
public Vector M_SmoothedVelocityV { get; set;}

#endregion
}
}