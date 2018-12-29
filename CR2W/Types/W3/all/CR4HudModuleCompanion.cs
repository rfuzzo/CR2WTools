using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleCompanion : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetNameSFF")]
public Handle<CScriptedFlashFunction> M_fxSetNameSFF { get; set;}

[REDProp("m_fxSetPortraitSFF")]
public Handle<CScriptedFlashFunction> M_fxSetPortraitSFF { get; set;}

[REDProp("m_fxSetVitalitySFF")]
public Handle<CScriptedFlashFunction> M_fxSetVitalitySFF { get; set;}

[REDProp("m_fxSetName2SFF")]
public Handle<CScriptedFlashFunction> M_fxSetName2SFF { get; set;}

[REDProp("m_fxSetPortrait2SFF")]
public Handle<CScriptedFlashFunction> M_fxSetPortrait2SFF { get; set;}

[REDProp("m_fxSetVitality2SFF")]
public Handle<CScriptedFlashFunction> M_fxSetVitality2SFF { get; set;}

[REDProp("bShow")]
public bool BShow { get; set;}

[REDProp("m_LastVitality")]
public float M_LastVitality { get; set;}

[REDProp("m_LastMaxVitality")]
public float M_LastMaxVitality { get; set;}

[REDProp("m_LastVitality2")]
public float M_LastVitality2 { get; set;}

[REDProp("m_LastMaxVitality2")]
public float M_LastMaxVitality2 { get; set;}

[REDProp("companionNPC")]
public Handle<CNewNPC> CompanionNPC { get; set;}

[REDProp("companionNPC2")]
public Handle<CNewNPC> CompanionNPC2 { get; set;}

[REDProp("companionName")]
public string CompanionName { get; set;}

[REDProp("companionName2")]
public string CompanionName2 { get; set;}

#endregion
}
}