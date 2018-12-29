using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleLootPopup : CR4HudModuleBase
{
#region RED Properties

[REDProp("KEY_LOOT_ITEM_LIST")]
public string KEY_LOOT_ITEM_LIST { get; set;}

[REDProp("container")]
public Handle<W3Container> Container { get; set;}

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("m_fxSetWindowTitle")]
public Handle<CScriptedFlashFunction> M_fxSetWindowTitle { get; set;}

[REDProp("m_fxOpenPC")]
public Handle<CScriptedFlashFunction> M_fxOpenPC { get; set;}

[REDProp("m_fxOpenConsole")]
public Handle<CScriptedFlashFunction> M_fxOpenConsole { get; set;}

[REDProp("m_fxSetSelectionIndex")]
public Handle<CScriptedFlashFunction> M_fxSetSelectionIndex { get; set;}

[REDProp("bCurrentShowState")]
public bool BCurrentShowState { get; set;}

[REDProp("m_indexToSelect")]
public Int32 M_indexToSelect { get; set;}

[REDProp("safeLock")]
public Int32 SafeLock { get; set;}

#endregion
}
}