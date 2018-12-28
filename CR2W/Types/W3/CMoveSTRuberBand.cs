using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTRuberBand : IMoveSteeringTask
{
#region RED Properties

[REDProp("halfRange")]
public float HalfRange { get; set;}

[REDProp("tensionCurve")]
public SSimpleCurve TensionCurve { get; set;}

[REDProp("minAllowedSpeed")]
public float MinAllowedSpeed { get; set;}

#endregion
}
}