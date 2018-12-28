using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CTimerScriptKeyword : CObject
{
#region RED Properties

[REDProp("timeDelta")]
public float TimeDelta { get; set;}

[REDProp("timeDeltaUnscaled")]
public float TimeDeltaUnscaled { get; set;}

#endregion
}
}