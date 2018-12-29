using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSendTutorialEventDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("onActivation")]
public bool OnActivation { get; set;}

[REDProp("onDeactivation")]
public bool OnDeactivation { get; set;}

[REDProp("guardSwordWarning")]
public bool GuardSwordWarning { get; set;}

[REDProp("guardGeneralWarning")]
public bool GuardGeneralWarning { get; set;}

[REDProp("guardLootingWarning")]
public bool GuardLootingWarning { get; set;}

#endregion
}
}