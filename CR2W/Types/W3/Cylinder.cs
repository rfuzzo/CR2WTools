using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class Cylinder 
{
#region RED Properties

[REDProp("positionAndRadius")]
public Vector PositionAndRadius { get; set;}

[REDProp("normalAndHeight")]
public Vector NormalAndHeight { get; set;}

#endregion
}
}