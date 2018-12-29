using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleBoatHealth : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetVolumeHealth")]
public Handle<CScriptedFlashFunction> M_fxSetVolumeHealth { get; set;}

[REDProp("m_wasInBoat")]
public bool M_wasInBoat { get; set;}

#endregion
}
}