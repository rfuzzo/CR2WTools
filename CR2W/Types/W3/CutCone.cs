using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CutCone 
{
#region RED Properties

[REDProp("positionAndRadius1")]
public Vector PositionAndRadius1 { get; set;}

[REDProp("normalAndRadius2")]
public Vector NormalAndRadius2 { get; set;}

[REDProp("height")]
public float Height { get; set;}

#endregion
}
}