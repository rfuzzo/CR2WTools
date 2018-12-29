using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskSetEntityAsActionTargetDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("targetTag")]
public CBehTreeValCName TargetTag { get; set;}

[REDProp("multipleTargetsObjectName")]
public CName MultipleTargetsObjectName { get; set;}

[REDProp("completeImmediately")]
public bool CompleteImmediately { get; set;}

#endregion
}
}