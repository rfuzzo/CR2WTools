using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CAnimDangleConstraint_Pusher : CAnimSkeletalDangleConstraint
{
#region RED Properties

[REDProp("skeleton")]
public Handle<CSkeleton> Skeleton { get; set;}

[REDProp("dispSkeleton")]
public bool DispSkeleton { get; set;}

[REDProp("dispBoneNames")]
public bool DispBoneNames { get; set;}

[REDProp("dispBoneAxis")]
public bool DispBoneAxis { get; set;}

[REDProp("boneName")]
public string BoneName { get; set;}

[REDProp("collisionName")]
public string CollisionName { get; set;}

[REDProp("offset")]
public Vector Offset { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("maxAngle")]
public float MaxAngle { get; set;}

#endregion
}
}