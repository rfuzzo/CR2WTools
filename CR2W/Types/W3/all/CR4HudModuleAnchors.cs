using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleAnchors : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxUpdateAnchorsPositions")]
public Handle<CScriptedFlashFunction> M_fxUpdateAnchorsPositions { get; set;}

[REDProp("m_fxUpdateAnchorsAspectRatio")]
public Handle<CScriptedFlashFunction> M_fxUpdateAnchorsAspectRatio { get; set;}

#endregion
}
}