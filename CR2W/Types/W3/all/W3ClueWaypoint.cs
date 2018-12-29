using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ClueWaypoint : CObject
{
#region RED Properties

[REDProp("waypointTag")]
public CName WaypointTag { get; set;}

[REDProp("clueStateInWaypoint")]
public EBoidClueState ClueStateInWaypoint { get; set;}

[REDProp("conditionsLogicalOperator")]
public ELogicalOperator ConditionsLogicalOperator { get; set;}

[REDProp("waypointReachedConditions")]
public Array<Handle<W3ClueCondition>> WaypointReachedConditions { get; set;}

#endregion
}
}