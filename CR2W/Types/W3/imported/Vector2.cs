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
public class Vector2 
{
#region RED Properties

[REDProp("X")]
public float X { get; set;}

[REDProp("Y")]
public float Y { get; set;}

#endregion
}
}