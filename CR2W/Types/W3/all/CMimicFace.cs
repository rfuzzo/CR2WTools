using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMimicFace : CResource
{
#region RED Properties

[REDProp("mimicSkeleton")]
public Handle<CSkeleton> MimicSkeleton { get; set;}

[REDProp("floatTrackSkeleton")]
public Handle<CSkeleton> FloatTrackSkeleton { get; set;}

[REDProp("mimicPoses")]
public Array<Array<EngineQsTransform>> MimicPoses { get; set;}

[REDProp("mapping")]
public Array<Int32> Mapping { get; set;}

[REDProp("mimicTrackPoses")]
public Array<SMimicTrackPose> MimicTrackPoses { get; set;}

[REDProp("mimicFilterPoses")]
public Array<SMimicTrackPose> MimicFilterPoses { get; set;}

[REDProp("normalBlendAreas")]
public Array<Vector> NormalBlendAreas { get; set;}

[REDProp("neckIndex")]
public int NeckIndex { get; set;}

[REDProp("headIndex")]
public int HeadIndex { get; set;}

#endregion
}
}