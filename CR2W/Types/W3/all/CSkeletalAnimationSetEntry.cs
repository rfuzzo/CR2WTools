using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSkeletalAnimationSetEntry : ISerializable
{
#region RED Properties

[REDProp("animation")]
public Ptr<CSkeletalAnimation> Animation { get; set;}

[REDProp("compressedPoseBlend")]
public ECompressedPoseBlend CompressedPoseBlend { get; set;}

[REDProp("params")]
public Array<Ptr<ISkeletalAnimationSetEntryParam>> Params { get; set;}

[REDProp("eventsGroupsRanges")]
public Array<SEventGroupsRanges> EventsGroupsRanges { get; set;}

#endregion
}
}