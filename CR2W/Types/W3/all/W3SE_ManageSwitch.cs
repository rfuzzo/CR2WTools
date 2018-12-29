using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_ManageSwitch : W3SwitchEvent
{
#region RED Properties

[REDProp("switchTag")]
public CName SwitchTag { get; set;}

[REDProp("operations")]
public Array<ESwitchOperation> Operations { get; set;}

[REDProp("force")]
public bool Force { get; set;}

[REDProp("skipEvents")]
public bool SkipEvents { get; set;}

#endregion
}
}