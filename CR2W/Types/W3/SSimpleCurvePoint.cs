using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SSimpleCurvePoint 
{
#region RED Properties

[REDProp("value")]
public Vector Value { get; set;}

[REDProp("time")]
public float Time { get; set;}

#endregion
}
}