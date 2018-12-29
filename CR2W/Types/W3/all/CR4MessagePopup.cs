using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4MessagePopup : CR4PopupBase
{
#region RED Properties

[REDProp("m_messagesQueue")]
public Array<Handle<W3MessagePopupData>> M_messagesQueue { get; set;}

[REDProp("m_isMessageShown")]
public bool M_isMessageShown { get; set;}

[REDProp("m_fxHideMessage")]
public Handle<CScriptedFlashFunction> M_fxHideMessage { get; set;}

[REDProp("m_fxPrepareMessageShow")]
public Handle<CScriptedFlashFunction> M_fxPrepareMessageShow { get; set;}

[REDProp("m_fxDisplayProgressBar")]
public Handle<CScriptedFlashFunction> M_fxDisplayProgressBar { get; set;}

#endregion
}
}