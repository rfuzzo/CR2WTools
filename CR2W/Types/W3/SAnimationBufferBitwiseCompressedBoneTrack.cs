using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SAnimationBufferBitwiseCompressedBoneTrack 
{
#region RED Properties

[REDProp("position")]
public SAnimationBufferBitwiseCompressedData Position { get; set;}

[REDProp("orientation")]
public SAnimationBufferBitwiseCompressedData Orientation { get; set;}

#endregion
}
}