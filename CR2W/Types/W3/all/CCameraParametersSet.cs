using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCameraParametersSet : CObject
{
#region RED Properties

[REDProp("pivotPositionControllerName")]
public CName PivotPositionControllerName { get; set;}

[REDProp("pivotPositionControllerBlend")]
public float PivotPositionControllerBlend { get; set;}

[REDProp("pivotPosForcedBlendOnNext")]
public float PivotPosForcedBlendOnNext { get; set;}

[REDProp("pivotPositionBlendFromPos")]
public bool PivotPositionBlendFromPos { get; set;}

[REDProp("forceBlendFromPosOnNextCam")]
public bool ForceBlendFromPosOnNextCam { get; set;}

[REDProp("pivotRotationController")]
public CName PivotRotationController { get; set;}

[REDProp("pivotDistanceController")]
public CName PivotDistanceController { get; set;}

[REDProp("launchAnimation")]
public bool LaunchAnimation { get; set;}

[REDProp("animationData")]
public SCameraAnimationData AnimationData { get; set;}

[REDProp("collisionOffset")]
public Vector CollisionOffset { get; set;}

#endregion
}
}