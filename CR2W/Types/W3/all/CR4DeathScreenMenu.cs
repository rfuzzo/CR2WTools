using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4DeathScreenMenu : CR4MenuBase
{
#region RED Properties

[REDProp("hasSaveData")]
public bool HasSaveData { get; set;}

[REDProp("m_fxShowInputFeedback")]
public Handle<CScriptedFlashFunction> M_fxShowInputFeedback { get; set;}

#endregion
}
}