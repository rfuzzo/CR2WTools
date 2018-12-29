using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondIsTargettedBy : IBehTreeTask
{
#region RED Properties

[REDProp("isTargettedByActors")]
public bool IsTargettedByActors { get; set;}

[REDProp("isTargettedByPlayer")]
public bool IsTargettedByPlayer { get; set;}

#endregion
}
}