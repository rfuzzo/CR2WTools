using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageSnappingNavigableSpaceDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("snap")]
public bool Snap { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

#endregion
}
}