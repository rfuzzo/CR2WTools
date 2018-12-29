using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleDebugFastMenu : CR4HudModuleBase
{
#region RED Properties

[REDProp("bOpened")]
public bool BOpened { get; set;}

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

#endregion
}
}