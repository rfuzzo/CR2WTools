using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSetActionTargetFromGameplayEventDef : IBehTreeReactionTaskDefinition
{
#region RED Properties

[REDProp("gameplayEventName")]
public CBehTreeValCName GameplayEventName { get; set;}

#endregion
}
}