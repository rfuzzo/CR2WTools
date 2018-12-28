using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeConditionalTreeDefinition : CBehTreeNodeBaseConditionalTreeDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("invert")]
public bool Invert { get; set;}

[REDProp("val")]
public CBehTreeValBool Val { get; set;}

#endregion
}
}