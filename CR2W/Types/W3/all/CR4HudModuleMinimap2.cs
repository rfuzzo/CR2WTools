using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleMinimap2 : CR4HudModuleBase
{
#region RED Properties

[REDProp("MINIMAP_EXTERIOR_ZOOM")]
public float MINIMAP_EXTERIOR_ZOOM { get; set;}

[REDProp("MINIMAP_INTERIOR_ZOOM")]
public float MINIMAP_INTERIOR_ZOOM { get; set;}

[REDProp("MINIMAP_BOAT_ZOOM")]
public float MINIMAP_BOAT_ZOOM { get; set;}

[REDProp("HINT_WAYPOINTS_MAX_REMOVAL_DISTANCE")]
public float HINT_WAYPOINTS_MAX_REMOVAL_DISTANCE { get; set;}

[REDProp("HINT_WAYPOINTS_MIN_PLACING_DISTANCE")]
public float HINT_WAYPOINTS_MIN_PLACING_DISTANCE { get; set;}

[REDProp("HINT_WAYPOINTS_REFRESH_INTERVAL")]
public float HINT_WAYPOINTS_REFRESH_INTERVAL { get; set;}

[REDProp("HINT_WAYPOINTS_PATHFIND_TOLERANCE")]
public float HINT_WAYPOINTS_PATHFIND_TOLERANCE { get; set;}

[REDProp("HINT_WAYPOINTS_MAX_COUNT")]
public Int32 HINT_WAYPOINTS_MAX_COUNT { get; set;}

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("m_fxSetMapSettingsSFF")]
public Handle<CScriptedFlashFunction> M_fxSetMapSettingsSFF { get; set;}

[REDProp("m_fxSetTextureExtensionsSFF")]
public Handle<CScriptedFlashFunction> M_fxSetTextureExtensionsSFF { get; set;}

[REDProp("m_fxSetZoomSFF")]
public Handle<CScriptedFlashFunction> M_fxSetZoomSFF { get; set;}

[REDProp("m_fxSetPlayerRotationSFF")]
public Handle<CScriptedFlashFunction> M_fxSetPlayerRotationSFF { get; set;}

[REDProp("m_fxSetPlayerPositionSFF")]
public Handle<CScriptedFlashFunction> M_fxSetPlayerPositionSFF { get; set;}

[REDProp("m_fxSetPlayerPositionAndRotationSFF")]
public Handle<CScriptedFlashFunction> M_fxSetPlayerPositionAndRotationSFF { get; set;}

[REDProp("m_fxNotifyPlayerEnteredInteriorSFF")]
public Handle<CScriptedFlashFunction> M_fxNotifyPlayerEnteredInteriorSFF { get; set;}

[REDProp("m_fxNotifyPlayerExitedInteriorSFF")]
public Handle<CScriptedFlashFunction> M_fxNotifyPlayerExitedInteriorSFF { get; set;}

[REDProp("m_fxDoFadingSFF")]
public Handle<CScriptedFlashFunction> M_fxDoFadingSFF { get; set;}

[REDProp("m_fxEnableRotationSFF")]
public Handle<CScriptedFlashFunction> M_fxEnableRotationSFF { get; set;}

[REDProp("m_fxEnableMask")]
public Handle<CScriptedFlashFunction> M_fxEnableMask { get; set;}

[REDProp("m_fxEnableDebug")]
public Handle<CScriptedFlashFunction> M_fxEnableDebug { get; set;}

[REDProp("m_fxEnableBorders")]
public Handle<CScriptedFlashFunction> M_fxEnableBorders { get; set;}

[REDProp("m_previousPlayerPosition")]
public Vector M_previousPlayerPosition { get; set;}

[REDProp("m_previousPlayerAngle")]
public float M_previousPlayerAngle { get; set;}

[REDProp("m_previousCameraAngle")]
public float M_previousCameraAngle { get; set;}

[REDProp("m_zoomValue")]
public float M_zoomValue { get; set;}

[REDProp("m_forceUpdate")]
public bool M_forceUpdate { get; set;}

[REDProp("m_updateInterval")]
public float M_updateInterval { get; set;}

[REDProp("m_fadedOut")]
public bool M_fadedOut { get; set;}

[REDProp("m_weatherType")]
public CName M_weatherType { get; set;}

[REDProp("m_gameHour")]
public Int32 M_gameHour { get; set;}

[REDProp("m_gameMin")]
public Int32 M_gameMin { get; set;}

[REDProp("m_buffedMonsterIconPath")]
public CName M_buffedMonsterIconPath { get; set;}

[REDProp("m_dayTimeName")]
public CName M_dayTimeName { get; set;}

[REDProp("PLAYER_ANGLE_EPSILON")]
public float PLAYER_ANGLE_EPSILON { get; set;}

[REDProp("CAMERA_ANGLE_EPSILON")]
public float CAMERA_ANGLE_EPSILON { get; set;}

[REDProp("GAME_HOUR_DAWN")]
public Int32 GAME_HOUR_DAWN { get; set;}

[REDProp("GAME_HOUR_DAY")]
public Int32 GAME_HOUR_DAY { get; set;}

[REDProp("GAME_HOUR_DUSK")]
public Int32 GAME_HOUR_DUSK { get; set;}

[REDProp("GAME_HOUR_NIGHT")]
public Int32 GAME_HOUR_NIGHT { get; set;}

[REDProp("b24HRFormat")]
public bool B24HRFormat { get; set;}

[REDProp("bDisplayDayTime")]
public bool BDisplayDayTime { get; set;}

[REDProp("bDisplayBuffedMoster")]
public bool BDisplayBuffedMoster { get; set;}

#endregion
}
}