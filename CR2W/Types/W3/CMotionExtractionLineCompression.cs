using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMotionExtractionLineCompression : IMotionExtractionCompression
{
#region RED Properties

[REDProp("eps")]
public float Eps { get; set;}

[REDProp("minKnots")]
public uint MinKnots { get; set;}

#endregion
}
}