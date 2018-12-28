using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAnimDangleConstraint_Hinge : CAnimSkeletalDangleConstraint
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

[REDProp("name")]
public string Name { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("limit")]
public float Limit { get; set;}

[REDProp("bounce")]
public float Bounce { get; set;}

[REDProp("damp")]
public float Damp { get; set;}

[REDProp("min")]
public float Min { get; set;}

[REDProp("max")]
public float Max { get; set;}

[REDProp("inertia")]
public float Inertia { get; set;}

[REDProp("gravity")]
public float Gravity { get; set;}

[REDProp("spring")]
public float Spring { get; set;}

#endregion
}
}