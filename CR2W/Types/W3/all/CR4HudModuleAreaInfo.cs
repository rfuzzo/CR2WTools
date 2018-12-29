using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleAreaInfo : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetTextSFF")]
public Handle<CScriptedFlashFunction> M_fxSetTextSFF { get; set;}

[REDProp("dt")]
public float Dt { get; set;}

[REDProp("showTime")]
public float ShowTime { get; set;}

[REDProp("bShow")]
public bool BShow { get; set;}

#endregion
}
}