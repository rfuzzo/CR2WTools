using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSkeletalAnimationSet : CExtAnimEventsFile
{
#region RED Properties

[REDProp("requiredSfxTag")]
public CName RequiredSfxTag { get; set;}

[REDProp("animations")]
public Array<Ptr<CSkeletalAnimationSetEntry>> Animations { get; set;}

[REDProp("extAnimEvents")]
public Array<Handle<CExtAnimEventsFile>> ExtAnimEvents { get; set;}

[REDProp("skeleton")]
public Handle<CSkeleton> Skeleton { get; set;}

[REDProp("compressedPoses")]
public Array<Ptr<ICompressedPose>> CompressedPoses { get; set;}

/*[REDProp("Streaming option")]
public SAnimationBufferStreamingOption Streaming option { get; set;}

[REDProp("Number of non-streamable bones")]
public uint Number of non-streamable bones { get; set;}*/

#endregion
}
}