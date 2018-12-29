using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeDynamicNodeDefinition : IBehTreeDynamicNodeBaseDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("dynamicEventName")]
public CName DynamicEventName { get; set;}

[REDProp("baseTreeVar")]
public CName BaseTreeVar { get; set;}

[REDProp("baseTree")]
public Handle<CAITree> BaseTree { get; set;}

#endregion
}
}