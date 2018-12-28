using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeSequenceFowardAndBackDefinition : CBehTreeNodeSequenceDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("children")]
public Array<Ptr<IBehTreeNodeDefinition>> Children { get; set;}

[REDProp("checkFrequency")]
public float CheckFrequency { get; set;}

#endregion
}
}