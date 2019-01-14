using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBoneIndiceMapping 
{
#region RED Properties

[REDProp("startingIndex")]
public UInt32 StartingIndex { get; set;}

[REDProp("endingIndex")]
public UInt32 EndingIndex { get; set;}

[REDProp("chunkIndex")]
public UInt32 ChunkIndex { get; set;}

[REDProp("boneIndex")]
public UInt32 BoneIndex { get; set;}

#endregion
}
}