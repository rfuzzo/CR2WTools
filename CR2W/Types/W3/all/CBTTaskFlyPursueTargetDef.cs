using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFlyPursueTargetDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("useCustom")]
public bool UseCustom { get; set;}

[REDProp("distanceFromTarget")]
public float DistanceFromTarget { get; set;}

[REDProp("heightFromTarget")]
public float HeightFromTarget { get; set;}

[REDProp("distanceTolerance")]
public float DistanceTolerance { get; set;}

[REDProp("randomHeight")]
public Int32 RandomHeight { get; set;}

[REDProp("predictPositionTime")]
public float PredictPositionTime { get; set;}

#endregion
}
}