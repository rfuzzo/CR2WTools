using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleMedallion : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetFocusPointsSFF")]
public Handle<CScriptedFlashFunction> M_fxSetFocusPointsSFF { get; set;}

[REDProp("m_fxSetVitalitySFF")]
public Handle<CScriptedFlashFunction> M_fxSetVitalitySFF { get; set;}

[REDProp("m_fxSetMedallionActiveSFF")]
public Handle<CScriptedFlashFunction> M_fxSetMedallionActiveSFF { get; set;}

[REDProp("m_fxSetMedallionThresholdSFF")]
public Handle<CScriptedFlashFunction> M_fxSetMedallionThresholdSFF { get; set;}

[REDProp("m_focusPoints")]
public Int32 M_focusPoints { get; set;}

[REDProp("m_medallionActivated")]
public bool M_medallionActivated { get; set;}

[REDProp("m_vitality")]
public float M_vitality { get; set;}

[REDProp("m_maxVitality")]
public float M_maxVitality { get; set;}

[REDProp("m_medallionThreshold")]
public float M_medallionThreshold { get; set;}

#endregion
}
}