using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEvaluatorColorStartEnd : IEvaluatorColor
{
#region RED Properties

[REDProp("start")]
public Color Start { get; set;}

[REDProp("end")]
public Color End { get; set;}

#endregion
}
}