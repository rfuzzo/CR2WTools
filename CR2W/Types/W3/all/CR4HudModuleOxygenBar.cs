using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleOxygenBar : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetOxygeneSFF")]
public Handle<CScriptedFlashFunction> M_fxSetOxygeneSFF { get; set;}

[REDProp("oxygenePerc")]
public float OxygenePerc { get; set;}

[REDProp("forceShowElement")]
public bool ForceShowElement { get; set;}

[REDProp("bOxygeneBar")]
public bool BOxygeneBar { get; set;}

[REDProp("bIsBarFull")]
public bool BIsBarFull { get; set;}

[REDProp("isInGasArea")]
public bool IsInGasArea { get; set;}

#endregion
}
}