using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEvaluatorFloatRandomUniform : IEvaluatorFloat
{
#region RED Properties

[REDProp("min")]
public float Min { get; set;}

[REDProp("max")]
public float Max { get; set;}

#endregion
}
}