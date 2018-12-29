using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateAbstract : CScriptedComponent
{
#region RED Properties

[REDProp("m_StateNameN")]
public CName M_StateNameN { get; set;}

[REDProp("m_StateTypeE")]
public EExplorationStateType M_StateTypeE { get; set;}

[REDProp("m_UpdatesWhileInactiveB")]
public bool M_UpdatesWhileInactiveB { get; set;}

[REDProp("m_ExplorationO")]
public Handle<CExplorationStateManager> M_ExplorationO { get; set;}

[REDProp("m_LockedB")]
public bool M_LockedB { get; set;}

[REDProp("m_ActiveB")]
public bool M_ActiveB { get; set;}

[REDProp("m_StateNextN")]
public CName M_StateNextN { get; set;}

[REDProp("m_DefaultStateChangesArr")]
public Array<SDefaultStateTransition> M_DefaultStateChangesArr { get; set;}

[REDProp("m_BehaviorNeedsConfirmB")]
public bool M_BehaviorNeedsConfirmB { get; set;}

[REDProp("m_BehaviorEventB")]
public bool M_BehaviorEventB { get; set;}

[REDProp("m_BehaviorEventEachFrameB")]
public bool M_BehaviorEventEachFrameB { get; set;}

[REDProp("m_BehaviorEventN")]
public CName M_BehaviorEventN { get; set;}

[REDProp("m_StateDefaultExitToN")]
public CName M_StateDefaultExitToN { get; set;}

[REDProp("m_CanReactToCriticalStateB")]
public bool M_CanReactToCriticalStateB { get; set;}

[REDProp("m_ChangeCamerasB")]
public bool M_ChangeCamerasB { get; set;}

[REDProp("m_CameraKeepOldB")]
public bool M_CameraKeepOldB { get; set;}

[REDProp("m_CameraSetS")]
public Handle<CCameraParametersSet> M_CameraSetS { get; set;}

[REDProp("m_InputContextE")]
public EGameplayContextInput M_InputContextE { get; set;}

[REDProp("m_TurnAdjustTimeF")]
public float M_TurnAdjustTimeF { get; set;}

[REDProp("m_ActionsToBlockEArr")]
public Array<EInputActionBlock> M_ActionsToBlockEArr { get; set;}

[REDProp("m_ActionsToBlockCountI")]
public Int32 M_ActionsToBlockCountI { get; set;}

[REDProp("m_HolsterIsFastB")]
public bool M_HolsterIsFastB { get; set;}

[REDProp("m_CanSaveB")]
public bool M_CanSaveB { get; set;}

#endregion
}
}