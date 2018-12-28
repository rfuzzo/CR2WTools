using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMotionExtractionLineCompression : IMotionExtractionCompression
{
#region RED Properties

[REDProp("eps")]
public float Eps { get; set;}

[REDProp("minKnots")]
public uint MinKnots { get; set;}

#endregion
}
}