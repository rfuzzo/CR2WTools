using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4AutosaveWarningMenu : CR4MenuBase
{
#region RED Properties

[REDProp("m_fxSetDuration")]
public Handle<CScriptedFlashFunction> M_fxSetDuration { get; set;}

[REDProp("m_fxSetAutosaveMessage")]
public Handle<CScriptedFlashFunction> M_fxSetAutosaveMessage { get; set;}

#endregion
}
}