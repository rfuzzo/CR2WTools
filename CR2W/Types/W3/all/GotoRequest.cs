using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class GotoRequest : CObject
{
#region RED Properties

[REDProp("groupId")]
public CFlyingGroupId GroupId { get; set;}

[REDProp("groupState")]
public CName GroupState { get; set;}

[REDProp("groupStateSetOnArrival")]
public CName GroupStateSetOnArrival { get; set;}

[REDProp("targetPoiComponent")]
public Handle<CBoidPointOfInterestComponent> TargetPoiComponent { get; set;}

[REDProp("targetNode")]
public Handle<CNode> TargetNode { get; set;}

[REDProp("delay")]
public float Delay { get; set;}

[REDProp("delayTimer")]
public float DelayTimer { get; set;}

[REDProp("factID")]
public string FactID { get; set;}

[REDProp("factValue")]
public Int32 FactValue { get; set;}

[REDProp("groupCenterWhenStart")]
public Vector GroupCenterWhenStart { get; set;}

[REDProp("init")]
public bool Init { get; set;}

#endregion
}
}