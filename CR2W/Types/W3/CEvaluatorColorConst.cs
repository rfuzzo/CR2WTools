using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEvaluatorColorConst : IEvaluatorColor
{
#region RED Properties

[REDProp("value")]
public Color Value { get; set;}

#endregion
}
}