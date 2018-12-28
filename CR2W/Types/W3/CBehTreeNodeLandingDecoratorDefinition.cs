using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeLandingDecoratorDefinition : IBehTreeNodeFlightDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("landingMaxHeight")]
public CBehTreeValFloat LandingMaxHeight { get; set;}

[REDProp("landingForwardOffset")]
public CBehTreeValFloat LandingForwardOffset { get; set;}

[REDProp("tolerationDistance")]
public CBehTreeValFloat TolerationDistance { get; set;}

#endregion
}
}