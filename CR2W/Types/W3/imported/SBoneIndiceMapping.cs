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
public int StartingIndex { get; set;}

[REDProp("endingIndex")]
public int EndingIndex { get; set;}

[REDProp("chunkIndex")]
public int ChunkIndex { get; set;}

[REDProp("boneIndex")]
public int BoneIndex { get; set;}

#endregion
}
}