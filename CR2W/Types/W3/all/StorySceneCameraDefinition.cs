using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class StorySceneCameraDefinition 
{
#region RED Properties

[REDProp("cameraName")]
public CName CameraName { get; set;}

[REDProp("cameraTransform")]
public EngineTransform CameraTransform { get; set;}

[REDProp("cameraZoom")]
public float CameraZoom { get; set;}

[REDProp("cameraFov")]
public float CameraFov { get; set;}

[REDProp("enableCameraNoise")]
public bool EnableCameraNoise { get; set;}

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

[REDProp("sourceSlotName")]
public CName SourceSlotName { get; set;}

[REDProp("targetSlotName")]
public CName TargetSlotName { get; set;}

[REDProp("sourceEyesHeigth")]
public float SourceEyesHeigth { get; set;}

[REDProp("targetEyesLS")]
public Vector TargetEyesLS { get; set;}

[REDProp("dof")]
public ApertureDofParams Dof { get; set;}

[REDProp("bokehDofParams")]
public SBokehDofParams BokehDofParams { get; set;}

[REDProp("genParam")]
public CEventGeneratorCameraParams GenParam { get; set;}

[REDProp("cameraAdjustVersion")]
public byte CameraAdjustVersion { get; set;}

#endregion
}
}