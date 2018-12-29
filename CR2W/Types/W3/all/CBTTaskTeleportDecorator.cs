using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskTeleportDecorator : CBTTaskTeleport
{
#region RED Properties

[REDProp("finished")]
public bool Finished { get; set;}

[REDProp("completeWhenTeleported")]
public bool CompleteWhenTeleported { get; set;}

#endregion
}
}