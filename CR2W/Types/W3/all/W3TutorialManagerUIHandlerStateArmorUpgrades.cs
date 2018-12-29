using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateArmorUpgrades : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("TAB")]
public CName TAB { get; set;}

[REDProp("UPGRADE")]
public CName UPGRADE { get; set;}

[REDProp("ITEM")]
public CName ITEM { get; set;}

#endregion
}
}