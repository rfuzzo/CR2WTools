using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneEventStartBlendToGameplayCamera : CStorySceneEventCustomCamera
{
#region RED Properties

[REDProp("eventName")]
public string EventName { get; set;}

[REDProp("startPosition")]
public float StartPosition { get; set;}

[REDProp("isMuted")]
public bool IsMuted { get; set;}

[REDProp("contexID")]
public int ContexID { get; set;}

[REDProp("sceneElement")]
public Ptr<CStorySceneElement> SceneElement { get; set;}

[REDProp("GUID")]
public CGUID GUID { get; set;}

[REDProp("interpolationEventGUID")]
public CGUID InterpolationEventGUID { get; set;}

[REDProp("blendParentGUID")]
public CGUID BlendParentGUID { get; set;}

[REDProp("linkParentGUID")]
public CGUID LinkParentGUID { get; set;}

[REDProp("linkParentTimeOffset")]
public float LinkParentTimeOffset { get; set;}

[REDProp("cameraTranslation")]
public Vector CameraTranslation { get; set;}

[REDProp("cameraRotation")]
public EulerAngles CameraRotation { get; set;}

[REDProp("cameraZoom")]
public float CameraZoom { get; set;}

[REDProp("cameraFov")]
public float CameraFov { get; set;}

[REDProp("dofFocusDistFar")]
public float DofFocusDistFar { get; set;}

[REDProp("dofBlurDistFar")]
public float DofBlurDistFar { get; set;}

[REDProp("dofIntensity")]
public float DofIntensity { get; set;}

[REDProp("dofFocusDistNear")]
public float DofFocusDistNear { get; set;}

[REDProp("dofBlurDistNear")]
public float DofBlurDistNear { get; set;}

[REDProp("cameraDefinition")]
public StorySceneCameraDefinition CameraDefinition { get; set;}

[REDProp("blendTime")]
public float BlendTime { get; set;}

[REDProp("changesCamera")]
public bool ChangesCamera { get; set;}

[REDProp("lightsBlendTime")]
public float LightsBlendTime { get; set;}

#endregion
}
}