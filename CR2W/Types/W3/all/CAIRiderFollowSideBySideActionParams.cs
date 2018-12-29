using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIRiderFollowSideBySideActionParams : CAIRiderFollowActionParams
{
#region RED Properties

[REDProp("useCustomSteering")]
public bool UseCustomSteering { get; set;}

[REDProp("customSteeringGraph")]
public Handle<CMoveSteeringBehavior> CustomSteeringGraph { get; set;}

[REDProp("horseCustomSteeringGraph")]
public Handle<CMoveSteeringBehavior> HorseCustomSteeringGraph { get; set;}

#endregion
}
}