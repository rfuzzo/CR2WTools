using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleInteractions : CR4HudModuleBase
{
#region RED Properties

[REDProp("bShowHoldIndicator")]
public bool BShowHoldIndicator { get; set;}

[REDProp("bShowInteraction")]
public bool BShowInteraction { get; set;}

[REDProp("bShowFocusInteractions")]
public bool BShowFocusInteractions { get; set;}

[REDProp("m_fxDisableHoldIndicator")]
public Handle<CScriptedFlashFunction> M_fxDisableHoldIndicator { get; set;}

[REDProp("m_fxEnableHoldIndicator")]
public Handle<CScriptedFlashFunction> M_fxEnableHoldIndicator { get; set;}

[REDProp("m_fxSetInteractionKeySFF")]
public Handle<CScriptedFlashFunction> M_fxSetInteractionKeySFF { get; set;}

[REDProp("m_fxSetInteractionIconSFF")]
public Handle<CScriptedFlashFunction> M_fxSetInteractionIconSFF { get; set;}

[REDProp("m_fxSetInteractionTextSFF")]
public Handle<CScriptedFlashFunction> M_fxSetInteractionTextSFF { get; set;}

[REDProp("m_fxSetInteractionIconAndTextSFF")]
public Handle<CScriptedFlashFunction> M_fxSetInteractionIconAndTextSFF { get; set;}

[REDProp("m_fxSetInteractionKeyIconAndTextSFF")]
public Handle<CScriptedFlashFunction> M_fxSetInteractionKeyIconAndTextSFF { get; set;}

[REDProp("m_fxAddFocusInteractionIconSFF")]
public Handle<CScriptedFlashFunction> M_fxAddFocusInteractionIconSFF { get; set;}

[REDProp("m_fxSetInteractionHoldDuration")]
public Handle<CScriptedFlashFunction> M_fxSetInteractionHoldDuration { get; set;}

[REDProp("m_fxRemoveFocusInteractionIconSFF")]
public Handle<CScriptedFlashFunction> M_fxRemoveFocusInteractionIconSFF { get; set;}

[REDProp("m_fxUpdateFocusInteractionIconPositionSFF")]
public Handle<CScriptedFlashFunction> M_fxUpdateFocusInteractionIconPositionSFF { get; set;}

[REDProp("m_fxSetVisibilitySFF")]
public Handle<CScriptedFlashFunction> M_fxSetVisibilitySFF { get; set;}

[REDProp("m_fxSetVisibilityExSFF")]
public Handle<CScriptedFlashFunction> M_fxSetVisibilityExSFF { get; set;}

[REDProp("m_fxSetPositionsSFF")]
public Handle<CScriptedFlashFunction> M_fxSetPositionsSFF { get; set;}

[REDProp("_interactionEntity")]
public Handle<CGameplayEntity> _interactionEntity { get; set;}

[REDProp("_interactionEntityComponent")]
public Handle<CInteractionComponent> _interactionEntityComponent { get; set;}

[REDProp("m_focusInteractionIcons")]
public Array<SFocusInteractionIcon> M_focusInteractionIcons { get; set;}

[REDProp("m_previouslyShow")]
public bool M_previouslyShow { get; set;}

[REDProp("m_previousInteractionEntity")]
public Handle<CGameplayEntity> M_previousInteractionEntity { get; set;}

[REDProp("m_previousDisplayEntity")]
public Handle<CGameplayEntity> M_previousDisplayEntity { get; set;}

[REDProp("m_previousDisplayEntityDataRet")]
public bool M_previousDisplayEntityDataRet { get; set;}

[REDProp("m_forceUpdate")]
public bool M_forceUpdate { get; set;}

[REDProp("m_currentHoldInteraction")]
public CName M_currentHoldInteraction { get; set;}

[REDProp("FOCUS_INTERACION_UPDATE_INTERVAL")]
public float FOCUS_INTERACION_UPDATE_INTERVAL { get; set;}

[REDProp("FOCUS_INTERACION_RADIUS")]
public float FOCUS_INTERACION_RADIUS { get; set;}

[REDProp("FOCUS_INTERACTION_OPAQUE_ICON_RADIUS")]
public float FOCUS_INTERACTION_OPAQUE_ICON_RADIUS { get; set;}

[REDProp("FOCUS_INTERACTION_TRANSPARENT_ICON_RADIUS")]
public float FOCUS_INTERACTION_TRANSPARENT_ICON_RADIUS { get; set;}

#endregion
}
}