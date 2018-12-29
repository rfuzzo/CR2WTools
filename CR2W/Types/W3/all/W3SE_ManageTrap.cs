using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_ManageTrap : W3SwitchEvent
{
#region RED Properties

[REDProp("trapHandle")]
public Array<EntityHandle> TrapHandle { get; set;}

[REDProp("trapTag")]
public CName TrapTag { get; set;}

[REDProp("operations")]
public Array<ETrapOperation> Operations { get; set;}

#endregion
}
}