using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SExplorationQueryContext 
{
#region RED Properties

[REDProp("inputDirectionInWorldSpace")]
public Vector InputDirectionInWorldSpace { get; set;}

[REDProp("maxAngleToCheck")]
public float MaxAngleToCheck { get; set;}

[REDProp("forJumping")]
public bool ForJumping { get; set;}

[REDProp("forDynamic")]
public bool ForDynamic { get; set;}

[REDProp("dontDoZAndDistChecks")]
public bool DontDoZAndDistChecks { get; set;}

[REDProp("laddersOnly")]
public bool LaddersOnly { get; set;}

[REDProp("forAutoTraverseSmall")]
public bool ForAutoTraverseSmall { get; set;}

[REDProp("forAutoTraverseBig")]
public bool ForAutoTraverseBig { get; set;}

#endregion
}
}