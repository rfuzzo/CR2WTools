using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4MapMenu : CR4MenuBase
{
#region RED Properties

[REDProp("m_shownArea")]
public EAreaName M_shownArea { get; set;}

[REDProp("m_currentArea")]
public EAreaName M_currentArea { get; set;}

[REDProp("m_fxRemoveUserMapPin")]
public Handle<CScriptedFlashFunction> M_fxRemoveUserMapPin { get; set;}

[REDProp("m_fxSetMapZooms")]
public Handle<CScriptedFlashFunction> M_fxSetMapZooms { get; set;}

[REDProp("m_fxSetMapVisibilityBoundaries")]
public Handle<CScriptedFlashFunction> M_fxSetMapVisibilityBoundaries { get; set;}

[REDProp("m_fxSetMapScrollingBoundaries")]
public Handle<CScriptedFlashFunction> M_fxSetMapScrollingBoundaries { get; set;}

[REDProp("m_fxSetMapSettings")]
public Handle<CScriptedFlashFunction> M_fxSetMapSettings { get; set;}

[REDProp("m_fxReinitializeMap")]
public Handle<CScriptedFlashFunction> M_fxReinitializeMap { get; set;}

[REDProp("m_fxEnableDebugMode")]
public Handle<CScriptedFlashFunction> M_fxEnableDebugMode { get; set;}

[REDProp("m_fxEnableUnlimitedZoom")]
public Handle<CScriptedFlashFunction> M_fxEnableUnlimitedZoom { get; set;}

[REDProp("m_fxEnableManualLod")]
public Handle<CScriptedFlashFunction> M_fxEnableManualLod { get; set;}

[REDProp("m_fxShowBorders")]
public Handle<CScriptedFlashFunction> M_fxShowBorders { get; set;}

[REDProp("m_fxSetDefaultPosition")]
public Handle<CScriptedFlashFunction> M_fxSetDefaultPosition { get; set;}

[REDProp("m_fxShowToussaint")]
public Handle<CScriptedFlashFunction> M_fxShowToussaint { get; set;}

[REDProp("m_fxSetHighlightedMapPin")]
public Handle<CScriptedFlashFunction> M_fxSetHighlightedMapPin { get; set;}

[REDProp("m_userPinNames")]
public Array<CName> M_userPinNames { get; set;}

[REDProp("currentTag")]
public CName CurrentTag { get; set;}

#endregion
}
}