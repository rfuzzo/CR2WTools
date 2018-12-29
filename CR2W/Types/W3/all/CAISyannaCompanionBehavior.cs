using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAISyannaCompanionBehavior : IAIBaseAction
{
#region RED Properties

[REDProp("params")]
public Handle<CAISyannaCompanionBehaviorParams> Params { get; set;}

[REDProp("useCustomSteering")]
public bool UseCustomSteering { get; set;}

[REDProp("customSteeringGraph")]
public Handle<CMoveSteeringBehavior> CustomSteeringGraph { get; set;}

#endregion
}
}