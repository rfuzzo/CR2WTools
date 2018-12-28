using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAnimDangleConstraint_Dress : CAnimSkeletalDangleConstraint
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

[REDProp("thighBoneWeight")]
public float ThighBoneWeight { get; set;}

[REDProp("shinBoneWeight")]
public float ShinBoneWeight { get; set;}

[REDProp("kneeRollBoneWeight")]
public float KneeRollBoneWeight { get; set;}

[REDProp("ofweight")]
public float Ofweight { get; set;}

[REDProp("p1")]
public Vector P1 { get; set;}

[REDProp("p2")]
public Vector P2 { get; set;}

[REDProp("p3")]
public Vector P3 { get; set;}

[REDProp("r1")]
public Vector R1 { get; set;}

[REDProp("r2")]
public Vector R2 { get; set;}

[REDProp("r3")]
public Vector R3 { get; set;}

#endregion
}
}