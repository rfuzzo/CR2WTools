using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4IngameMenu : CR4MenuBase
{
#region RED Properties

[REDProp("mInGameConfigWrapper")]
public Handle<CInGameConfigWrapper> MInGameConfigWrapper { get; set;}

[REDProp("inGameConfigBufferedWrapper")]
public Handle<CInGameConfigBufferedWrapper> InGameConfigBufferedWrapper { get; set;}

[REDProp("currentNewGameConfig")]
public newGameConfig CurrentNewGameConfig { get; set;}

[REDProp("m_fxNavigateBack")]
public Handle<CScriptedFlashFunction> M_fxNavigateBack { get; set;}

[REDProp("m_fxSetIsMainMenu")]
public Handle<CScriptedFlashFunction> M_fxSetIsMainMenu { get; set;}

[REDProp("m_fxSetCurrentUsername")]
public Handle<CScriptedFlashFunction> M_fxSetCurrentUsername { get; set;}

[REDProp("m_fxSetVersion")]
public Handle<CScriptedFlashFunction> M_fxSetVersion { get; set;}

[REDProp("m_fxShowHelp")]
public Handle<CScriptedFlashFunction> M_fxShowHelp { get; set;}

[REDProp("m_fxSetVisible")]
public Handle<CScriptedFlashFunction> M_fxSetVisible { get; set;}

[REDProp("m_fxSetPanelMode")]
public Handle<CScriptedFlashFunction> M_fxSetPanelMode { get; set;}

[REDProp("m_fxRemoveOption")]
public Handle<CScriptedFlashFunction> M_fxRemoveOption { get; set;}

[REDProp("m_fxSetGameLogoLanguage")]
public Handle<CScriptedFlashFunction> M_fxSetGameLogoLanguage { get; set;}

[REDProp("m_fxUpdateOptionValue")]
public Handle<CScriptedFlashFunction> M_fxUpdateOptionValue { get; set;}

[REDProp("m_fxUpdateInputFeedback")]
public Handle<CScriptedFlashFunction> M_fxUpdateInputFeedback { get; set;}

[REDProp("m_fxOnSaveScreenshotRdy")]
public Handle<CScriptedFlashFunction> M_fxOnSaveScreenshotRdy { get; set;}

[REDProp("m_fxSetIgnoreInput")]
public Handle<CScriptedFlashFunction> M_fxSetIgnoreInput { get; set;}

[REDProp("m_fxForceEnterCurEntry")]
public Handle<CScriptedFlashFunction> M_fxForceEnterCurEntry { get; set;}

[REDProp("m_fxForceBackgroundVis")]
public Handle<CScriptedFlashFunction> M_fxForceBackgroundVis { get; set;}

[REDProp("m_fxSetHardwareCursorOn")]
public Handle<CScriptedFlashFunction> M_fxSetHardwareCursorOn { get; set;}

[REDProp("m_fxSetExpansionText")]
public Handle<CScriptedFlashFunction> M_fxSetExpansionText { get; set;}

[REDProp("m_fxUpdateAnchorsAspectRatio")]
public Handle<CScriptedFlashFunction> M_fxUpdateAnchorsAspectRatio { get; set;}

[REDProp("loadConfPopup")]
public Handle<W3ApplyLoadConfirmation> LoadConfPopup { get; set;}

[REDProp("saveConfPopup")]
public Handle<W3SaveGameConfirmation> SaveConfPopup { get; set;}

[REDProp("newGameConfPopup")]
public Handle<W3NewGameConfirmation> NewGameConfPopup { get; set;}

[REDProp("actionConfPopup")]
public Handle<W3ActionConfirmation> ActionConfPopup { get; set;}

[REDProp("deleteConfPopup")]
public Handle<W3DeleteSaveConf> DeleteConfPopup { get; set;}

[REDProp("diffChangeConfPopup")]
public Handle<W3DifficultyChangeConfirmation> DiffChangeConfPopup { get; set;}

[REDProp("isShowingSaveList")]
public bool IsShowingSaveList { get; set;}

[REDProp("isShowingLoadList")]
public bool IsShowingLoadList { get; set;}

[REDProp("smartKeybindingEnabled")]
public bool SmartKeybindingEnabled { get; set;}

[REDProp("m_structureCreator")]
public Handle<IngameMenuStructureCreator> M_structureCreator { get; set;}

[REDProp("isInLoadselector")]
public bool IsInLoadselector { get; set;}

[REDProp("swapAcceptCancelChanged")]
public bool SwapAcceptCancelChanged { get; set;}

[REDProp("alternativeRadialInputChanged")]
public bool AlternativeRadialInputChanged { get; set;}

[REDProp("EnableUberMovement")]
public bool EnableUberMovement { get; set;}

[REDProp("shouldRefreshKinect")]
public bool ShouldRefreshKinect { get; set;}

[REDProp("isMainMenu")]
public bool IsMainMenu { get; set;}

[REDProp("managingPause")]
public bool ManagingPause { get; set;}

[REDProp("updateInputDeviceRequired")]
public bool UpdateInputDeviceRequired { get; set;}

[REDProp("hasChangedOption")]
public bool HasChangedOption { get; set;}

[REDProp("ignoreInput")]
public bool IgnoreInput { get; set;}

[REDProp("disableAccountPicker")]
public bool DisableAccountPicker { get; set;}

[REDProp("lastSetTag")]
public Int32 LastSetTag { get; set;}

[REDProp("currentLangValue")]
public string CurrentLangValue { get; set;}

[REDProp("lastUsedLangValue")]
public string LastUsedLangValue { get; set;}

[REDProp("currentSpeechLang")]
public string CurrentSpeechLang { get; set;}

[REDProp("lastUsedSpeechLang")]
public string LastUsedSpeechLang { get; set;}

[REDProp("languageName")]
public string LanguageName { get; set;}

[REDProp("panelMode")]
public bool PanelMode { get; set;}

[REDProp("lastSetDifficulty")]
public Int32 LastSetDifficulty { get; set;}

#endregion
}
}