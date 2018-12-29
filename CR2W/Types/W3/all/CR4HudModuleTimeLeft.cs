using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleTimeLeft : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetTimeOutPercent")]
public Handle<CScriptedFlashFunction> M_fxSetTimeOutPercent { get; set;}

#endregion
}
}