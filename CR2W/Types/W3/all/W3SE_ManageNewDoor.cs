using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_ManageNewDoor : W3SwitchEvent
{
#region RED Properties

[REDProp("doorTag")]
public CName DoorTag { get; set;}

[REDProp("operations")]
public Array<ENewDoorOperation> Operations { get; set;}

[REDProp("force")]
public bool Force { get; set;}

#endregion
}
}