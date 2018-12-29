using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHorseTurnAwayFromTarget : IBehTreeTask
{
#region RED Properties

[REDProp("direction")]
public float Direction { get; set;}

[REDProp("init")]
public bool Init { get; set;}

#endregion
}
}