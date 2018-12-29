using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnSlidingEntity : CBTTaskSpawnEntityOffset
{
#region RED Properties

[REDProp("component")]
public Handle<CComponent> Component { get; set;}

[REDProp("slideComponent")]
public Handle<W3SlideToTargetComponent> SlideComponent { get; set;}

[REDProp("targetNode")]
public Handle<CNode> TargetNode { get; set;}

[REDProp("timeToFollow")]
public Int32 TimeToFollow { get; set;}

[REDProp("timeStamp")]
public float TimeStamp { get; set;}

[REDProp("destroyAfter")]
public float DestroyAfter { get; set;}

[REDProp("destroyAfterTimerEnds")]
public bool DestroyAfterTimerEnds { get; set;}

[REDProp("destroyOnDeactivate")]
public bool DestroyOnDeactivate { get; set;}

#endregion
}
}