using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEvaluatorVectorStartEnd : IEvaluatorVector
{
#region RED Properties

[REDProp("freeAxes")]
public EFreeVectorAxes FreeAxes { get; set;}

[REDProp("spill")]
public bool Spill { get; set;}

[REDProp("start")]
public Vector Start { get; set;}

[REDProp("end")]
public Vector End { get; set;}

#endregion
}
}