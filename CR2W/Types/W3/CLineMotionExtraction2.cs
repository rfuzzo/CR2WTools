using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CLineMotionExtraction2 : IMotionExtraction
{
#region RED Properties

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("frames")]
public Array<float> Frames { get; set;}

[REDProp("deltaTimes")]
public Array<byte> DeltaTimes { get; set;}

[REDProp("flags")]
public byte Flags { get; set;}

#endregion
}
}