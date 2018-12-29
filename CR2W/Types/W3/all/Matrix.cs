using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class Matrix 
{
#region RED Properties

[REDProp("X")]
public Vector X { get; set;}

[REDProp("Y")]
public Vector Y { get; set;}

[REDProp("Z")]
public Vector Z { get; set;}

[REDProp("W")]
public Vector W { get; set;}

#endregion
}
}