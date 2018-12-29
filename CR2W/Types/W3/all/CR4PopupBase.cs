using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PopupBase : CR4Popup
{
#region RED Properties

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("m_flashModule")]
public Handle<CScriptedFlashSprite> M_flashModule { get; set;}

[REDProp("m_fxSetArabicAligmentMode")]
public Handle<CScriptedFlashFunction> M_fxSetArabicAligmentMode { get; set;}

[REDProp("m_fxSetGameLanguage")]
public Handle<CScriptedFlashFunction> M_fxSetGameLanguage { get; set;}

[REDProp("m_fxSwapAcceptCancel")]
public Handle<CScriptedFlashFunction> M_fxSwapAcceptCancel { get; set;}

[REDProp("m_fxSetControllerType")]
public Handle<CScriptedFlashFunction> M_fxSetControllerType { get; set;}

[REDProp("m_fxSetPlatform")]
public Handle<CScriptedFlashFunction> M_fxSetPlatform { get; set;}

[REDProp("m_fxSetGamepadType")]
public Handle<CScriptedFlashFunction> M_fxSetGamepadType { get; set;}

[REDProp("m_fxLockControlScheme")]
public Handle<CScriptedFlashFunction> M_fxLockControlScheme { get; set;}

[REDProp("m_guiManager")]
public Handle<CR4GuiManager> M_guiManager { get; set;}

#endregion
}
}