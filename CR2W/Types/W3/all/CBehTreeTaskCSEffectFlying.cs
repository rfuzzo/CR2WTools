using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskCSEffectFlying : CBehTreeTaskCSEffect
{
#region RED Properties

[REDProp("wasFlying")]
public bool WasFlying { get; set;}

[REDProp("waitingForEndOfDisableHit")]
public bool WaitingForEndOfDisableHit { get; set;}

#endregion
}
}