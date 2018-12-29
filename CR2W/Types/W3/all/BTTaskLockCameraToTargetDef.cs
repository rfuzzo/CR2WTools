using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskLockCameraToTargetDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("lock")]
public bool Lock { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

#endregion
}
}