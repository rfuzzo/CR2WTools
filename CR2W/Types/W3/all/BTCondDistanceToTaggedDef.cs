using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondDistanceToTaggedDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("minDistance")]
public CBehTreeValFloat MinDistance { get; set;}

[REDProp("maxDistance")]
public CBehTreeValFloat MaxDistance { get; set;}

[REDProp("targetTag")]
public CBehTreeValCName TargetTag { get; set;}

#endregion
}
}