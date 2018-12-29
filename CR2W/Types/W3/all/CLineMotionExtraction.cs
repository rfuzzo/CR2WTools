using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CLineMotionExtraction : IMotionExtraction
{
#region RED Properties

[REDProp("frames")]
public Array<Vector> Frames { get; set;}

[REDProp("times")]
public Array<float> Times { get; set;}

#endregion
}
}