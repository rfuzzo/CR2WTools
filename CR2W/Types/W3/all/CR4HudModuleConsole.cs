using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleConsole : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxHudConsoleMsg")]
public Handle<CScriptedFlashFunction> M_fxHudConsoleMsg { get; set;}

[REDProp("m_fxTestHudConsole")]
public Handle<CScriptedFlashFunction> M_fxTestHudConsole { get; set;}

[REDProp("m_fxCleanupHudConsole")]
public Handle<CScriptedFlashFunction> M_fxCleanupHudConsole { get; set;}

[REDProp("_iDuringDisplay")]
public Int32 _iDuringDisplay { get; set;}

[REDProp("MAX_CONSOLE_MESSEGES_DISPLAYED")]
public Int32 MAX_CONSOLE_MESSEGES_DISPLAYED { get; set;}

[REDProp("NEW_ITEM_DELAY")]
public float NEW_ITEM_DELAY { get; set;}

[REDProp("displayTime")]
public float DisplayTime { get; set;}

[REDProp("pendingMessages")]
public Array<string> PendingMessages { get; set;}

#endregion
}
}