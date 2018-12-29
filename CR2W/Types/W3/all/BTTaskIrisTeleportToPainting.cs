using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskIrisTeleportToPainting : BTTaskIrisTask
{
#region RED Properties

[REDProp("percentageToHeal")]
public float PercentageToHeal { get; set;}

#endregion
}
}