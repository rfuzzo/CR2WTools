using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleDeathScreen : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetShowBlackscreenSFF")]
public Handle<CScriptedFlashFunction> M_fxSetShowBlackscreenSFF { get; set;}

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("hasSaveData")]
public bool HasSaveData { get; set;}

[REDProp("isOpened")]
public bool IsOpened { get; set;}

#endregion
}
}