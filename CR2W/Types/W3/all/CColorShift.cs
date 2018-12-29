using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CColorShift 
{
#region RED Properties

[REDProp("hue")]
public UInt16 Hue { get; set;}

[REDProp("saturation")]
public sbyte Saturation { get; set;}

[REDProp("luminance")]
public sbyte Luminance { get; set;}

#endregion
}
}