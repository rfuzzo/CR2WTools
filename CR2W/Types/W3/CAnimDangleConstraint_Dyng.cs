using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAnimDangleConstraint_Dyng : CAnimSkeletalDangleConstraint
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

[REDProp("dyng")]
public Handle<CDyngResource> Dyng { get; set;}

[REDProp("animSet")]
public Handle<CSkeletalAnimationSet> AnimSet { get; set;}

[REDProp("drawlinks")]
public bool Drawlinks { get; set;}

[REDProp("drawcolls")]
public bool Drawcolls { get; set;}

[REDProp("drawlimits")]
public bool Drawlimits { get; set;}

[REDProp("dampening")]
public float Dampening { get; set;}

[REDProp("gravity")]
public float Gravity { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("planeCollision")]
public bool PlaneCollision { get; set;}

[REDProp("useOffsets")]
public bool UseOffsets { get; set;}

[REDProp("shake")]
public float Shake { get; set;}

[REDProp("wind")]
public float Wind { get; set;}

[REDProp("max_links_iterations")]
public int Max_links_iterations { get; set;}

#endregion
}
}