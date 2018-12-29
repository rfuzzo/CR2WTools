using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SAnimationTrajectoryPlayerInput 
{
#region RED Properties

[REDProp("localToWorld")]
public Matrix LocalToWorld { get; set;}

[REDProp("pointWS")]
public Vector PointWS { get; set;}

[REDProp("directionWS")]
public Vector DirectionWS { get; set;}

[REDProp("tagId")]
public CName TagId { get; set;}

[REDProp("selectorType")]
public EAnimationTrajectorySelectorType SelectorType { get; set;}

[REDProp("proxySyncType")]
public EActionMoveAnimationSyncType ProxySyncType { get; set;}

[REDProp("proxy")]
public Handle<CActionMoveAnimationProxy> Proxy { get; set;}

#endregion
}
}