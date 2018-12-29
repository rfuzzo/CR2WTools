using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskSaveTargetPosAsCustomTargetDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("useActionTarget")]
public bool UseActionTarget { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("snapToGround")]
public bool SnapToGround { get; set;}

#endregion
}
}