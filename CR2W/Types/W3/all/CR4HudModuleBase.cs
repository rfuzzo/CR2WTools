using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleBase : CR4HudModule
{
#region RED Properties

[REDProp("m_fxSetControllerType")]
public Handle<CScriptedFlashFunction> M_fxSetControllerType { get; set;}

[REDProp("m_fxSetPlatform")]
public Handle<CScriptedFlashFunction> M_fxSetPlatform { get; set;}

[REDProp("m_fxShowElementSFF")]
public Handle<CScriptedFlashFunction> M_fxShowElementSFF { get; set;}

[REDProp("m_fxSetMaxOpacitySFF")]
public Handle<CScriptedFlashFunction> M_fxSetMaxOpacitySFF { get; set;}

[REDProp("m_fxSetEnabledSFF")]
public Handle<CScriptedFlashFunction> M_fxSetEnabledSFF { get; set;}

[REDProp("m_fxSetScaleFromWSSFF")]
public Handle<CScriptedFlashFunction> M_fxSetScaleFromWSSFF { get; set;}

[REDProp("m_fxShowTutorialHighlightSFF")]
public Handle<CScriptedFlashFunction> M_fxShowTutorialHighlightSFF { get; set;}

[REDProp("m_anchorName")]
public string M_anchorName { get; set;}

[REDProp("curResolutionWidth")]
public float CurResolutionWidth { get; set;}

[REDProp("curResolutionHeight")]
public float CurResolutionHeight { get; set;}

[REDProp("m_bEnabled")]
public bool M_bEnabled { get; set;}

[REDProp("m_tickInterval")]
public float M_tickInterval { get; set;}

[REDProp("m_tickCounter")]
public float M_tickCounter { get; set;}

#endregion
}
}