using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleHorseStaminaBar : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetStaminaSFF")]
public Handle<CScriptedFlashFunction> M_fxSetStaminaSFF { get; set;}

[REDProp("_stamina")]
public float _stamina { get; set;}

#endregion
}
}