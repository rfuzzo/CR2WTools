using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondTargetAttackedDelay : IBehTreeTask
{
#region RED Properties

[REDProp("delay")]
public float Delay { get; set;}

[REDProp("wasHit")]
public bool WasHit { get; set;}

#endregion
}
}