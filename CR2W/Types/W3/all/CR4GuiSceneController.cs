using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4GuiSceneController : CObject
{
#region RED Properties

[REDProp("_isEntitySpawning")]
public bool _isEntitySpawning { get; set;}

[REDProp("_entityTemplateAlias")]
public string _entityTemplateAlias { get; set;}

[REDProp("_entityAppearance")]
public CName _entityAppearance { get; set;}

[REDProp("_environmentAlias")]
public string _environmentAlias { get; set;}

[REDProp("_environmentSunRotation")]
public EulerAngles _environmentSunRotation { get; set;}

[REDProp("_cameraUpdate")]
public bool _cameraUpdate { get; set;}

[REDProp("_cameraLookAt")]
public Vector _cameraLookAt { get; set;}

[REDProp("_cameraRotation")]
public EulerAngles _cameraRotation { get; set;}

[REDProp("_cameraDistance")]
public float _cameraDistance { get; set;}

[REDProp("_fov")]
public float _fov { get; set;}

[REDProp("_updateItems")]
public bool _updateItems { get; set;}

[REDProp("_cachedDyes")]
public Array<CName> _cachedDyes { get; set;}

[REDProp("_appliedDyesPreview")]
public Array<CName> _appliedDyesPreview { get; set;}

[REDProp("_entityPosition")]
public Vector _entityPosition { get; set;}

[REDProp("_entityRotation")]
public EulerAngles _entityRotation { get; set;}

[REDProp("_entityScale")]
public Vector _entityScale { get; set;}

[REDProp("_updateEntityTransform")]
public bool _updateEntityTransform { get; set;}

[REDProp("m_charRenderFocus")]
public EGuiSceneControllerRenderFocus M_charRenderFocus { get; set;}

[REDProp("m_charFocusOriginZ")]
public float M_charFocusOriginZ { get; set;}

[REDProp("m_charFocusOriginDistance")]
public float M_charFocusOriginDistance { get; set;}

[REDProp("m_charFocusTargetZ")]
public float M_charFocusTargetZ { get; set;}

[REDProp("m_charFocusTargetDistance")]
public float M_charFocusTargetDistance { get; set;}

[REDProp("m_charFocusBlendTimer")]
public float M_charFocusBlendTimer { get; set;}

[REDProp("m_charFocusBlendTime")]
public float M_charFocusBlendTime { get; set;}

[REDProp("m_distanceMin")]
public float M_distanceMin { get; set;}

[REDProp("m_distanceMax")]
public float M_distanceMax { get; set;}

[REDProp("m_zMin")]
public float M_zMin { get; set;}

[REDProp("m_zMax")]
public float M_zMax { get; set;}

[REDProp("m_zBody")]
public float M_zBody { get; set;}

#endregion
}
}