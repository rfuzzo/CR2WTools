using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskRiderSetCanBeFollowedDef : IBehTreeRiderTaskDefinition
{
#region RED Properties

[REDProp("setCanBeFollowed")]
public CBehTreeValBool SetCanBeFollowed { get; set;}

#endregion
}
}