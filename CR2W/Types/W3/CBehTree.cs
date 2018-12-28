using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTree : CResource
{
#region RED Properties

[REDProp("rootNode")]
public Handle<IBehTreeNodeDefinition> RootNode { get; set;}

#endregion
}
}