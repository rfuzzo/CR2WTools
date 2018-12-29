using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SCameraDistanceInfo 
{
#region RED Properties

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("distanceRange")]
public float DistanceRange { get; set;}

[REDProp("enemiesMaxDistanceToCamera")]
public float EnemiesMaxDistanceToCamera { get; set;}

[REDProp("enemiesMaxDistanceToPlayer")]
public float EnemiesMaxDistanceToPlayer { get; set;}

[REDProp("standardDeviationRelevance")]
public float StandardDeviationRelevance { get; set;}

[REDProp("cameraZOffset")]
public float CameraZOffset { get; set;}

[REDProp("cameraZOffsetRange")]
public float CameraZOffsetRange { get; set;}

#endregion
}
}