using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskSoundSwitchDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("swichGroupName")]
public CName SwichGroupName { get; set;}

[REDProp("stateName")]
public string StateName { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

#endregion
}
}