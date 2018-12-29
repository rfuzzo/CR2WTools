using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_ManageContainer : W3SwitchEvent
{
#region RED Properties

[REDProp("containersTag")]
public CName ContainersTag { get; set;}

[REDProp("containerEnabled")]
public bool ContainerEnabled { get; set;}

#endregion
}
}