using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBoneIndiceMapping 
{
#region RED Properties

[REDProp("startingIndex")]
public uint StartingIndex { get; set;}

[REDProp("endingIndex")]
public uint EndingIndex { get; set;}

[REDProp("chunkIndex")]
public uint ChunkIndex { get; set;}

[REDProp("boneIndex")]
public uint BoneIndex { get; set;}

#endregion
}
}