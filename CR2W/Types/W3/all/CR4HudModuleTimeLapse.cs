using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleTimeLapse : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetShowTimeSFF")]
public Handle<CScriptedFlashFunction> M_fxSetShowTimeSFF { get; set;}

[REDProp("m_fxSetTimeLapseMessage")]
public Handle<CScriptedFlashFunction> M_fxSetTimeLapseMessage { get; set;}

[REDProp("m_fxSetTimeLapseAdditionalMessage")]
public Handle<CScriptedFlashFunction> M_fxSetTimeLapseAdditionalMessage { get; set;}

#endregion
}
}