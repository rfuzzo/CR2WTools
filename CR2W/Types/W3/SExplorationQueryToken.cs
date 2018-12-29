using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SExplorationQueryToken 
{
#region RED Properties

[REDProp("valid")]
public bool Valid { get; set;}

[REDProp("type")]
public EExplorationType Type { get; set;}

[REDProp("pointOnEdge")]
public Vector PointOnEdge { get; set;}

[REDProp("normal")]
public Vector Normal { get; set;}

[REDProp("usesHands")]
public bool UsesHands { get; set;}

#endregion
}
}