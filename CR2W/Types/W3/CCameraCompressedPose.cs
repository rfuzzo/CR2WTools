using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CCameraCompressedPose : CDefaultCompressedPose2
{
#region RED Properties

[REDProp("tracks")]
public Array<float> Tracks { get; set;}

#endregion
}
}