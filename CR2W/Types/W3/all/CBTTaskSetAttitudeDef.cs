using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSetAttitudeDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("towardsActionTarget")]
public bool TowardsActionTarget { get; set;}

[REDProp("gameplayEventName")]
public CBehTreeValCName GameplayEventName { get; set;}

[REDProp("attitude")]
public EAIAttitude Attitude { get; set;}

#endregion
}
}