using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4MenuBase : CR4Menu
{
#region RED Properties

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("m_flashModule")]
public Handle<CScriptedFlashSprite> M_flashModule { get; set;}

[REDProp("m_parentMenu")]
public Handle<CR4MenuBase> M_parentMenu { get; set;}

[REDProp("m_fxBlurLayer")]
public Handle<CScriptedFlashFunction> M_fxBlurLayer { get; set;}

[REDProp("m_fxSetState")]
public Handle<CScriptedFlashFunction> M_fxSetState { get; set;}

[REDProp("m_fxSetColorBlindMode")]
public Handle<CScriptedFlashFunction> M_fxSetColorBlindMode { get; set;}

[REDProp("m_fxSetCurrentModule")]
public Handle<CScriptedFlashFunction> M_fxSetCurrentModule { get; set;}

[REDProp("m_fxSetIsInCombat")]
public Handle<CScriptedFlashFunction> M_fxSetIsInCombat { get; set;}

[REDProp("m_fxShowSecondaryModulesSFF")]
public Handle<CScriptedFlashFunction> M_fxShowSecondaryModulesSFF { get; set;}

[REDProp("m_fxSetArabicAligmentMode")]
public Handle<CScriptedFlashFunction> M_fxSetArabicAligmentMode { get; set;}

[REDProp("m_fxSetGameLanguage")]
public Handle<CScriptedFlashFunction> M_fxSetGameLanguage { get; set;}

[REDProp("m_fxSetRestrictDirectClosing")]
public Handle<CScriptedFlashFunction> M_fxSetRestrictDirectClosing { get; set;}

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

[REDProp("m_fxSetTooltipState")]
public Handle<CScriptedFlashFunction> M_fxSetTooltipState { get; set;}

[REDProp("m_fxEnableDebugInput")]
public Handle<CScriptedFlashFunction> M_fxEnableDebugInput { get; set;}

[REDProp("m_fxSetPaperdollPreviewIcon")]
public Handle<CScriptedFlashFunction> M_fxSetPaperdollPreviewIcon { get; set;}

[REDProp("m_menuState")]
public CName M_menuState { get; set;}

[REDProp("m_notificationData")]
public Handle<W3TutorialPopupData> M_notificationData { get; set;}

[REDProp("m_currentContext")]
public Handle<W3UIContext> M_currentContext { get; set;}

[REDProp("m_defaultInputBindings")]
public Array<SKeyBinding> M_defaultInputBindings { get; set;}

[REDProp("m_GFxInputBindings")]
public Array<SKeyBinding> M_GFxInputBindings { get; set;}

[REDProp("m_guiManager")]
public Handle<CR4GuiManager> M_guiManager { get; set;}

[REDProp("m_commonMenu")]
public Handle<CR4CommonMenu> M_commonMenu { get; set;}

[REDProp("UISavedData")]
public SUISavedData UISavedData { get; set;}

[REDProp("m_lastSelectedModule")]
public Int32 M_lastSelectedModule { get; set;}

[REDProp("mouseCursorType")]
public ECursorType MouseCursorType { get; set;}

[REDProp("m_hideTutorial")]
public bool M_hideTutorial { get; set;}

[REDProp("m_forceHideTutorial")]
public bool M_forceHideTutorial { get; set;}

[REDProp("m_configUICalled")]
public bool M_configUICalled { get; set;}

[REDProp("m_initialSelectionsToIgnore")]
public Int32 M_initialSelectionsToIgnore { get; set;}

[REDProp("dontAutoCallOnOpeningMenuInOnConfigUIHaxxor")]
public bool DontAutoCallOnOpeningMenuInOnConfigUIHaxxor { get; set;}

#endregion
}
}