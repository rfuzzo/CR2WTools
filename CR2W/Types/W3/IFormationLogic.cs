using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IFormationLogic : CObject
{
#region RED Properties

[REDProp("recomputionDelay")]
public float RecomputionDelay { get; set;}

[REDProp("minCatchupDistance")]
public float MinCatchupDistance { get; set;}

#endregion
}
}