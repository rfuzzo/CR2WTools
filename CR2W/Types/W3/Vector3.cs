using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class Vector3 
{
#region RED Properties

[REDProp("X")]
public float X { get; set;}

[REDProp("Y")]
public float Y { get; set;}

[REDProp("Z")]
public float Z { get; set;}

#endregion
}
}