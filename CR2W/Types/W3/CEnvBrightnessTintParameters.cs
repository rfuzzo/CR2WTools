using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvBrightnessTintParameters 
{
#region RED Properties

[REDProp("tint")]
public Vector Tint { get; set;}

[REDProp("brightness")]
public float Brightness { get; set;}

#endregion
}
}