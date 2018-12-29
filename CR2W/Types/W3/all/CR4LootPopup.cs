using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4LootPopup : CR4PopupBase
{
#region RED Properties

[REDProp("KEY_LOOT_ITEM_LIST")]
public string KEY_LOOT_ITEM_LIST { get; set;}

[REDProp("_container")]
public Handle<W3Container> _container { get; set;}

[REDProp("m_fxSetWindowTitle")]
public Handle<CScriptedFlashFunction> M_fxSetWindowTitle { get; set;}

[REDProp("m_fxSetSelectionIndex")]
public Handle<CScriptedFlashFunction> M_fxSetSelectionIndex { get; set;}

[REDProp("m_fxSetWindowScale")]
public Handle<CScriptedFlashFunction> M_fxSetWindowScale { get; set;}

[REDProp("m_fxResizeBackground")]
public Handle<CScriptedFlashFunction> M_fxResizeBackground { get; set;}

[REDProp("m_indexToSelect")]
public Int32 M_indexToSelect { get; set;}

[REDProp("safeLock")]
public Int32 SafeLock { get; set;}

[REDProp("inputContextSet")]
public bool InputContextSet { get; set;}

#endregion
}
}