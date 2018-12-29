using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SAnimationSequencePartDefinition 
{
#region RED Properties

[REDProp("animation")]
public CName Animation { get; set;}

[REDProp("syncType")]
public EAnimationManualSyncType SyncType { get; set;}

[REDProp("syncEventName")]
public CName SyncEventName { get; set;}

[REDProp("shouldSlide")]
public bool ShouldSlide { get; set;}

[REDProp("shouldRotate")]
public bool ShouldRotate { get; set;}

[REDProp("useRefBone")]
public CName UseRefBone { get; set;}

[REDProp("rotationTypeUsingRefBone")]
public ESyncRotationUsingRefBoneType RotationTypeUsingRefBone { get; set;}

[REDProp("finalPosition")]
public Vector FinalPosition { get; set;}

[REDProp("finalHeading")]
public float FinalHeading { get; set;}

[REDProp("blendTransitionTime")]
public float BlendTransitionTime { get; set;}

[REDProp("blendInTime")]
public float BlendInTime { get; set;}

[REDProp("blendOutTime")]
public float BlendOutTime { get; set;}

[REDProp("allowBreakAtStart")]
public float AllowBreakAtStart { get; set;}

[REDProp("allowBreakAtStartBeforeEventsEnd")]
public CName AllowBreakAtStartBeforeEventsEnd { get; set;}

[REDProp("allowBreakBeforeEnd")]
public float AllowBreakBeforeEnd { get; set;}

[REDProp("allowBreakBeforeAtAfterEventsStart")]
public CName AllowBreakBeforeAtAfterEventsStart { get; set;}

[REDProp("sequenceIndex")]
public int SequenceIndex { get; set;}

[REDProp("disableProxyCollisions")]
public bool DisableProxyCollisions { get; set;}

#endregion
}
}