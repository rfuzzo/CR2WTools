using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4OverlayPopup : CR4PopupBase
{
#region RED Properties

[REDProp("m_InitDataObject")]
public Handle<W3NotificationData> M_InitDataObject { get; set;}

[REDProp("m_fxShowNotification")]
public Handle<CScriptedFlashFunction> M_fxShowNotification { get; set;}

[REDProp("m_fxHideNotification")]
public Handle<CScriptedFlashFunction> M_fxHideNotification { get; set;}

[REDProp("m_fxClearNotificationsQueue")]
public Handle<CScriptedFlashFunction> M_fxClearNotificationsQueue { get; set;}

[REDProp("m_fxShowLoadingIndicator")]
public Handle<CScriptedFlashFunction> M_fxShowLoadingIndicator { get; set;}

[REDProp("m_fxHideLoadingIndicator")]
public Handle<CScriptedFlashFunction> M_fxHideLoadingIndicator { get; set;}

[REDProp("m_fxShowSavingIndicator")]
public Handle<CScriptedFlashFunction> M_fxShowSavingIndicator { get; set;}

[REDProp("m_fxHideSavingIndicator")]
public Handle<CScriptedFlashFunction> M_fxHideSavingIndicator { get; set;}

[REDProp("m_fxAppendButton")]
public Handle<CScriptedFlashFunction> M_fxAppendButton { get; set;}

[REDProp("m_fxRemoveButton")]
public Handle<CScriptedFlashFunction> M_fxRemoveButton { get; set;}

[REDProp("m_fxRemoveContextButtons")]
public Handle<CScriptedFlashFunction> M_fxRemoveContextButtons { get; set;}

[REDProp("m_fxUpdateButtons")]
public Handle<CScriptedFlashFunction> M_fxUpdateButtons { get; set;}

[REDProp("m_fxSetMouseCursorType")]
public Handle<CScriptedFlashFunction> M_fxSetMouseCursorType { get; set;}

[REDProp("m_fxShowMouseCursor")]
public Handle<CScriptedFlashFunction> M_fxShowMouseCursor { get; set;}

[REDProp("m_fxShowSafeRect")]
public Handle<CScriptedFlashFunction> M_fxShowSafeRect { get; set;}

[REDProp("m_fxShowEP2Logo")]
public Handle<CScriptedFlashFunction> M_fxShowEP2Logo { get; set;}

[REDProp("m_cursorRequested")]
public Int32 M_cursorRequested { get; set;}

[REDProp("m_cursorHidden")]
public bool M_cursorHidden { get; set;}

#endregion
}
}