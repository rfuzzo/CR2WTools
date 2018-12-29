using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleHorsePanicBar : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetPanicSFF")]
public Handle<CScriptedFlashFunction> M_fxSetPanicSFF { get; set;}

[REDProp("_panic")]
public float _panic { get; set;}

[REDProp("horseMounted")]
public bool HorseMounted { get; set;}

[REDProp("elementShown")]
public bool ElementShown { get; set;}

#endregion
}
}