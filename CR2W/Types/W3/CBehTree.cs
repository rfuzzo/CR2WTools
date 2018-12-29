using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTree : CResource
{
#region RED Properties

[REDProp("rootNode")]
public Handle<IBehTreeNodeDefinition> RootNode { get; set;}

#endregion
}
}