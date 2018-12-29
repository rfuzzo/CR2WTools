using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodeDynamicWanderingTargetDefinition : CBehTreeNodeSelectWanderingTargetDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("dynamicWanderAreaName_var")]
public CName DynamicWanderAreaName_var { get; set;}

[REDProp("minimalWanderDistance")]
public CBehTreeValFloat MinimalWanderDistance { get; set;}

[REDProp("useGuardArea")]
public CBehTreeValBool UseGuardArea { get; set;}

#endregion
}
}