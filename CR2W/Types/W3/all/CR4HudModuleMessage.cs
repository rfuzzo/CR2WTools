using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleMessage : CR4HudModuleBase
{
#region RED Properties

[REDProp("_bDuringDisplay")]
public bool _bDuringDisplay { get; set;}

[REDProp("_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> _flashValueStorage { get; set;}

#endregion
}
}