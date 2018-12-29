using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleDebugText : CR4HudModuleBase
{
#region RED Properties

[REDProp("bCurrentShowState")]
public bool BCurrentShowState { get; set;}

[REDProp("bShouldShowElement")]
public bool BShouldShowElement { get; set;}

[REDProp("bOpenDebugText")]
public bool BOpenDebugText { get; set;}

#endregion
}
}