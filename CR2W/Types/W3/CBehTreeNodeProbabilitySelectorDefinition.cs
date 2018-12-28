using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeProbabilitySelectorDefinition : IBehTreeNodeCompositeDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("children")]
public Array<Ptr<IBehTreeNodeDefinition>> Children { get; set;}

[REDProp("testAvailability")]
public bool TestAvailability { get; set;}

[REDProp("probability0")]
public byte Probability0 { get; set;}

[REDProp("probability1")]
public byte Probability1 { get; set;}

[REDProp("probability2")]
public byte Probability2 { get; set;}

[REDProp("probability3")]
public byte Probability3 { get; set;}

[REDProp("probability4")]
public byte Probability4 { get; set;}

[REDProp("probability5")]
public byte Probability5 { get; set;}

#endregion
}
}