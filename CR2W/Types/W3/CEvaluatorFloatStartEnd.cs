using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEvaluatorFloatStartEnd : IEvaluatorFloat
{
#region RED Properties

[REDProp("start")]
public float Start { get; set;}

[REDProp("end")]
public float End { get; set;}

#endregion
}
}