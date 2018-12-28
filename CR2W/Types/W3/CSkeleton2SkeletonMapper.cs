using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSkeleton2SkeletonMapper : CObject
{
#region RED Properties

[REDProp("skeletonB")]
public Handle<CSkeleton> SkeletonB { get; set;}

[REDProp("pelvisBoneName")]
public CName PelvisBoneName { get; set;}

[REDProp("motionScale")]
public float MotionScale { get; set;}

[REDProp("mappingA2B")]
public Array<Int32> MappingA2B { get; set;}

[REDProp("mappingB2A")]
public Array<Int32> MappingB2A { get; set;}

[REDProp("skeletonsAreSimilar")]
public bool SkeletonsAreSimilar { get; set;}

#endregion
}
}