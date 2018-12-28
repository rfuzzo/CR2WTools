using CR2W.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
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

        //FIXME abstract classes
        public override UInt16 Flags { get; set; }
        public override UInt32 Template { get; set; }

        public override event SerializeEventHandler Serialize;
        public override event DeSerializeEventHandler DeSerialize;

        public override void OnSerialize(IFile source, REDEventArgs e) { }
        public override void OnDeSerialize(IFile source, REDEventArgs e) { }
    }
}