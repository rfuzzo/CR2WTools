using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAnimationBufferMultipart : IAnimationBuffer
{
#region RED Properties

[REDProp("numFrames")]
public uint NumFrames { get; set;}

[REDProp("numBones")]
public uint NumBones { get; set;}

[REDProp("numTracks")]
public uint NumTracks { get; set;}

[REDProp("firstFrames")]
public Array<uint> FirstFrames { get; set;}

[REDProp("parts")]
public Array<Ptr<IAnimationBuffer>> Parts { get; set;}

#endregion
}
}