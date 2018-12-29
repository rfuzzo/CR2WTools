using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationInput : CObject
{
#region RED Properties

[REDProp("m_ExplorationO")]
public Handle<CExplorationStateManager> M_ExplorationO { get; set;}

[REDProp("m_InputMoveOnPadV")]
public Vector M_InputMoveOnPadV { get; set;}

[REDProp("m_InputMoveOnPlaneV")]
public Vector M_InputMoveOnPlaneV { get; set;}

[REDProp("m_InputMoveOnPadNormalizedV")]
public Vector M_InputMoveOnPadNormalizedV { get; set;}

[REDProp("m_InputMoveOnPlaneNormalizedV")]
public Vector M_InputMoveOnPlaneNormalizedV { get; set;}

[REDProp("m_InputMoveOnCameraNormalizedV")]
public Vector M_InputMoveOnCameraNormalizedV { get; set;}

[REDProp("m_InputMoveDiffOnHeadingF")]
public float M_InputMoveDiffOnHeadingF { get; set;}

[REDProp("m_InputMoveHeadingOnPlaneF")]
public float M_InputMoveHeadingOnPlaneF { get; set;}

[REDProp("m_InputModuleF")]
public float M_InputModuleF { get; set;}

[REDProp("m_InputMinModuleF")]
public float M_InputMinModuleF { get; set;}

[REDProp("m_InputRunModuleF")]
public float M_InputRunModuleF { get; set;}

[REDProp("m_InputHeadingDifMaxF")]
public float M_InputHeadingDifMaxF { get; set;}

[REDProp("m_InputHeadingDifReflectedF")]
public float M_InputHeadingDifReflectedF { get; set;}

[REDProp("m_JumpTimeGapF")]
public float M_JumpTimeGapF { get; set;}

[REDProp("m_RollTimePrevF")]
public float M_RollTimePrevF { get; set;}

[REDProp("m_InputDoubleTapPressValF")]
public float M_InputDoubleTapPressValF { get; set;}

[REDProp("m_InputDoubleTapUnPressValF")]
public float M_InputDoubleTapUnPressValF { get; set;}

[REDProp("m_InputDoubleTapTimeGapF")]
public float M_InputDoubleTapTimeGapF { get; set;}

[REDProp("m_UseDoubleTapOnAxisB")]
public bool M_UseDoubleTapOnAxisB { get; set;}

[REDProp("m_InputLeftO")]
public Handle<CInputAxisDoubleTap> M_InputLeftO { get; set;}

[REDProp("m_InputRightO")]
public Handle<CInputAxisDoubleTap> M_InputRightO { get; set;}

[REDProp("m_InputDownO")]
public Handle<CInputAxisDoubleTap> M_InputDownO { get; set;}

[REDProp("m_InputUpO")]
public Handle<CInputAxisDoubleTap> M_InputUpO { get; set;}

[REDProp("m_SprintDoubletapO")]
public Handle<CInputAxisDoubleTap> M_SprintDoubletapO { get; set;}

[REDProp("m_ActionJumpN")]
public CName M_ActionJumpN { get; set;}

[REDProp("m_ActionExplorationN")]
public CName M_ActionExplorationN { get; set;}

[REDProp("m_ActionInteractionN")]
public CName M_ActionInteractionN { get; set;}

[REDProp("m_ActionRollN")]
public CName M_ActionRollN { get; set;}

[REDProp("m_ActionSprintN")]
public CName M_ActionSprintN { get; set;}

[REDProp("m_ActionSkateJumpN")]
public CName M_ActionSkateJumpN { get; set;}

[REDProp("m_ActionDashN")]
public CName M_ActionDashN { get; set;}

[REDProp("m_ActionDriftN")]
public CName M_ActionDriftN { get; set;}

[REDProp("m_ActionAttackN")]
public CName M_ActionAttackN { get; set;}

[REDProp("m_ActionAttackAltN")]
public CName M_ActionAttackAltN { get; set;}

[REDProp("m_ActionParryN")]
public CName M_ActionParryN { get; set;}

[REDProp("m_SprintLastActivationTimeF")]
public float M_SprintLastActivationTimeF { get; set;}

#endregion
}
}