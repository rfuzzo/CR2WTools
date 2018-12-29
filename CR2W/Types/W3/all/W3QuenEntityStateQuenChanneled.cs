using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuenEntityStateQuenChanneled : W3SignEntityStateChanneling
{
#region RED Properties

[REDProp("HEALING_FACTOR")]
public float HEALING_FACTOR { get; set;}

[REDProp("HAXXOR_LeavingState")]
public bool HAXXOR_LeavingState { get; set;}

#endregion
}
}