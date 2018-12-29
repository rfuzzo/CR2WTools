using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMimicFaces : CResource
{
#region RED Properties

[REDProp("mimicSkeleton")]
public Handle<CSkeleton> MimicSkeleton { get; set;}

[REDProp("mimicPoses")]
public Array<Array<EngineQsTransform>> MimicPoses { get; set;}

[REDProp("mapping")]
public Array<Int32> Mapping { get; set;}

[REDProp("neckIndex")]
public int NeckIndex { get; set;}

[REDProp("headIndex")]
public int HeadIndex { get; set;}

[REDProp("normalBlendAreas")]
public Array<Vector> NormalBlendAreas { get; set;}

#endregion
}
}