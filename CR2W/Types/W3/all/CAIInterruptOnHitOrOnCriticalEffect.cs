using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIInterruptOnHitOrOnCriticalEffect : IActionDecorator
{
#region RED Properties

[REDProp("completeOnHit")]
public bool CompleteOnHit { get; set;}

[REDProp("completeOnCriticalEffect")]
public bool CompleteOnCriticalEffect { get; set;}

#endregion
}
}