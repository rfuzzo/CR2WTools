using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SCurve3DData 
{
#region RED Properties

[REDProp("curveX")]
public SCurveData CurveX { get; set;}

[REDProp("curveY")]
public SCurveData CurveY { get; set;}

[REDProp("curveZ")]
public SCurveData CurveZ { get; set;}

#endregion
}
}