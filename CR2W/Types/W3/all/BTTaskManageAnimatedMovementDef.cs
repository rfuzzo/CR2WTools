using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageAnimatedMovementDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("overrideOnly")]
public bool OverrideOnly { get; set;}

[REDProp("flag")]
public bool Flag { get; set;}

#endregion
}
}