using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4ScriptedHud : CR4Hud
{
#region RED Properties

[REDProp("m_hudSize")]
public Int32 M_hudSize { get; set;}

[REDProp("m_minimapRotationEnabled")]
public bool M_minimapRotationEnabled { get; set;}

[REDProp("m_minimapZoom")]
public float M_minimapZoom { get; set;}

[REDProp("m_enabledEnemyFocus")]
public bool M_enabledEnemyFocus { get; set;}

[REDProp("m_enabledNPCNames")]
public bool M_enabledNPCNames { get; set;}

[REDProp("m_enemyHitEffects")]
public bool M_enemyHitEffects { get; set;}

[REDProp("m_dlcMessagePending")]
public bool M_dlcMessagePending { get; set;}

[REDProp("m_HudFlashSFS")]
public Handle<CScriptedFlashSprite> M_HudFlashSFS { get; set;}

[REDProp("m_fxShowModulesSFF")]
public Handle<CScriptedFlashFunction> M_fxShowModulesSFF { get; set;}

[REDProp("m_fxPrintInfoSFF")]
public Handle<CScriptedFlashFunction> M_fxPrintInfoSFF { get; set;}

[REDProp("m_fxSetInputContextSFF")]
public Handle<CScriptedFlashFunction> M_fxSetInputContextSFF { get; set;}

[REDProp("m_fxSetIsDynamicSFF")]
public Handle<CScriptedFlashFunction> M_fxSetIsDynamicSFF { get; set;}

[REDProp("m_fxSetControllerType")]
public Handle<CScriptedFlashFunction> M_fxSetControllerType { get; set;}

[REDProp("m_fxSwapAcceptCancel")]
public Handle<CScriptedFlashFunction> M_fxSwapAcceptCancel { get; set;}

[REDProp("m_fxSetGamepadType")]
public Handle<CScriptedFlashFunction> M_fxSetGamepadType { get; set;}

[REDProp("m_fxLockControlScheme")]
public Handle<CScriptedFlashFunction> M_fxLockControlScheme { get; set;}

[REDProp("m_fxSetGameLanguage")]
public Handle<CScriptedFlashFunction> M_fxSetGameLanguage { get; set;}

[REDProp("m_fxOnCutscene")]
public Handle<CScriptedFlashFunction> M_fxOnCutscene { get; set;}

[REDProp("hudModules")]
public Array<Handle<CR4HudModuleBase>> HudModules { get; set;}

[REDProp("hudModulesNames")]
public Array<CName> HudModulesNames { get; set;}

[REDProp("currentInputContext")]
public CName CurrentInputContext { get; set;}

[REDProp("previousInputContext")]
public CName PreviousInputContext { get; set;}

[REDProp("m_isDynamic")]
public bool M_isDynamic { get; set;}

[REDProp("m_guiManager")]
public Handle<CR4GuiManager> M_guiManager { get; set;}

[REDProp("m_deathTimerActive")]
public bool M_deathTimerActive { get; set;}

[REDProp("m_deathTimer")]
public float M_deathTimer { get; set;}

[REDProp("m_scaleformWidth")]
public Int32 M_scaleformWidth { get; set;}

[REDProp("m_scaleformHeight")]
public Int32 M_scaleformHeight { get; set;}

[REDProp("m_scaleformOffsetX")]
public Int32 M_scaleformOffsetX { get; set;}

[REDProp("m_scaleformOffsetY")]
public Int32 M_scaleformOffsetY { get; set;}

[REDProp("m_visibleHudBySystem")]
public bool M_visibleHudBySystem { get; set;}

[REDProp("m_visibleHudByUser")]
public bool M_visibleHudByUser { get; set;}

[REDProp("m_visibleHudByScene")]
public bool M_visibleHudByScene { get; set;}

[REDProp("m_visibleHudByRadial")]
public bool M_visibleHudByRadial { get; set;}

[REDProp("languageName")]
public string LanguageName { get; set;}

[REDProp("m_lastUsedDeviceName")]
public EInputDeviceType M_lastUsedDeviceName { get; set;}

[REDProp("_cachedEntity")]
public Handle<CEntity> _cachedEntity { get; set;}

[REDProp("_cachedEntityPosition")]
public Vector _cachedEntityPosition { get; set;}

#endregion
}
}