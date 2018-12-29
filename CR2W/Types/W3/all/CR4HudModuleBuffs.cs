using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleBuffs : CR4HudModuleBase
{
#region RED Properties

[REDProp("_currentEffects")]
public Array<Handle<CBaseGameplayEffect>> _currentEffects { get; set;}

[REDProp("_previousEffects")]
public Array<Handle<CBaseGameplayEffect>> _previousEffects { get; set;}

[REDProp("_forceUpdate")]
public bool _forceUpdate { get; set;}

[REDProp("m_fxSetPercentSFF")]
public Handle<CScriptedFlashFunction> M_fxSetPercentSFF { get; set;}

[REDProp("m_fxShowBuffUpdateFx")]
public Handle<CScriptedFlashFunction> M_fxShowBuffUpdateFx { get; set;}

[REDProp("m_fxsetViewMode")]
public Handle<CScriptedFlashFunction> M_fxsetViewMode { get; set;}

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("iCurrentEffectsSize")]
public Int32 ICurrentEffectsSize { get; set;}

[REDProp("bDisplayBuffs")]
public bool BDisplayBuffs { get; set;}

[REDProp("m_runword5Applied")]
public bool M_runword5Applied { get; set;}

#endregion
}
}