using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleSignInfo : CR4HudModuleBase
{
#region RED Properties

[REDProp("_iconName")]
public string _iconName { get; set;}

[REDProp("_CurrentSelectedSign")]
public ESignType _CurrentSelectedSign { get; set;}

[REDProp("m_fxShowBckArrowSFF")]
public Handle<CScriptedFlashFunction> M_fxShowBckArrowSFF { get; set;}

[REDProp("m_fxEnableSFF")]
public Handle<CScriptedFlashFunction> M_fxEnableSFF { get; set;}

#endregion
}
}