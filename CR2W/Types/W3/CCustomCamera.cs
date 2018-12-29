using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CCustomCamera : CEntity
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("components")]
public Array<Ptr<CComponent>> Components { get; set;}

[REDProp("template")]
public Handle<CEntityTemplate> Template { get; set;}

[REDProp("streamingDataBuffer")]
public SharedDataBuffer StreamingDataBuffer { get; set;}

[REDProp("streamingDistance")]
public byte StreamingDistance { get; set;}

[REDProp("entityStaticFlags")]
public EEntityStaticFlags EntityStaticFlags { get; set;}

[REDProp("autoPlayEffectName")]
public CName AutoPlayEffectName { get; set;}

[REDProp("entityFlags")]
public byte EntityFlags { get; set;}

[REDProp("pivotPositionControllers")]
public Array<Ptr<ICustomCameraPivotPositionController>> PivotPositionControllers { get; set;}

[REDProp("pivotRotationControllers")]
public Array<Ptr<ICustomCameraPivotRotationController>> PivotRotationControllers { get; set;}

[REDProp("pivotDistanceControllers")]
public Array<Ptr<ICustomCameraPivotDistanceController>> PivotDistanceControllers { get; set;}

[REDProp("activeCameraPositionController")]
public Ptr<ICustomCameraPositionController> ActiveCameraPositionController { get; set;}

[REDProp("blendPivotPositionController")]
public Ptr<CCustomCameraBlendPPC> BlendPivotPositionController { get; set;}

[REDProp("allowAutoRotation")]
public bool AllowAutoRotation { get; set;}

[REDProp("manualRotationHorTimeout")]
public float ManualRotationHorTimeout { get; set;}

[REDProp("manualRotationVerTimeout")]
public float ManualRotationVerTimeout { get; set;}

[REDProp("fov")]
public float Fov { get; set;}

[REDProp("animSet")]
public Handle<CSkeletalAnimationSet> AnimSet { get; set;}

[REDProp("presets")]
public Array<SCustomCameraPreset> Presets { get; set;}

[REDProp("curveSet")]
public Array<Ptr<CCurve>> CurveSet { get; set;}

[REDProp("curveNames")]
public Array<CName> CurveNames { get; set;}

#endregion
}
}